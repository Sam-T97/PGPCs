using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PGPCs;
using PGPCs.Models;
using System.ComponentModel.DataAnnotations;

namespace PGPCs
{
    public class SHOPPINGCART
    {
        [ScaffoldColumn(false), Key]
        public int SHOPPING_CART_ID { get; set; }

        public int CUSTOMER_ID { get; set; }

        public virtual CUSTOMER CUSTOMER { get; set; }
    }
}