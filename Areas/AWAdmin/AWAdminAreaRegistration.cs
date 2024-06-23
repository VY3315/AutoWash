using System.Web.Mvc;

namespace AutoWash.Areas.AWAdmin
{
    public class AWAdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AWAdmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AWAdmin_default",
                "AWAdmin/{controller}/{action}/{id}",
                new { controller = "AdminLogin", action = "AdminLogin", id = UrlParameter.Optional }
            );
        }
    }
}