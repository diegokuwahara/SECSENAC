using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SECSENAC.Startup))]
namespace SECSENAC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
