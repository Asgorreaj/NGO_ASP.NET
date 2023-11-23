using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using zerohunger.EF;

namespace zerohunger.DTOs
{
    public class CollectRequestDTO
    {

        public int id { get; set; }
        public int restaurant_id { get; set; }
        public Nullable<int> employee_id { get; set; }
        public System.DateTime time { get; set; }
        public System.DateTime maximum_preserve_time { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> completion_time { get; set; }



    }
}