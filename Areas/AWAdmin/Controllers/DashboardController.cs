using AutoWash.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoWash.Areas.AWAdmin.Controllers
{
    public class DashboardController : Controller
    {
        // GET: AWAdmin/Dashboard

        // Dashboard , Rais Query , Request of Customer/Selected Plans , News Latter Request Information, Profile and Profile update 

        // Admin Login , Dashboard & Profile , Appoinments , Query Status , News Latter   

        // Done : Dashboard , Query Status , News Latter
        
        // Pending : Profile , Appoinments , Admin Login

        // Plan Details , Booking Details , Booking Page , Contact us
        private AutoWashDBEntities awa = new AutoWashDBEntities();
        public ActionResult Index()
        {
            ViewBag.services = new List<string> { "Seats Washing", "Vacuum Cleaning", "Exterior Cleaning", "Interior Wet Cleaning", "Window Wiping" };

            ViewBag.CustomerRequestList = awa.tbl_Customer_Plan_Request.ToList();
            ViewBag.BasicList = awa.tbl_basiccleaning.ToList();
            ViewBag.PremiumList = awa.tbl_premiumcleaning.ToList();  
            ViewBag.ComplexList = awa.tbl_complexcleaning.ToList();
            ViewBag.ContactList = awa.tbl_ManageContactDetails.ToList();
            ViewBag.AboutList = awa.tbl_AboutUsDetails.ToList();
            ViewBag.TeamList = awa.tbl_TeamMemberDetails.ToList();
            ViewBag.SliderList = awa.tbl_SliderDetails.ToList();
            ViewBag.WashingPointList = awa.tbl_WashingPointDetails.ToList();
            ViewBag.RequestList = awa.tbl_UserRequest.ToList();
            ViewBag.QueryList = awa.tbl_Contact1.ToList();


            return View();
        }
    }
}