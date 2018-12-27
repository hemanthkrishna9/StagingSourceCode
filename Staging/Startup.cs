using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Staging.Startup))]
namespace Staging
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
