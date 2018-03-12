using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PGPCs.Models;
using System.Web.ModelBinding;
using PGPCs.Logic;
using System.Data.Entity;


public partial class Products_ProductDetails : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public IQueryable<PRODUCT> GetProducts ([QueryString("ID")] Nullable<int> ProdID)
    {
        var db = new PRODUCTCONTEXT();
        IQueryable<PRODUCT> query = db.Products;
        if (ProdID.HasValue && ProdID > 0)
        {
            query = query.Where(p => p.PRODUCT_ID == ProdID);
        }
        else
        {
            query = null;
        }
        return query;
    }

    public void btnAddToCartClick (object sender, EventArgs e)
    {
        if(Session["UserID"] == null)
        {
            Response.Redirect("~/Account/Login");
        }
        else
        {
            if(int.Parse(quantity.Text) < 20 && int.Parse(quantity.Text) > 0)
            {
                int usrID = int.Parse(Session["UserID"].ToString());
                int prodID = int.Parse(Request.QueryString["ID"]);
                int quant = int.Parse(quantity.Text);
                var usersCart = new ShoppingCartActions();
                usersCart.AddToCart(usrID, prodID, quant);
                Response.Redirect("~/Account/WebCart");
            }
            else
            {
                return;
            }

        }
    }
}

