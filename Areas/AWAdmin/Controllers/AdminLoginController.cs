using AutoWash.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoWash.Areas.AWAdmin.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: AWAdmin/AdminLogin


        //  Admin To User :

        //                  1.  Offered Services
        //                  2.  Cost : Plan Price
        //                  3.  Booking

        private AutoWashDBEntities Admin = new AutoWashDBEntities();
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(FormCollection fc)
        {
            string aname = fc["aname"];
            string apss = fc["apss"];

            if (!string.IsNullOrWhiteSpace(aname)
                && !string.IsNullOrWhiteSpace(apss))
            {
                tbl_Admin_Detail admin = Admin.tbl_Admin_Detail.Where(x => x.aname == aname && x.apss == apss).FirstOrDefault();
                if (admin != null)
                {
                    Session["aid"] = admin.aid;
                    Session["aname"] = admin.aname;
                    Session["apss"] = admin.apss;

                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    ViewBag.error = "please enter correct email and password";
                }
            }
            else
            {
                ViewBag.error = "please enter proper email and password";
            }
            return View();
        }

        public ActionResult AdminLogout()
        {
            Session.Clear();
            return RedirectToAction("AdminLogin");
        }
    }
}
