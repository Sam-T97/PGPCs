using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using PGPCs.Models;
using PGPCs.Logic;
using PGPCs;


public partial class ShoppingCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect("~/Account/Login");
        }
        else
        {
            ShoppingCartList.DataSource = GetCartItems();
            ShoppingCartList.DataBind();
        }
    }
    public List<SHOPPINGCARTITEMS> GetCartItems()
    {
        ShoppingCartActions actions = new ShoppingCartActions();
        return actions.GetCartItems(int.Parse(Session["UserID"].ToString()));
    }

    public void btnCheckout_Click(object sender, EventArgs e)
    {
        //Initalise DB
        var db = new PRODUCTCONTEXT();
        //Make a new order item
        var Order = new ORDERS();
        //Get a list of the users cart
        List <SHOPPINGCARTITEMS> CartItems = GetCartItems();
        //Only place the order if there are items in the cart otherwise do nothing
        if (CartItems.Count > 0)
        {
            //Create a list of order items
            List<ORDERITEMS> OrderItems = new List<ORDERITEMS>();
            //Grab the customers id from the seesion state
            Order.CUSTOMER_ID = int.Parse(Session["UserID"].ToString());
            //Get the current time
            Order.ORDER_PLACED = DateTime.Now;
            //Add the order to the db
            db.Orders.Add(Order);
            //Save the changes
            db.SaveChanges();
            //Grab the order ID 
            int orderID = Order.ORDER_ID;
            //Prep the list of order items
            foreach (SHOPPINGCARTITEMS item in CartItems)
            {
                OrderItems.Add(new ORDERITEMS
                {
                    ORDER_ID = orderID,
                    PRODUCT_ID = item.PRODUCT_ID,
                    QUANTITY = item.QUANTITY
                });
            }
            //Add those items to the DB
            foreach (ORDERITEMS orderContext in OrderItems)
            {
                db.OrderItems.Add(orderContext);
            }
            //Save the changes
            db.SaveChanges();
            ShoppingCartActions actions = new ShoppingCartActions();
            actions.ClearCart(int.Parse(Session["UserID"].ToString()));
            Response.Redirect("~/OrderPlaced");
        }
    }  
}
