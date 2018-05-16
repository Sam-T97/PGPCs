using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PGPCs.Models;

public partial class AdminPages_ApproveNewAccounts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void awaiting_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int ID = int.Parse(e.CommandArgument.ToString());
        var db = new PRODUCTCONTEXT();
        CUSTOMER toApprove = db.Customers.Where(i => i.CUSTOMER_ID == ID).FirstOrDefault();
        toApprove.FROZEN = false;
        toApprove.NEW_ACCT = false;
        db.SaveChanges();
        Response.Redirect(Request.RawUrl);
    }

    public IQueryable<PGPCs.Models.CUSTOMER> awaiting_GetData()
    {
        var db = new PRODUCTCONTEXT();
        IQueryable<CUSTOMER> cust = db.Customers.Where(n => n.NEW_ACCT == true);
        return cust;
    }

    public IQueryable<CUSTOMER> reBind()
    {
        var db = new PRODUCTCONTEXT();
        IQueryable<CUSTOMER> cust = db.Customers.Where(n => n.NEW_ACCT == true);
        return cust;
    }
}