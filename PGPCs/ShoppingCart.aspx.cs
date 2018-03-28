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
        var db = new PRODUCTCONTEXT();
        var Order = new ORDERS();
        List <SHOPPINGCARTITEMS> CartItems = GetCartItems();
        List<ORDERITEMS> OrderItems = new List<ORDERITEMS>();
        Order.CUSTOMER_ID = int.Parse(Session["UserID"].ToString());
        Order.ORDER_PLACED = DateTime.Now;
        db.Orders.Add(Order);
        db.SaveChanges();
        int orderID = Order.ORDER_ID;

        foreach(SHOPPINGCARTITEMS item in CartItems)
        {
            OrderItems.Add(new ORDERITEMS
            {
                ORDER_ID = orderID,
                PRODUCT_ID = item.PRODUCT_ID,
                QUANTITY = item.QUANTITY
            });
        }

        foreach(ORDERITEMS orderContext in OrderItems)
        {
            db.OrderItems.Add(orderContext);
        }
        db.SaveChanges();
    }  
}
