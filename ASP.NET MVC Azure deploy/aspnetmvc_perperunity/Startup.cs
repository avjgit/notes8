using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspnetmvc_perperunity.Startup))]
namespace aspnetmvc_perperunity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
