using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMdApp_02.Startup))]
namespace WebMdApp_02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
