using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineWeek4Day2.Startup))]
namespace OnlineWeek4Day2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
