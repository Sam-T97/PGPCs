using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PGPCs;
using PGPCs.Models;
using System.ComponentModel.DataAnnotations;

namespace PGPCs
{
    public class SHOPPINGCARTITEMS
    {
        [ScaffoldColumn(false), Key]
        public int ITEM_ID { get; set; }

        public int CART_ID { get; set; }

        public int PRODUCT_ID { get; set; }

        public int QUANTITY { get; set; }

        //public virtual SHOPPINGCART SHOPPINGCART { get; set; }
        
        public virtual PRODUCT PRODUCT { get; set; }
    }
}