using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myPhonesFrontOffice1.Startup))]
namespace myPhonesFrontOffice1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
