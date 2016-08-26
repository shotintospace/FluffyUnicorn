using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FluffyUnicorn.Startup))]
namespace FluffyUnicorn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
