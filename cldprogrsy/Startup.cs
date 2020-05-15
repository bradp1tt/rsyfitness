using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cldprogrsy.Startup))]
namespace cldprogrsy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
