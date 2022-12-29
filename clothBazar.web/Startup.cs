using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(clothBazar.web.Startup))]
namespace clothBazar.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
