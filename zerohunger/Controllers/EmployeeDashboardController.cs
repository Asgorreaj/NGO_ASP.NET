using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zerohunger.EF;
using zerohunger.DTOs;

namespace ZeroHunger.Controllers
{
    public class EmployeeDashboardController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AssignedCollectRequests()
        {
            var database = new ZeroEntities();
            var employeeID = (int)Session["employeeID"];
            var data = database.collect_requests.Where(c => c.employee_id == employeeID);
            return View(data);
        }

        public ActionResult ConfirmRequest(int id)
        {
            var database = new ZeroEntities();
            var data = database.collect_requests.Find(id);
            data.status = "In Progress";
            database.SaveChanges();
            return RedirectToAction("AssignedCollectRequests");
        }

        public ActionResult CompleteRequest(int id)
        {
            var database = new ZeroEntities();
            var data = database.collect_requests.Find(id);
            data.status = "Completed";
            data.completion_time = DateTime.Now;
            database.SaveChanges();
            return RedirectToAction("AssignedCollectRequests");
        }
    }
}