using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.UI;
using System.Text;
using PGPCs;
using PGPCs.Models;
using System.IO;


public partial class AdminPages_Admin_Add_Item : System.Web.UI.Page
{
    protected void NewProduct_Click(object sender, EventArgs e)
    {
        var db = new PRODUCTCONTEXT();
        var product = new PRODUCT();
        bool filePassed = false;
        string path = Server.MapPath("~/Assets/Thumbnails/");
        string[] allowedExtensions = { ".jpg", ".png", ".jpeg" };
        if (ImageName.HasFile)
        {
            string extension = Path.GetExtension(ImageName.FileName.ToLower());
            for(int i =0; i < allowedExtensions.Length; i++)
            {
                if(extension == allowedExtensions[i])
                {
                    filePassed = true;
                }
            }
        }
        if(filePassed == true)
        {
            try
            {
                ImageName.PostedFile.SaveAs(path + ImageName.FileName);
                product.IMAGE_NAME = ImageName.FileName;
            }
            catch (Exception error)
            {
                ErrorMessage.Text = error.Message;
            }
        }
        product.PRODUCT_NAME = ProductName.Text;
        product.PRODUCT_DESCRIPTION = ProductDesc.Text;
        product.PRICE = int.Parse(ProductPrice.Text);
        product.CATEGORY_ID = ProductCat.SelectedIndex + 1;
        db.Products.Add(product);
        db.SaveChanges();
        Response.Redirect("~/AdminPages/AdminHome");
    }
    public IQueryable GetCategories()
    {
        var db = new PRODUCTCONTEXT();
        IQueryable query = db.Categories;
        return query;
    }
}