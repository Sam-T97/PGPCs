using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PGPCs;
using PGPCs.Models;
using System.ComponentModel.DataAnnotations;

namespace PGPCs.Models
{
    public class ORDERS
    {
        [Key, ScaffoldColumn(false)]
        public int ORDER_ID { get; set; }

        public int CUSTOMER_ID { get; set; }

        public DateTime ORDER_PLACED { get; set; }

        public virtual CUSTOMER CUSTOMER { get; set; }
    }
}