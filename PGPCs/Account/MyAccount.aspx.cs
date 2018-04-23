using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using PGPCs.Models;
using System.Web.UI.WebControls;

public partial class Account_MyAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        orders.DataSource = getOrders();
        orders.DataBind();
    }

    protected void ViewDetails_Command(object sender, CommandEventArgs e)
    {
        orderDetails.DataSource = getDetails(int.Parse(e.CommandArgument.ToString()));
        orderDetails.DataBind();
    }

    public List<ORDERS> getOrders()
    {
        var db = new PRODUCTCONTEXT();
        int ID = int.Parse(Session["UserID"].ToString());
        return db.Orders.Where(u => u.CUSTOMER_ID == ID).ToList();

    }

    public List<ORDERITEMS> getDetails(int orderID)
    {
        var db = new PRODUCTCONTEXT();
        return db.OrderItems.Where(u => u.ORDER_ID == orderID).ToList();
    }
}