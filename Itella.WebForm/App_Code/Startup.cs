using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Itella.WebForm.Startup))]
namespace Itella.WebForm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
