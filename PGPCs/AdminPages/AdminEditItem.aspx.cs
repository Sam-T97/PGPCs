using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PGPCs.Models;
using System.Data.Entity;

public partial class AdminPages_AdminEditItem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void btnSearch_Click(object sender, EventArgs e)
    {
        getProduct();
    }

    public void getProduct()
    {
        ProductInfo.DataSource = GetDetailsList();
        ProductInfo.DataBind();
    }

    public List<PRODUCT> GetDetailsList()
    {
        int ID = int.Parse(prodID.Text);
        var db = new PRODUCTCONTEXT();
        return db.Products.Where(i => i.PRODUCT_ID == ID).ToList();
    }

}