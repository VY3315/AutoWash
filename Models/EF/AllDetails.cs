using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoWash.Models.EF
{
    public class AllDetails
    {
        public List<tbl_AboutUsDetails> AboutUs { get; set; }
        public List<tbl_TeamMemberDetails> TeamMember { get; set; }
        public List<tbl_SliderDetails> Slider { get; set; }
        public List<tbl_WashingPointDetails> WashingPoint { get; set; }
        public List<tbl_basiccleaning> BasicCleantables { get; set; }
        public List<tbl_premiumcleaning> PrimeCleantables { get; set; }
        public List<tbl_complexcleaning> ComplexCleantables { get; set; }
        public List<tbl_ManageContactDetails> ContactUs { get; set; }
        





        public tbl_AboutUsDetails LastAboutUs { get; set; }
        public tbl_TeamMemberDetails LastTeamMember { get; set; }
        public tbl_SliderDetails LastSlider { get; set; }
        public tbl_WashingPointDetails LastWashingPoint { get; set; }
        public tbl_basiccleaning LastBasicCleantables { get; set; }
        public tbl_premiumcleaning LastPrimeCleantables { get; set; }
        public tbl_complexcleaning LastComplexCleantables { get; set; }
        public tbl_ManageContactDetails LastContactUs { get; set; }

    }
}