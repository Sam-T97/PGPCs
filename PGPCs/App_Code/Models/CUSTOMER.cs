using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PGPCs.Models
{
    public class CUSTOMER
    {
        [ScaffoldColumn(false), Key]
        public int CUSTOMER_ID { get; set; }

        [Required, StringLength(30), Display(Name = "First Name")]
        public string CUSTOMER_FIRST_NAME { get; set; }

        [Required, StringLength(30), Display(Name = "Last Name")]
        public string CUSTOMER_LAST_NAME { get; set; }

        [Required, Display(Name ="House Number")]
        public int HOUSE_NUMBER { get; set; }

        [Required, StringLength(30), Display(Name ="Address Line 1")]
        public string ADDRESS_LINE_1 { get; set; }

        [StringLength(30), Display( Name ="Address Line 2")]
        public string ADDRESS_LINE_2 { get; set; }

        [Required, StringLength(30), Display(Name ="City")]
        public string CITY { get; set; }

        [Required, StringLength(30), Display(Name = "County")]
        public string COUNTY { get; set; }

        [Required, StringLength(7), Display(Name ="Postcode")]
        public string POSTCODE { get; set; }

        [Required]
        public string EMAIL_ADDRESS { get; set; }

        [Required]
        public string PASSWORD { get; set; }

        [Required]
        public bool FROZEN { get; set; }

        [Required]
        public bool NEW_ACCT { get; set; } = true;

    }
}