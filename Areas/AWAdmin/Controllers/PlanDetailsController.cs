using AutoWash.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoWash.Areas.AWAdmin.Controllers
{
    public class PlanDetailsController : Controller
    {
        // GET: AWAdmin/PlanDetails

        // Basic Cleaning , Premium Cleaning , Complex Cleaning : Price ,description: 2 chechkbox one for given and another for not given

        private AutoWashDBEntities awa = new AutoWashDBEntities();

        public ActionResult BasicCleaning(int id = 0)
        {
            ViewBag.ServiceList = awa.tbl_services.ToList();
            ViewBag.basicCleantable = awa.tbl_basiccleaning.ToList();


            string str = "yogesh,yagnesh,ruchi.prithvi";
            var item = str.Split(',');

            if (id > 0)
            {
                ViewBag.bservices = new List<string> { "Seats Washing", "Vacuum Cleaning", "Exterior Cleaning", "Interior Wet Cleaning", "Window Wiping" };
                return View(awa.tbl_basiccleaning.Find(id));
            }
            else
            {
                ViewBag.bservices = new List<string> { "Seats Washing", "Vacuum Cleaning", "Exterior Cleaning", "Interior Wet Cleaning", "Window Wiping" };
                return View(new tbl_basiccleaning());
            }
        }

        [HttpPost]
        public ActionResult BasicCleaning(FormCollection fc)
        {
            ViewBag.basicCleantable = awa.tbl_basiccleaning.ToList();
            ViewBag.ServiceList = awa.tbl_services.ToList();

            var id = Convert.ToInt32(fc["bid"]);

            if (id > 0)
            {
                tbl_basiccleaning baseClean = awa.tbl_basiccleaning.Find(id);

                baseClean.bplan = fc["bplan"];
                baseClean.bprice = fc["bprice"];
                baseClean.bservices = fc["bsr"];

                awa.SaveChanges();
                ViewBag.ServiceList = awa.tbl_services.ToList();
                ViewBag.basicCleantable = awa.tbl_basiccleaning.ToList();

                return RedirectToAction("BasicCleaning", "/PlanDetails");

            }
            else
            {
                tbl_basiccleaning baseClean = new tbl_basiccleaning();
                tbl_services services = new tbl_services();

                baseClean.bplan = fc["bplan"];
                baseClean.bprice = fc["bprice"];
                baseClean.bservices = fc["bsr"];
                awa.tbl_basiccleaning.Add(baseClean);
                awa.SaveChanges();
                return RedirectToAction("BasicCleaning");
            }

        }

        public ActionResult PremiumCleaning(int id = 0)
        {
            ViewBag.ServiceList = awa.tbl_services.ToList();
            ViewBag.primeCleantable = awa.tbl_premiumcleaning.ToList();


            string str = "yogesh,yagnesh,ruchi.prithvi";
            var item = str.Split(',');

            if (id > 0)
            {
                ViewBag.pservices = new List<string> { "Seats Washing", "Vacuum Cleaning", "Exterior Cleaning", "Interior Wet Cleaning", "Window Wiping" };
                return View(awa.tbl_premiumcleaning.Find(id));
            }
            else
            {
                ViewBag.pservices = new List<string> { "Seats Washing", "Vacuum Cleaning", "Exterior Cleaning", "Interior Wet Cleaning", "Window Wiping" };
                return View(new tbl_premiumcleaning());
            }
        }

        [HttpPost]
        public ActionResult PremiumCleaning(FormCollection fc)
        {
            ViewBag.basicCleantable = awa.tbl_premiumcleaning.ToList();
            ViewBag.ServiceList = awa.tbl_services.ToList();

            var id = Convert.ToInt32(fc["pid"]);

            if (id > 0)
            {
                tbl_premiumcleaning primeClean = awa.tbl_premiumcleaning.Find(id);
                primeClean.pplan = fc["pplan"];
                primeClean.pprice = fc["pprice"];
                primeClean.pservices = fc["psr"];

                awa.SaveChanges();
                ViewBag.ServiceList = awa.tbl_services.ToList();
                ViewBag.primeCleantable = awa.tbl_basiccleaning.ToList();

                return RedirectToAction("PremiumCleaning", "/PlanDetails");

            }
            else
            {
                tbl_premiumcleaning primeClean = new tbl_premiumcleaning();
                tbl_services services = new tbl_services();

                primeClean.pplan = fc["pplan"];
                primeClean.pprice = fc["pprice"];
                primeClean.pservices = fc["psr"];

                awa.tbl_premiumcleaning.Add(primeClean);
                awa.SaveChanges();
                return RedirectToAction("PremiumCleaning");
            }

        }


        public ActionResult ComplexCleaning(int id = 0)
        {
            ViewBag.ServiceList = awa.tbl_services.ToList();
            ViewBag.complexCleantable = awa.tbl_complexcleaning.ToList();


            string str = "yogesh,yagnesh,ruchi.prithvi";
            var item = str.Split(',');

            if (id > 0)
            {
                ViewBag.cservices = new List<string> { "Seats Washing", "Vacuum Cleaning", "Exterior Cleaning", "Interior Wet Cleaning", "Window Wiping" };
                return View(awa.tbl_complexcleaning.Find(id));
            }
            else
            {
                ViewBag.cservices = new List<string> { "Seats Washing", "Vacuum Cleaning", "Exterior Cleaning", "Interior Wet Cleaning", "Window Wiping" };
                return View(new tbl_complexcleaning());
            }
        }

        [HttpPost]
        public ActionResult ComplexCleaning(FormCollection fc)
        {
            ViewBag.complexCleantable = awa.tbl_complexcleaning.ToList();
            ViewBag.ServiceList = awa.tbl_services.ToList();

            var id = Convert.ToInt32(fc["cid"]);

            if (id > 0)
            {
                tbl_complexcleaning complexClean = awa.tbl_complexcleaning.Find(id);

                complexClean.cplan = fc["cplan"];
                complexClean.cprice = fc["cprice"];
                complexClean.cservices = fc["csr"];

                awa.SaveChanges();
                ViewBag.ServiceList = awa.tbl_services.ToList();
                ViewBag.basicCleantable = awa.tbl_complexcleaning.ToList();

                return RedirectToAction("ComplexCleaning", "/PlanDetails");

            }
            else
            {
                tbl_complexcleaning complexClean = new tbl_complexcleaning();
                tbl_services services = new tbl_services();

                complexClean.cplan = fc["cplan"];
                complexClean.cprice = fc["cprice"];
                complexClean.cservices = fc["csr"];

                awa.tbl_complexcleaning.Add(complexClean);
                awa.SaveChanges();
                return RedirectToAction("ComplexCleaning");
            }

        }



        public ActionResult Services()
        {
            ViewBag.ServiceList = awa.tbl_services.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Services(FormCollection fc)
        {
            ViewBag.ServiceList = awa.tbl_services.ToList();
            tbl_services services = new tbl_services();
            services.sname = fc["sname"];
            awa.tbl_services.Add(services);
            awa.SaveChanges();
            return RedirectToAction("BasicCleaning");
        }

        public ActionResult RemoveServices(int? id)
        {
            ViewBag.ServiceList = awa.tbl_services.ToList();
            tbl_services removeservices = awa.tbl_services.Find(id);
            awa.tbl_services.Remove(removeservices);
            awa.SaveChanges();

            return RedirectToAction("BasicCleaning");
        }

        public ActionResult DeleteBasicCleaning(int id)
        {
            ViewBag.basicCleantable = awa.tbl_basiccleaning.ToList();
            tbl_basiccleaning deleteBasic = awa.tbl_basiccleaning.Find(id);
            awa.tbl_basiccleaning.Remove(deleteBasic);
            awa.SaveChanges();

            return RedirectToAction("BasicCleaning");
        }

        public ActionResult DeletePremiumCleaning(int id)
        {
            ViewBag.ct = awa.tbl_premiumcleaning.ToList();

            tbl_premiumcleaning deletePremium = awa.tbl_premiumcleaning.Find(id);
            awa.tbl_premiumcleaning.Remove(deletePremium);
            awa.SaveChanges();

            return RedirectToAction("PremiumCleaning");
        }

        public ActionResult DeleteComplexCleaning(int id)
        {
            ViewBag.ct1 = awa.tbl_complexcleaning.ToList();
            tbl_complexcleaning deleteComplex = awa.tbl_complexcleaning.Find(id);
            awa.tbl_complexcleaning.Remove(deleteComplex);
            awa.SaveChanges();

            return RedirectToAction("ComplexCleaning");
        }

    }
}