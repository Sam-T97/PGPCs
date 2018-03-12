using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PGPCs.Logic;
using PGPCs.Models;


namespace PGPCs
{
    public partial class Account_WebCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public List<SHOPPINGCARTITEMS> getItems()
        {
            ShoppingCartActions actions = new ShoppingCartActions();
            return actions.GetCartItems(int.Parse(Session["UserID"].ToString()));
        }
    }
}