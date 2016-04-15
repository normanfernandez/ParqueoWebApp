using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParqueoWebApp.Startup))]
namespace ParqueoWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
