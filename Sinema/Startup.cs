using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sinema.Startup))]
namespace Sinema
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
