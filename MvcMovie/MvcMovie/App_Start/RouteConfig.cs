using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcMovie
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}", // accepts this type of routes
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } // this is default route
            );

            routes.MapRoute(
                name: "Hello",
                url: "{controller}/{action}/{name}/{id}"
            );
        }
    }
}
