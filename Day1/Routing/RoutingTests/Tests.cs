using Machine.Specifications;
using WebApplication.Controllers;
using It = Machine.Specifications.It;
using System.Web.Mvc;
using WebApplication;
using System.Web.Routing;
using Moq;
using System.Reflection;

namespace RoutingTests
{
    [Subject(typeof(ProductController))]

    public class When_user_routing_not_valid
        {
            //static ProductController controller;

            //    Establish context = () =>
            //{
            //    controller = new ProductController();
            //};

            //    It should_return_a_ViewResult_with_default_view_name = () =>
            //    {
            //        var result = controller.Index();

            //        result.ViewName.ShouldBeEmpty();
            //    };
            static RouteCollection routes;
            static RouteData result;
            static bool value;
            static string url;

            Establish context = () =>
            {
                routes = new RouteCollection();
                RouteConfig.RegisterRoutes(routes);
                url = "~/Product/Index/1001";
            };

            Because of = () =>
            {
                result = routes.GetRouteData(TestHelpers.CreateHttpContext(url));
                value = (result == null || result.Route == null);
            };

            It should_not_pass = () => value.ShouldBeTrue();

        }

    [Subject("Routing")]
    public class When_user_routing_valid
    {
        static RouteCollection routes;
        static RouteData result;
        static string url;
        static string controller;
        static string action;
        static string routeProperties;

        Establish context = () =>
        {
            routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);
            url = "~/Product/Index/1001";
            
        };

        Because of = () => result = routes.GetRouteData(TestHelpers.CreateHttpContext(url));

        It should_pass = () => result.ShouldNotBeNull();
        It should_also_pass = () => TestHelpers.TestIncomingRouteResult(result, controller, action, routeProperties).ShouldBeTrue();
    }
}
