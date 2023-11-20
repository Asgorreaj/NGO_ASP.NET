using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.Controllers;
using ZeroHunger.DTOs;
using zerohunger.EF;
using AutoMapper;

namespace ZeroHunger.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration/RestaurantRegistration
        public ActionResult RestaurantRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RestaurantRegistration(RestaurantDTO restaurantDTO)
        {
            if (ModelState.IsValid)
            {
                var mapperConfiguration = new MapperConfiguration(configure =>
                {
                    configure.CreateMap<RestaurantDTO, restaurant>();
                });
                var mapper = new Mapper(mapperConfiguration);
                var data = mapper.Map<restaurant>(restaurantDTO);
                var database = new ZeroHungerEntities();
                database.restaurants.Add(data);
                database.SaveChanges();
                Session["restaurantID"] = data.id;
                return RedirectToAction("Index", "RestaurantDashboard");
            }
            return View(restaurantDTO);
        }

        public ActionResult EmployeeRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EmployeeRegistration(EmployeeDTO employeeDTO)
        {
            if (ModelState.IsValid)
            {
                var mapperConfiguration = new MapperConfiguration(configure =>
                {
                    configure.CreateMap<EmployeeDTO, employee>();
                });
                var mapper = new Mapper(mapperConfiguration);
                var data = mapper.Map<employee>(employeeDTO);
                var database = new ZeroHungerEntities();
                database.employees.Add(data);
                database.SaveChanges();
                Session["employeeID"] = data.id;
                return RedirectToAction("Index", "EmployeeDashboard");
            }
            return View(employeeDTO);
        }
    }
}