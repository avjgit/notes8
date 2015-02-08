using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspnetmvc_mvaintro.Startup))]
namespace aspnetmvc_mvaintro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
