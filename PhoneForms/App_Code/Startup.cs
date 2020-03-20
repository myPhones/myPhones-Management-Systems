using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhoneForms.Startup))]
namespace PhoneForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
