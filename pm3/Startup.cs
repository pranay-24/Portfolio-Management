using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pm3.Startup))]
namespace pm3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
