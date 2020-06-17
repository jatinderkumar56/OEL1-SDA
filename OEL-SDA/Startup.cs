using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OEL_SDA.Startup))]
namespace OEL_SDA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
