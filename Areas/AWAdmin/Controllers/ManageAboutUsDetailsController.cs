//using AutoWash.Models.EF;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace AutoWash.Areas.AWAdmin.Controllers
//{
//    public class ManageAboutUsDetailsController : Controller
//    {
//        // For About Us Page: Subject , Description , Photo , TableName : [ tbl_AboutUsDetails ] , Fields: [ AUid, AUsubject, AUdescription, AUphoto ]

//        // For Team Member Page: Team Member Photo , Name , Profession , TableName : [ tbl_TeamMemberDetails ] , Fields: [ TMid, TMname, TMprofession , TMphoto ]

//        // For Home Page Slider: Images , Subject , Sub-Subject , Description , TableName : [ tbl_SliderDetails ] , Fields: [ SLid, SLsubject, SLsubsubject , SLdescription, SLphoto ]

//        // For Washing Point Page: Subject, Sub-Subject, Address, Number , TableName : [ tbl_WashingPointDetails ] , Fields: [ WPid, WPsubject , WPsubsubject , WPaddress , WPnumber ]

//        // GET: AWAdmin/ManageAboutUsDetails

//        private AutoWashDBEntities awa = new AutoWashDBEntities();

//        public ActionResult ViewAllDetails()
//        {

//            ViewBag.AboutList = awa.tbl_AboutUsDetails.ToList();
//            ViewBag.TeamList = awa.tbl_TeamMemberDetails.ToList();
//            ViewBag.SliderList = awa.tbl_SliderDetails.ToList();
//            ViewBag.WashingPointList = awa.tbl_WashingPointDetails.ToList();

//            return View();

//            //var aboutus = awa.tbl_AboutUsDetails.ToList();
//            //var teammember = awa.tbl_TeamMemberDetails.ToList();
//            //var slider = awa.tbl_SliderDetails.ToList();
//            //var washingpoint = awa.tbl_WashingPointDetails.ToList();

//            //var lastaboutus = awa.tbl_AboutUsDetails.OrderByDescending(y => y.AUid).FirstOrDefault();
//            //var lastteammember = awa.tbl_TeamMemberDetails.OrderByDescending(x => x.TMid).FirstOrDefault();
//            //var lastslider = awa.tbl_SliderDetails.OrderByDescending(t => t.SLid).FirstOrDefault();
//            //var lastwashingpoint = awa.tbl_WashingPointDetails.OrderByDescending(z => z.WPid).FirstOrDefault();

//            //var model = new Details
//            //{
//            //    AboutUs = aboutus,
//            //    TeamMember = teammember,
//            //    Slider = slider,
//            //    WashingPoint = washingpoint,


//            //    LastAboutUs = lastaboutus,
//            //    LastTeamMember = lastteammember,
//            //    LastSlider = lastslider,
//            //    LastWashingPoint = lastwashingpoint

//            //};
//            //return View(model);

//        }

//        public ActionResult AddEditAboutUsDetails(int id = 0)
//        {
//            ViewBag.AboutList = awa.tbl_AboutUsDetails.ToList();


//            if (id > 0)
//            {
//                return View(awa.tbl_AboutUsDetails.Find(id));
//            }
//            else
//            {
//                return View(new tbl_AboutUsDetails());
//            }
//        }

//        [HttpPost]
//        public ActionResult AddEditAboutUsDetails(FormCollection fc, HttpPostedFileBase AUphoto_ufile)
//        {
//            ViewBag.AboutList = awa.tbl_AboutUsDetails.ToList();


//            var id = Convert.ToInt32(fc["AUid"]);
//            if (id > 0)
//            {
//                tbl_AboutUsDetails aboutdetails = awa.tbl_AboutUsDetails.Find(id);

//                aboutdetails.AUsubject = fc["AUsubject"];
//                aboutdetails.AUdescription = fc["AUdescription"];

//                if (AUphoto_ufile != null)
//                {
//                    aboutdetails.AUphoto = "~/Areas/AWAdmin/Images/AboutImage/" + AUphoto_ufile.FileName;
//                    AUphoto_ufile.SaveAs(Server.MapPath(aboutdetails.AUphoto));
//                }
//                else
//                {
//                    aboutdetails.AUphoto = fc["AUimg"].ToString();
//                }

