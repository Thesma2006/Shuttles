using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ShuttlesCloud.Startup))]

namespace ShuttlesCloud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}