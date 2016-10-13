using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EasyAd.Startup))]
namespace EasyAd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
