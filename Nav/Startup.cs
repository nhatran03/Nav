using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nav.Startup))]
namespace Nav
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
