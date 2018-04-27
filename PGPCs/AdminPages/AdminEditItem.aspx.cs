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
    static int ID;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void btnSearch_Click(object sender, EventArgs e)
    {
        lblNoData.Visible = false;
        getdetails();
    }

    public void getdetails()
    {
        var db = new PRODUCTCONTEXT();
        ID = int.Parse(prodID.Text);
        PRODUCT grabbed;
        try
        {
            grabbed = db.Products.Where(u => u.PRODUCT_ID == ID).First();
            ProdNametxt.Text = grabbed.PRODUCT_NAME.ToString();
            ProdDesctxt.Text = grabbed.PRODUCT_DESCRIPTION.ToString();
            PriceTxt.Text = grabbed.PRICE.ToString();
        } catch (Exception e)
        {
            lblNoData.Text = "No data was returned check SKU number and try again";
            lblNoData.Visible = true;
        }
    }

    public void btnSave_Click(object sender, EventArgs e)
    {
        PRODUCT grabbed;
        var db = new PRODUCTCONTEXT();
        grabbed = db.Products.Where(u => u.PRODUCT_ID == ID).First();
        grabbed.PRICE = int.Parse(PriceTxt.Text);
        grabbed.PRODUCT_NAME = ProdNametxt.Text;
        grabbed.PRODUCT_DESCRIPTION = ProdDesctxt.Text;
        db.SaveChanges();
        Response.Redirect("~/Products/ProductDetails.aspx?ID=" + ID);
        
    }
}