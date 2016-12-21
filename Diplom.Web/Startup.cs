using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Diplom.Web.Startup))]
namespace Diplom.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
