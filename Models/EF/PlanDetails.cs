using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoWash.Models.EF
{
    public class PlanDetails
    {


        public List<tbl_basiccleaning> BasicCleantables { get; set; }
        public List<tbl_premiumcleaning> PrimeCleantables { get; set; }
        public List<tbl_complexcleaning> ComplexCleantables { get; set; }

        public tbl_basiccleaning LastBasicCleantables { get; set; }
        public tbl_premiumcleaning LastPrimeCleantables { get; set; }
        public tbl_complexcleaning LastComplexCleantables { get; set; }

    }
}