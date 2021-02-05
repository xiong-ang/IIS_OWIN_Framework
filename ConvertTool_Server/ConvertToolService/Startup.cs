using Controllers;
using Microsoft.Owin;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using Owin;
using System;
using System.IO;
using System.Web.Http;
using System.Web.Http.Dispatcher;

[assembly: OwinStartup(typeof(ConvertToolService.Startup))]

namespace ConvertToolService
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //static file middleware
            app.UseFileServer(new FileServerOptions
            {
                EnableDirectoryBrowsing = true,
                FileSystem = new PhysicalFileSystem(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UI"))
            });


            //web api middleware
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}/{namespaces}",
                defaults: new { id = RouteParameter.Optional, namespaces = new[] { "Controllers" } }
            );
            config.Services.Replace(typeof(IHttpControllerSelector), new ControllerSelector(config));
            app.UseWebApi(config);
        }
    }
}
