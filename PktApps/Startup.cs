using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PktApps.Startup))]
namespace PktApps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
