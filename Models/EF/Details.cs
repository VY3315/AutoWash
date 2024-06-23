using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoWash.Models.EF
{
    public class Details
    {
        public List<tbl_AboutUsDetails> AboutUs { get; set; }
        public List<tbl_TeamMemberDetails> TeamMember { get; set; }
        public List<tbl_SliderDetails> Slider { get; set; }
        public List<tbl_WashingPointDetails> WashingPoint { get; set; }


        public tbl_AboutUsDetails LastAboutUs { get; set; }
        public tbl_TeamMemberDetails LastTeamMember { get; set; }
        public tbl_SliderDetails LastSlider { get; set; }
        public tbl_WashingPointDetails LastWashingPoint { get; set; }

    }
}