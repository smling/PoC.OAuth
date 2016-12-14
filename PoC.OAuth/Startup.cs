using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PoC.OAuth.Startup))]
namespace PoC.OAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
