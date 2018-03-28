using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PGPCs;
using PGPCs.Models;
using System.ComponentModel.DataAnnotations;

namespace PGPCs.Models
{
    public class ORDERITEMS
    {
        [Key, ScaffoldColumn(false)]
        public int ITEM_ID { get; set; }

        public int ORDER_ID { get; set; }

        public int PRODUCT_ID { get; set; }

        public int QUANTITY { get; set; }

        public virtual ORDERS ORDERS { get; set; }

        public virtual PRODUCT PRODUCT { get; set; }
    }
}