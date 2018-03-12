using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PGPCs.Models;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["UserID"] != null)
        {
            int ID = int.Parse(Session["UserID"].ToString());
            var db = new PRODUCTCONTEXT();
            string customerName = db.Customers.Where(u => u.CUSTOMER_ID == ID).Select(n => n.CUSTOMER_FIRST_NAME).FirstOrDefault();
            Message.Text = "Welcome back " + customerName + "!";
        }
    }
}