using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Customer",
                url: "{controller}/{action}/{document}/{*data}",
                defaults: new { controller = "Home ", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "SpecialRoute", "Special/{action}/{id}/{*catchall}",
                new { controller = "Product", action = "OutputToJson", id = @"\d+" },
                new[] { "MyCom.Team1" }
                );

            routes.MapRoute(
                "GeneralRoute", "Product/{action}/{id: int}",
                 new { controller = "Product", action = "Index" },
                 new[] { "MyCom.Team2" }
              );
        }

    }
}

