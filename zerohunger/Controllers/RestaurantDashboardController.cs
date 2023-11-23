using AutoMapper;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zerohunger.EF;
using ZeroHunger.Controllers;
using zerohunger.DTOs;
using System.Data.SqlTypes;
using System.Diagnostics;



namespace ZeroHunger.Controllers
{
    public class RestaurantDashboardController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateCollectRequest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCollectRequest(CollectedFoodItemDTO collectedFoodItemDTO)
        {
            var database = new ZeroEntities();

            var collectRequestDTO = new CollectRequestDTO()
            {
                restaurant_id = (int)Session["restaurantID"],
                time = DateTime.Now,
                maximum_preserve_time = DateTime.Now,
                status = "Unassigned"
            };

            var collectRequestMapperConfiguration = new MapperConfiguration(configure =>
            {
                configure.CreateMap<CollectRequestDTO, collect_requests>();
            });
            var collectRequestMapper = new Mapper(collectRequestMapperConfiguration);
            var collectRequestData = collectRequestMapper.Map<collect_requests>(collectRequestDTO);
            database.collect_requests.Add(collectRequestData);
            database.SaveChanges();
            collectedFoodItemDTO.collect_request_id = collectRequestData.id;
            collectedFoodItemDTO.condition = "Good";
            collectedFoodItemDTO.distribution_status = "Undistributed";
            var collectedFoodItemsMapperConfiguration = new MapperConfiguration(configure =>
            {
                configure.CreateMap<CollectedFoodItemDTO, collected_food_items>();
            });
            var collectedFoodItemsMapper = new Mapper(collectedFoodItemsMapperConfiguration);
            var collectedFoodItemsData = collectedFoodItemsMapper.Map<collected_food_items>(collectedFoodItemDTO);
            database.collected_food_items.Add(collectedFoodItemsData);
            database.SaveChanges();
            return RedirectToAction("Index", "RestaurantDashboard");
        }

        public ActionResult CollectRequestList()
        {
            var database = new ZeroEntities();
            int restaurantID = (int)Session["restaurantID"];
            var data = database.collect_requests.Where(c => c.restaurant_id == restaurantID);
            return View(data);
        }

        public ActionResult CollectedFoodItemsList()
        {
            var database = new ZeroEntities();
            int restaurantID = (int)Session["restaurantID"];
            var data = database.collected_food_items.Where(c => c.collect_requests.id == restaurantID);
            return View(data);
        }

        public ActionResult DeleteCollectRequests(int id)
        {
            var database = new ZeroEntities();
            var collectRequestsData = database.collect_requests.Find(id);
            var collectedFoodItemsData = database.collected_food_items.FirstOrDefault(c => c.collect_request_id == collectRequestsData.id);
            database.collect_requests.Remove(collectRequestsData);
            database.collected_food_items.Remove(collectedFoodItemsData);
            database.SaveChanges();
            return RedirectToAction("CollectRequestList", "RestaurantDashboard");
        }

        public ActionResult DeleteCollectedFoodItemsList(int id)
        {
            var database = new ZeroEntities();
            var collectedFoodItemsData = database.collected_food_items.Find(id);
            var collectRequestsData = database.collect_requests.Find(collectedFoodItemsData.collect_request_id);
            database.collect_requests.Remove(collectRequestsData);
            database.collected_food_items.Remove(collectedFoodItemsData);
            database.SaveChanges();
            return RedirectToAction("CollectedFoodItemsList", "RestaurantDashboard");
        }
    }
}