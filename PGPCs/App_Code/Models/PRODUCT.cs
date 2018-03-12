using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PGPCs.Models
{
    public class PRODUCT
    {
        [ScaffoldColumn(false), Key]
        public int PRODUCT_ID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string PRODUCT_NAME { get; set; }

        [Required, StringLength(1000), Display(Name = "Description"), DataType(DataType.MultilineText)]
        public string PRODUCT_DESCRIPTION { get; set; }

        public string IMAGE_NAME { get; set; } = "Default.png";

        [Display(Name = "Price")]
        public double PRICE { get; set; }

        [Required]
        public int CATEGORY_ID { get; set; }

        public virtual CATEGORY CATEGORY { get; set; }
    }
}