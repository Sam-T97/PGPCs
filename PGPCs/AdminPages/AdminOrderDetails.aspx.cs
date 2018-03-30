using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PGPCs.Models;

public partial class AdminPages_AdminOrderDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int ID = int.Parse(Request.QueryString["ID"]);
        customerDetails.DataSource = getCust(ID);
        customerDetails.DataBind();
        orderDetails.DataSource = getItems(ID);
        orderDetails.DataBind();
    }

    public List<ORDERITEMS> getItems(int ID)
    {
        var db = new PRODUCTCONTEXT();
        return db.OrderItems.Where(i => i.ORDER_ID == ID).ToList();

    }
    public List<CUSTOMER> getCust(int ID)
    {
        var db = new PRODUCTCONTEXT();
        int CustID = db.Orders.Where(i => i.ORDER_ID == ID).Select(u => u.CUSTOMER_ID).First();
        return db.Customers.Where(cID => cID.CUSTOMER_ID == CustID).ToList();
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        int ID = int.Parse(Request.QueryString["ID"]);
        var db = new PRODUCTCONTEXT();
        ORDERS order = db.Orders.Where(u => u.ORDER_ID == ID).First();
        order.STATUS = ddlStat.SelectedValue;
        db.SaveChanges();
    }
}