using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(identity_service.Startup))]
namespace identity_service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
