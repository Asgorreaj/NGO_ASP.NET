using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using zerohunger.EF;
using System.ComponentModel.DataAnnotations.Schema;
using ZeroHunger.Controllers;

namespace zerohunger.DTOs
{
    public class CollectedFoodItemDTO
    {
        public int id { get; set; }
        public int collect_request_id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public string condition { get; set; }
        public string distribution_status { get; set; }
        public Nullable<System.DateTime> distribution_completion_time { get; set; }
        public int MaximumPreserveTimeInHours { get; set; }
    }
}