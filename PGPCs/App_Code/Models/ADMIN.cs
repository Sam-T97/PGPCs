using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PGPCs.Models;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Summary description for ADMIN
/// </summary>
namespace PGPCs.Models
{ 
    public class ADMIN
    {
        [ScaffoldColumn(false), Key]
        public int ADMIN_ID { get; set; }

        [Required]
        public string EMAIL_ADDRESS { get; set; }

        [Required]
        public string PASSWORD { get; set; }
        
    }
}