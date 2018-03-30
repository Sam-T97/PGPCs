﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using PGPCs.Models;

public partial class AdminPages_AdminOrders : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public IQueryable<ORDERS> GetOrders([QueryString("ID")] Nullable<int> CatID)
    {
        var db = new PRODUCTCONTEXT();
        IQueryable<ORDERS> query = db.Orders;
        if (CatID.HasValue && CatID > 0)
        {
            query = query.Where(p => p.ORDER_ID == CatID);
        }
        return query;
    }
}