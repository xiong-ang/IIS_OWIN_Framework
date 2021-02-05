using Controllers;
using System.Web.Http;
using System.Web.Http.Dispatcher;

namespace ConvertToolServer
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}/{namespaces}",
                defaults: new { id = RouteParameter.Optional, namespaces = new[] { "Controllers" } }
            );

            config.Services.Replace(typeof(IHttpControllerSelector), new ControllerSelector(config));

        }
    }
}