//                awa.SaveChanges();
//                return RedirectToAction("ViewAllDetails", "ManageAboutUsDetails");
//            }
//            else
//            {

//                tbl_AboutUsDetails aboutdetails = new tbl_AboutUsDetails();

//                aboutdetails.AUsubject = fc["AUsubject"];
//                aboutdetails.AUdescription = fc["AUdescription"];

//                aboutdetails.AUphoto = "~/Areas/AWAdmin/Images/AboutImage/" + AUphoto_ufile.FileName;
//                AUphoto_ufile.SaveAs(Server.MapPath(aboutdetails.AUphoto));

//                awa.tbl_AboutUsDetails.Add(aboutdetails);
//                awa.SaveChanges();
//                return RedirectToAction("ViewAllDetails");
//            }
//        }

//        public ActionResult AddEditTeamMembersDetails(int id = 0)
//        {
//            ViewBag.TeamList = awa.tbl_TeamMemberDetails.ToList();


//            if (id > 0)
//            {
//                return View(awa.tbl_TeamMemberDetails.Find(id));
//            }
//            else
//            {
//                return View(new tbl_TeamMemberDetails());
//            }
//        }

//        [HttpPost]
//        public ActionResult AddEditTeamMembersDetails(FormCollection fc, HttpPostedFileBase TMphoto_ufile)
//        {
//            ViewBag.TeamList = awa.tbl_TeamMemberDetails.ToList();

//            var id = Convert.ToInt32(fc["TMid"]);
//            if (id > 0)
//            {
//                tbl_TeamMemberDetails teamdetails = awa.tbl_TeamMemberDetails.Find(id);

//                teamdetails.TMname = fc["TMname"];
//                teamdetails.TMprofession = fc["TMprofession"];

//                if (TMphoto_ufile != null)
//                {
//                    teamdetails.TMphoto = "~/Areas/AWAdmin/Images/TeamImage/" + TMphoto_ufile.FileName;
//                    TMphoto_ufile.SaveAs(Server.MapPath(teamdetails.TMphoto));
//                }
//                else
//                {
//                    teamdetails.TMphoto = fc["TMimg"].ToString();
//                }

//                awa.SaveChanges();
//                return RedirectToAction("ViewAllDetails", "ManageAboutUsDetails");
//            }
//            else
//            {
//                tbl_TeamMemberDetails teamdetails = new tbl_TeamMemberDetails();

//                teamdetails.TMname = fc["TMname"];
//                teamdetails.TMprofession = fc["TMprofession"];

//                teamdetails.TMphoto = "~/Areas/AWAdmin/Images/TeamImage/" + TMphoto_ufile.FileName;
//                TMphoto_ufile.SaveAs(Server.MapPath(teamdetails.TMphoto));

//                awa.tbl_TeamMemberDetails.Add(teamdetails);
//                awa.SaveChanges();
//                return RedirectToAction("ViewAllDetails");
//            }
//        }

//        public ActionResult AddEditSliderDetails(int id = 0)
//        {
//            ViewBag.SliderList = awa.tbl_SliderDetails.ToList();


//            if (id > 0)
//            {
//                return View(awa.tbl_SliderDetails.Find(id));
//            }
//            else
//            {
//                return View(new tbl_WashingPointDetails());
//            }
//        }

//        [HttpPost]
//        public ActionResult AddEditSliderDetails(FormCollection fc, HttpPostedFileBase SLphoto_ufile)
//        {
//            ViewBag.SliderList = awa.tbl_SliderDetails.ToList();

//            var id = Convert.ToInt32(fc["SLid"]);
//            if (id > 0)
//            {
//                tbl_SliderDetails sliderdetails = awa.tbl_SliderDetails.Find(id);

//                sliderdetails.SLsubject = fc["SLsubject"];
//                sliderdetails.SLsubsubject = fc["SLsubsubject"];
//                sliderdetails.SLdescription = fc["SLdescription"];

//                if (SLphoto_ufile != null)
//                {
//                    sliderdetails.SLphoto = "~/Areas/AWAdmin/Images/SliderImage/" + SLphoto_ufile.FileName;
//                    SLphoto_ufile.SaveAs(Server.MapPath(sliderdetails.SLphoto));
//                }
//                else
//                {
//                    sliderdetails.SLphoto = fc["SLimg"].ToString();
//                }

