﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AutoWash
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "AWAdmin/{controller}/{action}/{id}",
                defaults: new { controller = "AdminLogin", action = "AdminLogin", id = UrlParameter.Optional }
            );
        }
    }
}
