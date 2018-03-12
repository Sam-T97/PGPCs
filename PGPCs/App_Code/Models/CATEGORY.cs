using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PGPCs.Models
{
    public class CATEGORY
    {
        [ScaffoldColumn(false), Key]
        public int CATEGORY_ID { get; set; }

        [Required, StringLength(30), Display(Name ="Category")]
        public string CATEGORY_NAME { get; set; }

        public virtual ICollection<PRODUCT> Products { get; set; }
    }
}