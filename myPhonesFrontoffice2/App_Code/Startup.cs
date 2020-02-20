using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myPhonesFrontoffice2.Startup))]
namespace myPhonesFrontoffice2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
