using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace StudentInformation
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

         
            //Just routing. Action and data not Exist 
            routes.MapRoute(
            name:"BlogList",
            url:"{year}/{month}/{day}/{id}",
            defaults:new 
            {
                controller="Home",
                action="Index",
                year="0000",
                month="00",
                day="00",
                id="0"
            },
            constraints: new {year=@"\d{4}",month=@"\d{2}",day=@"\d{2}",id=@"\d+" }
            
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id=UrlParameter.Optional }
            );
        }
    }
}
