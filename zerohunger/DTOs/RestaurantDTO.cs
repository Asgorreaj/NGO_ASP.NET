using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using zerohunger.EF;

namespace zerohunger.DTOs
{
    public class RestaurantDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        public string email_address { get; set; }
        [Required]
        [Display(Name = "Contact Number")]
        public string contact_number { get; set; }
        public string password { get; set; }
    }
}

