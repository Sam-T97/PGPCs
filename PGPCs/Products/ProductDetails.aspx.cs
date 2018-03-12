using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PGPCs.Models;
using System.Web.ModelBinding;


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
}

