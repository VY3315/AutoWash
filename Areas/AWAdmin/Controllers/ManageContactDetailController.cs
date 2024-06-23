using AutoWash.Models.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoWash.Areas.AWAdmin.Controllers
{
    public class ManageContactDetailController : Controller
    {
        // find out how to spilit string value and print on view

        //  Opening Hours (ex:Mon-Fri,8.00-9.00), Contact number, Email id, Address(ex:123 Street, New York, USA) 

        private AutoWashDBEntities awa = new AutoWashDBEntities();

        // GET: AWAdmin/ManageContactDetail
        public ActionResult AddContactDetails(int id = 0 )
        {
            ViewBag.ContactList = awa.tbl_ManageContactDetails.ToList();

            if (id > 0)
            {
                return View(awa.tbl_ManageContactDetails.Find(id));
            }
            else
            {
                return View(new tbl_ManageContactDetails());
            }

           
        }

        [HttpPost]
        public ActionResult AddContactDetails(FormCollection fc)
        {

            ViewBag.ContactList = awa.tbl_ManageContactDetails.ToList();

            var id = Convert.ToInt32(fc["mid"]);
            if (id > 0)
            {
                //tbl_basiccleaning baseClean = awa.tbl_basiccleaning.Find(id);

                tbl_ManageContactDetails contact = awa.tbl_ManageContactDetails.Find(id);

                contact.mopeninghours = fc["mopeninghours"];
                contact.mnumber = fc["mnumber"];
                contact.memail = fc["memail"];
                contact.maddress = fc["maddress"];

                awa.SaveChanges();
                return RedirectToAction("AddContactDetails", "ManageContactDetail");
            }
            else
            {

                tbl_ManageContactDetails contact = new tbl_ManageContactDetails();

                contact.mopeninghours = fc["mopeninghours"];
                contact.mnumber = fc["mnumber"];
                contact.memail = fc["memail"];
                contact.maddress = fc["maddress"];

                awa.tbl_ManageContactDetails.Add(contact);
                awa.SaveChanges();
                return RedirectToAction("AddContactDetails");
            }

        }

        public ActionResult DeleteContactDetails(int id)
        {
            ViewBag.ContactList = awa.tbl_ManageContactDetails.ToList();

            tbl_ManageContactDetails deleteContactDetail = awa.tbl_ManageContactDetails.Find(id);
            awa.tbl_ManageContactDetails.Remove(deleteContactDetail);
            awa.SaveChanges();

            return RedirectToAction("AddContactDetails");
        }

    }
}