//                awa.SaveChanges();
//                return RedirectToAction("ViewAllDetails", "ManageAboutUsDetails");
//            }
//            else
//            {
//                tbl_SliderDetails sliderdetails = new tbl_SliderDetails();

//                sliderdetails.SLsubject = fc["SLsubject"];
//                sliderdetails.SLsubsubject = fc["SLsubsubject"];
//                sliderdetails.SLsubsubject = fc["SLsubsubject"];

//                sliderdetails.SLphoto = "~/Areas/AWAdmin/Images/SliderImage/" + SLphoto_ufile.FileName;
//                SLphoto_ufile.SaveAs(Server.MapPath(sliderdetails.SLphoto));

//                awa.tbl_SliderDetails.Add(sliderdetails);
//                awa.SaveChanges();
//                return RedirectToAction("ViewAllDetails");
//            }
//        }

//        public ActionResult AddEditWashingPointDetails(int id = 0)
//        {
//            ViewBag.WashingPointList = awa.tbl_WashingPointDetails.ToList();


//            if (id > 0)
//            {
//                return View(awa.tbl_WashingPointDetails.Find(id));
//            }
//            else
//            {
//                return View(new tbl_WashingPointDetails());
//            }

//        }
//        [HttpPost]
//        public ActionResult AddEditWashingPointDetails(FormCollection fc)
//        {
//            ViewBag.WashingPointList = awa.tbl_WashingPointDetails.ToList();

//            var id = Convert.ToInt32(fc["WPid"]);
//            if (id > 0)
//            {
//                tbl_WashingPointDetails washingpoint = awa.tbl_WashingPointDetails.Find(id);

//                washingpoint.WPsubject = fc["WPsubject"];
//                washingpoint.WPsubsubject = fc["WPsubsubject"];
//                washingpoint.WPaddress = fc["WPaddress"];
//                washingpoint.WPnumber = fc["WPnumber"];

//                awa.SaveChanges();
//                return RedirectToAction("ViewAllDetails", "ManageAboutUsDetails");
//            }
//            else
//            {

//                tbl_WashingPointDetails washingpoint = new tbl_WashingPointDetails();

//                washingpoint.WPsubject = fc["WPsubject"];
//                washingpoint.WPsubsubject = fc["WPsubsubject"];
//                washingpoint.WPaddress = fc["WPaddress"];
//                washingpoint.WPnumber = fc["WPnumber"];

//                awa.tbl_WashingPointDetails.Add(washingpoint);
//                awa.SaveChanges();
//                return RedirectToAction("ViewAllDetails");
//            }

//        }




//        public ActionResult DeleteAboutUsDetails(int id)
//        {
//            ViewBag.AboutList = awa.tbl_AboutUsDetails.ToList();


//            tbl_AboutUsDetails deleteaboutusdetails = awa.tbl_AboutUsDetails.Find(id);
//            awa.tbl_AboutUsDetails.Remove(deleteaboutusdetails);
//            awa.SaveChanges();

//            return RedirectToAction("ViewAllDetails");
//        }

//        public ActionResult DeleteTeamMembersDetails(int id)
//        {
//            ViewBag.TeamList = awa.tbl_TeamMemberDetails.ToList();

//            tbl_TeamMemberDetails deleteteammembersdetails = awa.tbl_TeamMemberDetails.Find(id);
//            awa.tbl_TeamMemberDetails.Remove(deleteteammembersdetails);
//            awa.SaveChanges();

//            return RedirectToAction("ViewAllDetails");
//        }

//        public ActionResult DeleteSliderDetails(int id)
//        {
//            ViewBag.SliderList = awa.tbl_SliderDetails.ToList();

//            tbl_SliderDetails deletesliderdetails = awa.tbl_SliderDetails.Find(id);
//            awa.tbl_SliderDetails.Remove(deletesliderdetails);
//            awa.SaveChanges();

//            return RedirectToAction("ViewAllDetails");
//        }
//        public ActionResult DeleteWashingPointDetails(int id)
//        {
//            ViewBag.WashingPointList = awa.tbl_WashingPointDetails.ToList();

