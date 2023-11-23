using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using zerohunger.EF;

namespace zerohunger.DTOs
{
    public class EmployeeDTO
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email_address { get; set; }
        public string contact_number { get; set; }
        public string password { get; set; }
    }
}