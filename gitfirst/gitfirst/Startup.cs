using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gitfirst.Startup))]
namespace gitfirst
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
