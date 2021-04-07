using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wepersoal.Startup))]
namespace wepersoal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
