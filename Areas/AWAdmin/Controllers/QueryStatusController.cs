using AutoWash.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoWash.Areas.AWAdmin.Controllers
{
    public class QueryStatusController : Controller
    {
        // GET: AWAdmin/QueryStatus

        private AutoWashDBEntities awa = new AutoWashDBEntities();

        public ActionResult DisplayCustomerQuery(int id=0)
        {
            ViewBag.query = awa.tbl_Contact1.ToList();

            if (id > 0)
            {
                
                return View(awa.tbl_Contact1.Find(id));
            }
            else
            {

                return View(new tbl_Contact1());
            }
            
        }

        public ActionResult DeleteDisplayCustomerQuery(int id)
        {

            ViewBag.query = awa.tbl_Contact1.ToList();
            tbl_Contact1 deleteQuery = awa.tbl_Contact1.Find(id);
            awa.tbl_Contact1.Remove(deleteQuery);
            awa.SaveChanges();

            return RedirectToAction("DisplayCustomerQuery");
        }

        public ActionResult ViewCustomerRequest(int id = 0)
        {
            ViewBag.request = awa.tbl_UserRequest.ToList();

            if (id > 0)
            {
                return View(awa.tbl_UserRequest.Find(id));
            }
            else
            {

                return View(new tbl_UserRequest());
            }

        }

        public ActionResult DeleteCustomerRequest(int id)
        {

            ViewBag.request = awa.tbl_UserRequest.ToList();
            tbl_UserRequest deleteRequest = awa.tbl_UserRequest.Find(id);
            awa.tbl_UserRequest.Remove(deleteRequest);
            awa.SaveChanges();

            return RedirectToAction("ViewCustomerRequest");
        }
    }
}