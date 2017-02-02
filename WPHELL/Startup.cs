using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WPHELL.Startup))]
namespace WPHELL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
