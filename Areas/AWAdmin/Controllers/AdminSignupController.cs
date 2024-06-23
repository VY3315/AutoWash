using AutoWash.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoWash.Areas.AWAdmin.Controllers
{
    public class AdminSignupController : Controller
    {
        // GET: AWAdmin/AdminSignup

        private AutoWashDBEntities AW = new AutoWashDBEntities();
        public ActionResult AdminSignup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminSignup(FormCollection fc)
        {
            tbl_Admin_Detail ad = new tbl_Admin_Detail();

            ad.aname = fc["aname"];
            ad.aemail = fc["aemail"];
            ad.apss = fc["apss"];

            AW.tbl_Admin_Detail.Add(ad);
            AW.SaveChanges();
            return RedirectToAction("AdminLogin", "AdminLogin");
        }
    }
}