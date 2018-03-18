using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.UI;
using System.Text;
using PGPCs;
using PGPCs.Models;


public partial class AdminPages_Admin_Add_Item : System.Web.UI.Page
{
    protected void NewProduct_Click(object sender, EventArgs e)
    {
        var db = new PRODUCTCONTEXT();
        var product = new PRODUCT();
        product.PRODUCT_ID = int.Parse(ProductID.Text);
        product.PRODUCT_NAME = ProductName.Text;
        product.PRODUCT_DESCRIPTION = ProductDesc.Text;
        product.PRICE = int.Parse(ProductPrice.Text);
        product.IMAGE_NAME = ImageName.Text;
        db.Products.Add(product);
        db.SaveChanges();
        Response.Redirect("/AdminPages/AdminHome.aspx");
    }
}