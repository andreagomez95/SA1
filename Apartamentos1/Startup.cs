using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Apartamentos1.Startup))]
namespace Apartamentos1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
