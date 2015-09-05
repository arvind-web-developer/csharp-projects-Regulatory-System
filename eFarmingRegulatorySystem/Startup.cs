using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eFarmingRegulatorySystem.Startup))]
namespace eFarmingRegulatorySystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
