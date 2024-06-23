using AutoWash.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace AutoWash.Areas.AWAdmin.Controllers
{
    public class CustomerPlanRequestController : Controller
    {
        private AutoWashDBEntities awa = new AutoWashDBEntities();

        // GET: AWAdmin/CustomerPlanRequest
        public ActionResult ViewAllCustomerPlanRequest()
        {
            ViewBag.CustomerRequest = awa.tbl_Customer_Plan_Request.ToList();

            return View();
        }
        [HttpPost]
        public ActionResult ViewAllCustomerPlanRequest(FormCollection fc)
        {
            ViewBag.CustomerRequest = awa.tbl_Customer_Plan_Request.ToList();
            return View();
        }

        public ActionResult DeleteCustomerPlanRequest(int id)
        {
            ViewBag.CustomerRequest = awa.tbl_Customer_Plan_Request.ToList();

            tbl_Customer_Plan_Request deleteRequest = awa.tbl_Customer_Plan_Request.Find(id);
            awa.tbl_Customer_Plan_Request.Remove(deleteRequest);
            awa.SaveChanges();

            return RedirectToAction("ViewAllCustomerPlanRequest");
        }

        public ActionResult GetBasicCleaningRequest(int id = 0)
        {
            ViewBag.BasicRequestDetails = awa.tbl_Customer_Plan_Request.ToList();
            ViewBag.services = new List<string> { "Seats Washing", "Vacuum Cleaning", "Exterior Cleaning", "Interior Wet Cleaning", "Window Wiping" };


            var basicCleantables = awa.tbl_basiccleaning.ToList();
            var lastBasicCleantables = awa.tbl_basiccleaning.OrderByDescending(t => t.bid).FirstOrDefault();

            var model = new PlanDetails
            {
                BasicCleantables = basicCleantables,
                LastBasicCleantables = lastBasicCleantables
            };

            return View(model);


        }
        [HttpPost]
        public ActionResult GetBasicCleaningRequest(FormCollection fc)
        {
            ViewBag.BasicRequestDetails = awa.tbl_Customer_Plan_Request.ToList();
            ViewBag.services = new List<string> { "Seats Washing", "Vacuum Cleaning", "Exterior Cleaning", "Interior Wet Cleaning", "Window Wiping" };


            tbl_Customer_Plan_Request Basic_Request = new tbl_Customer_Plan_Request();
            Basic_Request.CPname = fc["CPname"];
            Basic_Request.CPplan = fc["CPplan"];
            Basic_Request.CPprice = fc["CPprice"];
            Basic_Request.CPservices = fc["CPsr"];
            awa.tbl_Customer_Plan_Request.Add(Basic_Request);
            awa.SaveChanges();
            return RedirectToAction("Price","Home", new { area = "AWUser" , SentMessageToUser = "Successfully Booked Your Basic Cleaninng Plan!" });

        }
        public ActionResult GetPremiumCleaningRequest(int id=0)
        {
            ViewBag.PrimeRequestDetails = awa.tbl_Customer_Plan_Request.ToList();
            ViewBag.services = new List<string> { "Seats Washing", "Vacuum Cleaning", "Exterior Cleaning", "Interior Wet Cleaning", "Window Wiping" };


            var primeCleantables = awa.tbl_premiumcleaning.ToList();
            var lastPrimeCleantables = awa.tbl_premiumcleaning.OrderByDescending(x => x.pid).FirstOrDefault();

            var model = new PlanDetails
            {

                PrimeCleantables = primeCleantables,
                LastPrimeCleantables = lastPrimeCleantables
            };

            return View(model);
            

        }
        [HttpPost]
        public ActionResult GetPremiumCleaningRequest(FormCollection fc)
        {
            ViewBag.PrimeRequestDetails = awa.tbl_Customer_Plan_Request.ToList();
            ViewBag.services = new List<string> { "Seats Washing", "Vacuum Cleaning", "Exterior Cleaning", "Interior Wet Cleaning", "Window Wiping" };


            tbl_Customer_Plan_Request Prime_Request = new tbl_Customer_Plan_Request();
            Prime_Request.CPname = fc["CPname"];
            Prime_Request.CPplan = fc["CPplan"];
            Prime_Request.CPprice = fc["CPprice"];
            Prime_Request.CPservices = fc["CPsr"];
            awa.tbl_Customer_Plan_Request.Add(Prime_Request);
            awa.SaveChanges();
            return RedirectToAction("Price", "Home", new { area = "AWUser", SentMessageToUser = "Successfully Booked Your Premium Cleaninng Plan!" });

        }

        public ActionResult GetComplexCleaningRequest()
        {
            ViewBag.ComplexRequestDetails = awa.tbl_Customer_Plan_Request.ToList();
            ViewBag.services = new List<string> { "Seats Washing", "Vacuum Cleaning", "Exterior Cleaning", "Interior Wet Cleaning", "Window Wiping" };

            var complexCleantables = awa.tbl_complexcleaning.ToList();
            var lastComplexCleantables = awa.tbl_complexcleaning.OrderByDescending(y => y.cid).FirstOrDefault();
            
            var model = new PlanDetails
            {
                ComplexCleantables = complexCleantables,
                LastComplexCleantables = lastComplexCleantables
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult GetComplexCleaningRequest(FormCollection fc)
        {
            ViewBag.ComplexRequestDetails = awa.tbl_Customer_Plan_Request.ToList();
            ViewBag.services = new List<string> { "Seats Washing", "Vacuum Cleaning", "Exterior Cleaning", "Interior Wet Cleaning", "Window Wiping" };


            tbl_Customer_Plan_Request Complex_Request = new tbl_Customer_Plan_Request();
            Complex_Request.CPname = fc["CPname"];
            Complex_Request.CPplan = fc["CPplan"];
            Complex_Request.CPprice = fc["CPprice"];
            Complex_Request.CPservices = fc["CPsr"];
            awa.tbl_Customer_Plan_Request.Add(Complex_Request);
            awa.SaveChanges();
            return RedirectToAction("Price","Home", new { area = "AWUser" , SentMessageToUser = "Successfully Booked Your Complex Cleaninng Plan!" });

        }
    }
}