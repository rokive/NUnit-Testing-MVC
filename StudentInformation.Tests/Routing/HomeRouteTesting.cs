using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Routing;
using MvcRouteTester;

namespace StudentInformation.Tests.Routing
{
    [TestClass]
    public class HomeRouteTesting
    {
        //Look up to the StudentInformation MVC Web Project ->App_Start->RouteConfig.cs file
        [TestMethod]
        public void RouteToHomeAndIndex()
        {
            //Arrange
            var routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);
            
            //Act
            var route = new { controller = "Home", action = "Index"};
            
            //Assert
            RouteAssert.HasRoute(routes, "/", route);
        }
        
        [TestMethod]
        public void RouteToHomeAndIndexWithYear()
        {
            var routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);
            var route = new { controller = "Home", action = "Index", year=2015 };
            RouteAssert.HasRoute(routes, "/2015", route);
        }
        [TestMethod]
        public void RouteToHomeAndIndexWithYearAndMonth()
        {
            var routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);
            var route = new { controller = "Home", action = "Index", year = 2015, month="08" };
            RouteAssert.HasRoute(routes, "/2015/08", route);
        }
        [TestMethod]
        public void RouteToHomeAndIndexWithMonthAndDay()
        {
            var routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);
            var route = new { controller = "Home", action = "Index", year = 2015, month="03", day="08"};
            RouteAssert.HasRoute(routes, "/2015/03/08", route);
        }

        [TestMethod]
        public void RouteToHomeAndIndexWithMonthAndDayWithId()
        {
            var routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);
            var route = new { controller = "Home", action = "Index", year = 2015, month="03", day="08", id="1000" };
            RouteAssert.HasRoute(routes, "/2015/03/08/1000", route);
        }
    }
}
