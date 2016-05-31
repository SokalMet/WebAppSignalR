using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppSignalR.Startup))]
namespace WebAppSignalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
