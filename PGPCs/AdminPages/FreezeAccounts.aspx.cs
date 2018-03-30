using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PGPCs.Models;
using System.Data.Entity;

public partial class AdminPages_FreezeAccounts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void btnSearch_Click(object sender, EventArgs e)
    {
        getDetails();
    }

    public void getDetails()
    {
        AccountDetails.DataSource = GetDetailsList();
        AccountDetails.DataBind();
    }
    public List<CUSTOMER> GetDetailsList()
    {
        int ID = int.Parse(txtID.Text);
        var db = new PRODUCTCONTEXT();
        return db.Customers.Where(i => i.CUSTOMER_ID == ID).ToList();
    }

    protected void command(object sender, GridViewCommandEventArgs e)
    {
        int ID = int.Parse(txtID.Text);
        AccountActions actions = new AccountActions();
        switch (e.CommandName)
        {
            case "Freeze":
                actions.freezeAccount(ID);
                break;
            case "Unfreeze":
                actions.unFreezeAccount(ID);
                break;
        }
        getDetails();
    }
}