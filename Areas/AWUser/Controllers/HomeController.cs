using AutoWash.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoWash.Areas.AWUser.Controllers
{
    public class HomeController : Controller
    {
        // GET: AWUser/Home

        // Car Washing Request : Name , Email , Description  // Page : Index , WashingPoints
        // News Latter : Full Name , Email  // Page : All
        // Contact : Name , Email , Subject , Message   // Page : Contact

        private AutoWashDBEntities UAW = new AutoWashDBEntities();

        public ActionResult Index(string SentMessageToUser)
        {
            ViewBag.ContactList = UAW.tbl_ManageContactDetails.ToList();
            ViewBag.LastContactUs = UAW.tbl_ManageContactDetails.OrderByDescending(e => e.mid).FirstOrDefault();


            ViewBag.services = new List<string> { "Seats Washing", "Vacuum Cleaning", "Exterior Cleaning", "Interior Wet Cleaning", "Window Wiping" };

            ViewBag.Error = "!!! Offer Open Soon............";
            ViewBag.SentMessage = SentMessageToUser;
            ViewBag.SentMessageForRequest = TempData["SentMessage"];

            ViewBag.sliderList = UAW.tbl_SliderDetails.ToList();

            var complexCleantables = UAW.tbl_complexcleaning.ToList();
            var primeCleantables = UAW.tbl_premiumcleaning.ToList();
            var basicCleantables = UAW.tbl_basiccleaning.ToList();
            var aboutUs = UAW.tbl_AboutUsDetails.ToList();
            var teamMember = UAW.tbl_TeamMemberDetails.ToList();
            var slider = UAW.tbl_SliderDetails.ToList();
            var washingPoint = UAW.tbl_WashingPointDetails.ToList();
            var contactUs = UAW.tbl_ManageContactDetails.ToList();

            var lastComplexCleantables = UAW.tbl_complexcleaning.OrderByDescending(y => y.cid).FirstOrDefault();
            var lastPrimeCleantables = UAW.tbl_premiumcleaning.OrderByDescending(x => x.pid).FirstOrDefault();
            var lastBasicCleantables = UAW.tbl_basiccleaning.OrderByDescending(t => t.bid).FirstOrDefault();
            var lastAboutUs = UAW.tbl_AboutUsDetails.OrderByDescending(a => a.AUid).FirstOrDefault();
            var lastTeamMember = UAW.tbl_TeamMemberDetails.OrderByDescending(b => b.TMid).FirstOrDefault();
            var lastSlider = UAW.tbl_SliderDetails.OrderByDescending(c => c.SLid).FirstOrDefault();
            var lastWashingPoint = UAW.tbl_WashingPointDetails.OrderByDescending(d => d.WPid).FirstOrDefault();
            var lastContactUs = UAW.tbl_ManageContactDetails.OrderByDescending(e => e.mid).FirstOrDefault();

            var model = new AllDetails
            {
                BasicCleantables = basicCleantables,
                PrimeCleantables = primeCleantables,
                ComplexCleantables = complexCleantables,
                AboutUs = aboutUs,
                TeamMember = teamMember,
                Slider = slider,
                WashingPoint = washingPoint,
                ContactUs = contactUs,

                LastBasicCleantables = lastBasicCleantables,
                LastPrimeCleantables = lastPrimeCleantables,
                LastComplexCleantables = lastComplexCleantables,
                LastAboutUs = lastAboutUs,
                LastTeamMember = lastTeamMember,
                LastSlider = lastSlider,
                LastWashingPoint = lastWashingPoint,
                LastContactUs = lastContactUs
            };
            if (model != null)
            {
                return View(model);
            }
            else
            {
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public ActionResult Index(FormCollection fc)
        {
            ViewBag.ContactList = UAW.tbl_ManageContactDetails.ToList();
            ViewBag.LastContactUs = UAW.tbl_ManageContactDetails.OrderByDescending(e => e.mid).FirstOrDefault();

            ViewBag.sliderList = UAW.tbl_SliderDetails.ToList();

            tbl_UserRequest ur = new tbl_UserRequest();
            ur.rname = fc["rname"];
            ur.remail = fc["remail"];
            ur.rdes = fc["rdes"];

            UAW.tbl_UserRequest.Add(ur);
            UAW.SaveChanges();
            TempData["SentMessage"] = "Request Register successfully!";
            return RedirectToAction("Index");

        }
        public ActionResult About()
        {
            var aboutUs = UAW.tbl_AboutUsDetails.ToList();
            var lastAboutUs = UAW.tbl_AboutUsDetails.OrderByDescending(a => a.AUid).FirstOrDefault();

            var teamMember = UAW.tbl_TeamMemberDetails.ToList();
            var lastTeamMember = UAW.tbl_TeamMemberDetails.OrderByDescending(b => b.TMid).FirstOrDefault();

            var contactUs = UAW.tbl_ManageContactDetails.ToList();
            var lastContactUs = UAW.tbl_ManageContactDetails.OrderByDescending(e => e.mid).FirstOrDefault();

            var model = new AllDetails
            {
                AboutUs = aboutUs,
                LastAboutUs = lastAboutUs,

                TeamMember = teamMember,
                LastTeamMember = lastTeamMember,

                ContactUs = contactUs,
                LastContactUs = lastContactUs

            };
            if (model != null)
            {
                return View(model);
            }
            else
            {
                return RedirectToAction("About");
            }
        }


        public ActionResult Price(string SentMessageToUser)
        {
            ViewBag.SentMessage = SentMessageToUser;

            var complexCleantables = UAW.tbl_complexcleaning.ToList();
            var primeCleantables = UAW.tbl_premiumcleaning.ToList();
            var basicCleantables = UAW.tbl_basiccleaning.ToList();

            var lastComplexCleantables = UAW.tbl_complexcleaning.OrderByDescending(y => y.cid).FirstOrDefault();
            var lastPrimeCleantables = UAW.tbl_premiumcleaning.OrderByDescending(x => x.pid).FirstOrDefault();
            var lastBasicCleantables = UAW.tbl_basiccleaning.OrderByDescending(t => t.bid).FirstOrDefault();

            var contactUs = UAW.tbl_ManageContactDetails.ToList();
            var lastContactUs = UAW.tbl_ManageContactDetails.OrderByDescending(e => e.mid).FirstOrDefault();

            var model = new AllDetails
            {
                BasicCleantables = basicCleantables,
                PrimeCleantables = primeCleantables,
                ComplexCleantables = complexCleantables,

                LastBasicCleantables = lastBasicCleantables,
                LastPrimeCleantables = lastPrimeCleantables,
                LastComplexCleantables = lastComplexCleantables,

                ContactUs = contactUs,
                LastContactUs = lastContactUs
            };
            ViewBag.Error = "!!! Offer Open Soon............";
            ViewBag.services = new List<string> { "Seats Washing", "Vacuum Cleaning", "Exterior Cleaning", "Interior Wet Cleaning", "Window Wiping" };


            return View(model);
        }

        [HttpPost]
        public ActionResult Price(FormCollection fc)
        {
            ViewBag.complexCleantables = UAW.tbl_complexcleaning.ToList();
            ViewBag.primeCleantables = UAW.tbl_premiumcleaning.ToList();
            ViewBag.basicCleantables = UAW.tbl_basiccleaning.ToList();

            tbl_basiccleaning BasicPlan = new tbl_basiccleaning();
            ViewBag.services = new List<string> { "Seats Washing", "Vacuum Cleaning", "Exterior Cleaning", "Interior Wet Cleaning", "Window Wiping" };
            UAW.SaveChanges();
            return View();
        }

        public ActionResult WashingPoints()
        {

            ViewBag.SentMessageForRequest = TempData["SentMessage"];

            var contactUs = UAW.tbl_ManageContactDetails.ToList();
            var lastContactUs = UAW.tbl_ManageContactDetails.OrderByDescending(e => e.mid).FirstOrDefault();

            var washingPoint = UAW.tbl_WashingPointDetails.ToList();
            var lastWashingPoint = UAW.tbl_WashingPointDetails.OrderByDescending(d => d.WPid).FirstOrDefault();

            var model = new AllDetails
            {

                WashingPoint = washingPoint,
                LastWashingPoint = lastWashingPoint,

                ContactUs = contactUs,
                LastContactUs = lastContactUs

            };
            return View(model);
        }

        [HttpPost]
        public ActionResult WashingPoints(FormCollection fc)
        {

            tbl_UserRequest ur = new tbl_UserRequest();
            ur.rname = fc["rname"];
            ur.remail = fc["remail"];
            ur.rdes = fc["rdes"];

            UAW.tbl_UserRequest.Add(ur);
            UAW.SaveChanges();
            TempData["SentMessage"] = "Request Register successfully!";
            return RedirectToAction("WashingPoints");
        }

        public ActionResult TeamMember()
        {

            var contactUs = UAW.tbl_ManageContactDetails.ToList();
            var lastContactUs = UAW.tbl_ManageContactDetails.OrderByDescending(e => e.mid).FirstOrDefault();

            var teamMember = UAW.tbl_TeamMemberDetails.ToList();
            var lastTeamMember = UAW.tbl_TeamMemberDetails.OrderByDescending(b => b.TMid).FirstOrDefault();

            var model = new AllDetails
            {

                TeamMember = teamMember,
                LastTeamMember = lastTeamMember,

                ContactUs = contactUs,
                LastContactUs = lastContactUs

            };
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.SentMessageForRequest = TempData["SentMessage"];

            var contactUs = UAW.tbl_ManageContactDetails.ToList();
            var lastContactUs = UAW.tbl_ManageContactDetails.OrderByDescending(e => e.mid).FirstOrDefault();

            var model = new AllDetails
            {
                ContactUs = contactUs,
                LastContactUs = lastContactUs
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Contact(FormCollection fc)
        {
            tbl_Contact1 ct = new tbl_Contact1();
            ct.cname1 = fc["cname1"];
            ct.cemail1 = fc["cemail1"];
            ct.csubject1 = fc["csubject1"];
            ct.cmessage1 = fc["cmessage1"];

            UAW.tbl_Contact1.Add(ct);
            UAW.SaveChanges();
            TempData["SentMessage"] = "Register successfully!";
            return RedirectToAction("Contact");
        }


    }
}