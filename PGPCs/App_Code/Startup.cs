using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PGPCs.Startup))]
namespace PGPCs
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