//            tbl_WashingPointDetails deletewashingpointdetails = awa.tbl_WashingPointDetails.Find(id);
//            awa.tbl_WashingPointDetails.Remove(deletewashingpointdetails);
//            awa.SaveChanges();

//            return RedirectToAction("ViewAllDetails");
//        }
//    }
//}


using AutoWash.Models.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoWash.Areas.AWAdmin.Controllers
{
    public class ManageAboutUsDetailsController : Controller
    {
        private AutoWashDBEntities awa = new AutoWashDBEntities();

        public ActionResult ViewAllDetails()
        {
            ViewBag.AboutList = awa.tbl_AboutUsDetails.ToList();
            ViewBag.TeamList = awa.tbl_TeamMemberDetails.ToList();
            ViewBag.SliderList = awa.tbl_SliderDetails.ToList();
            ViewBag.WashingPointList = awa.tbl_WashingPointDetails.ToList();
            return View();
        }

        public ActionResult AddEditAboutUsDetails(int id = 0)
        {
            ViewBag.AboutList = awa.tbl_AboutUsDetails.ToList();
            return View(id > 0 ? awa.tbl_AboutUsDetails.Find(id) : new tbl_AboutUsDetails());
        }

        [HttpPost]
        public ActionResult AddEditAboutUsDetails(FormCollection fc, HttpPostedFileBase AUphoto_ufile)
        {
            ViewBag.AboutList = awa.tbl_AboutUsDetails.ToList();

            var id = Convert.ToInt32(fc["AUid"]);
            tbl_AboutUsDetails aboutdetails = id > 0 ? awa.tbl_AboutUsDetails.Find(id) : new tbl_AboutUsDetails();

            aboutdetails.AUsubject = fc["AUsubject"];
            aboutdetails.AUdescription = fc["AUdescription"];

            if (AUphoto_ufile != null)
            {
                aboutdetails.AUphoto = "~/Areas/AWAdmin/Images/AboutImage/" + Path.GetFileName(AUphoto_ufile.FileName);
                AUphoto_ufile.SaveAs(Server.MapPath(aboutdetails.AUphoto));
            }
            else if (id == 0)
            {
                ModelState.AddModelError("AUphoto", "Photo is required for new entries.");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (id == 0) awa.tbl_AboutUsDetails.Add(aboutdetails);
                    awa.SaveChanges();
                    return RedirectToAction("ViewAllDetails");
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            ModelState.AddModelError(validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
            }
            return View(aboutdetails);
        }

        public ActionResult AddEditTeamMembersDetails(int id = 0)
        {
            ViewBag.TeamList = awa.tbl_TeamMemberDetails.ToList();
            return View(id > 0 ? awa.tbl_TeamMemberDetails.Find(id) : new tbl_TeamMemberDetails());
        }

        [HttpPost]
        public ActionResult AddEditTeamMembersDetails(FormCollection fc, HttpPostedFileBase TMphoto_ufile)
        {
            ViewBag.TeamList = awa.tbl_TeamMemberDetails.ToList();

            var id = Convert.ToInt32(fc["TMid"]);
            tbl_TeamMemberDetails teamdetails = id > 0 ? awa.tbl_TeamMemberDetails.Find(id) : new tbl_TeamMemberDetails();

            teamdetails.TMname = fc["TMname"];
            teamdetails.TMprofession = fc["TMprofession"];

            if (TMphoto_ufile != null)
            {
                teamdetails.TMphoto = "~/Areas/AWAdmin/Images/TeamImage/" + Path.GetFileName(TMphoto_ufile.FileName);
                TMphoto_ufile.SaveAs(Server.MapPath(teamdetails.TMphoto));
            }
            else if (id == 0)
            {
                ModelState.AddModelError("TMphoto", "Photo is required for new entries.");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (id == 0) awa.tbl_TeamMemberDetails.Add(teamdetails);
                    awa.SaveChanges();
                    return RedirectToAction("ViewAllDetails");
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            ModelState.AddModelError(validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
            }
            return View(teamdetails);
        }

        public ActionResult AddEditSliderDetails(int id = 0)
        {
            ViewBag.SliderList = awa.tbl_SliderDetails.ToList();
            return View(id > 0 ? awa.tbl_SliderDetails.Find(id) : new tbl_SliderDetails());
        }

        [HttpPost]
        public ActionResult AddEditSliderDetails(FormCollection fc, HttpPostedFileBase SLphoto_ufile)
        {
            ViewBag.SliderList = awa.tbl_SliderDetails.ToList();

            var id = Convert.ToInt32(fc["SLid"]);
            tbl_SliderDetails sliderdetails = id > 0 ? awa.tbl_SliderDetails.Find(id) : new tbl_SliderDetails();

            sliderdetails.SLsubject = fc["SLsubject"];
            sliderdetails.SLsubsubject = fc["SLsubsubject"];
            sliderdetails.SLdescription = fc["SLdescription"];

            if (SLphoto_ufile != null)
            {
                sliderdetails.SLphoto = "~/Areas/AWAdmin/Images/SliderImage/" + Path.GetFileName(SLphoto_ufile.FileName);
                SLphoto_ufile.SaveAs(Server.MapPath(sliderdetails.SLphoto));
            }
            else if (id == 0)
            {
                ModelState.AddModelError("SLphoto", "Photo is required for new entries.");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (id == 0) awa.tbl_SliderDetails.Add(sliderdetails);
                    awa.SaveChanges();
                    return RedirectToAction("ViewAllDetails");
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            ModelState.AddModelError(validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
            }
            return View(sliderdetails);
        }

        public ActionResult AddEditWashingPointDetails(int id = 0)
        {
            ViewBag.WashingPointList = awa.tbl_WashingPointDetails.ToList();
            return View(id > 0 ? awa.tbl_WashingPointDetails.Find(id) : new tbl_WashingPointDetails());
        }

        [HttpPost]
        public ActionResult AddEditWashingPointDetails(FormCollection fc)
        {
            ViewBag.WashingPointList = awa.tbl_WashingPointDetails.ToList();

            var id = Convert.ToInt32(fc["WPid"]);
            tbl_WashingPointDetails washingpoint = id > 0 ? awa.tbl_WashingPointDetails.Find(id) : new tbl_WashingPointDetails();

            washingpoint.WPsubject = fc["WPsubject"];
            washingpoint.WPsubsubject = fc["WPsubsubject"];
            washingpoint.WPaddress = fc["WPaddress"];
            washingpoint.WPnumber = fc["WPnumber"];

            if (ModelState.IsValid)
            {
                try
                {
                    if (id == 0) awa.tbl_WashingPointDetails.Add(washingpoint);
                    awa.SaveChanges();
                    return RedirectToAction("ViewAllDetails");
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            ModelState.AddModelError(validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
            }
            return View(washingpoint);
        }

        public ActionResult DeleteAboutUsDetails(int id)
        {
            ViewBag.AboutList = awa.tbl_AboutUsDetails.ToList();

            tbl_AboutUsDetails deleteaboutusdetails = awa.tbl_AboutUsDetails.Find(id);
            awa.tbl_AboutUsDetails.Remove(deleteaboutusdetails);
            awa.SaveChanges();

            return RedirectToAction("ViewAllDetails");
        }

        public ActionResult DeleteTeamMembersDetails(int id)
        {
            ViewBag.TeamList = awa.tbl_TeamMemberDetails.ToList();

            tbl_TeamMemberDetails deleteteammembersdetails = awa.tbl_TeamMemberDetails.Find(id);
            awa.tbl_TeamMemberDetails.Remove(deleteteammembersdetails);
            awa.SaveChanges();

            return RedirectToAction("ViewAllDetails");
        }

        public ActionResult DeleteSliderDetails(int id)
        {
            ViewBag.SliderList = awa.tbl_SliderDetails.ToList();

            tbl_SliderDetails deletesliderdetails = awa.tbl_SliderDetails.Find(id);
            awa.tbl_SliderDetails.Remove(deletesliderdetails);
            awa.SaveChanges();

            return RedirectToAction("ViewAllDetails");
        }

        public ActionResult DeleteWashingPointDetails(int id)
        {
            ViewBag.WashingPointList = awa.tbl_WashingPointDetails.ToList();

            tbl_WashingPointDetails deletewashingpointdetails = awa.tbl_WashingPointDetails.Find(id);
            awa.tbl_WashingPointDetails.Remove(deletewashingpointdetails);
            awa.SaveChanges();

            return RedirectToAction("ViewAllDetails");
        }
    }
}
