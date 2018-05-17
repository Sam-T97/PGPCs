using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PGPCs.Models;

public partial class Account_Invoice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerDetails.DataSource = getDetails();
        CustomerDetails.DataBind();
        orders.DataSource = getOrder();
        orders.DataBind();
    }

    public List<CUSTOMER> getDetails()
    {
        var db = new PRODUCTCONTEXT();
        int ID = int.Parse(Session["UserID"].ToString());
        return db.Customers.Where(u => u.CUSTOMER_ID == ID).ToList();
    }

    public List<ORDERS> getOrder()
    {
        int orderID = 1;//int.Parse(Request.QueryString["ID"].ToString());
        int custID = 1;//int.Parse(Session["UserID"].ToString());
        var db = new PRODUCTCONTEXT();
        getDetails(orderID);
        return db.Orders.Where(u => u.ORDER_ID == orderID && u.CUSTOMER_ID == custID).ToList();
    }

    public void getDetails(int orderID)
    {
        orderDetails.DataSource = getOrderDetails(orderID);
        orderDetails.DataBind();
    }

    public List<ORDERITEMS> getOrderDetails(int ID)
    {
        var db = new PRODUCTCONTEXT();
        return db.OrderItems.Where(i => i.ORDER_ID == ID).ToList();
    }
}