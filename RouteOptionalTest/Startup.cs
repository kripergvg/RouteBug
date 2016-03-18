using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RouteOptionalTest.Startup))]
namespace RouteOptionalTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
