using AnkhMorporkWebApp.Models;
using Microsoft.Owin;

using Owin;

[assembly: OwinStartup(typeof(AnkhMorporkWebApp.Startup))]
namespace AnkhMorporkWebApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext(ApplicationContext.Create());
        }
    }
}