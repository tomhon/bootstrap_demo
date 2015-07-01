using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(First_Bootstrap.Startup))]
namespace First_Bootstrap
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
