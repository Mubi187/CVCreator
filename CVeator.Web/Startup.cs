using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CVeator.Web.Startup))]
namespace CVeator.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
