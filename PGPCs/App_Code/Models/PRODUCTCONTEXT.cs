using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

/// <summary>
/// Summary description for PRODUCTCONTEXT
/// </summary>
namespace PGPCs.Models
{
    public class PRODUCTCONTEXT : DbContext
    {
        public PRODUCTCONTEXT() : base ("PGPCs")
        {}
        public DbSet<CATEGORY> Categories { get; set; }
        public DbSet<PRODUCT> Products { get; set; }
        public DbSet<CUSTOMER> Customers { get; set; }
        public DbSet<ADMIN> Admins { get; set; }
        public DbSet<SHOPPINGCARTITEMS> ShoppingCartItems { get; set; }
        //public DbSet<SHOPPINGCART>ShoppingCart { get; set; }
    }
}