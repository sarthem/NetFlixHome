using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootFlixHome.Startup))]
namespace BootFlixHome
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
