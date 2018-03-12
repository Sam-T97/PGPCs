using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using PGPCs.Models;
using PGPCs.Logic;
using PGPCs;


public partial class ShoppingCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public List<SHOPPINGCARTITEMS> GetCartItems()
    {
        ShoppingCartActions actions = new ShoppingCartActions();
        return actions.GetCartItems(int.Parse(Session["UserID"].ToString()));
    }

}
