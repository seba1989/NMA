using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NMAweb.Startup))]
namespace NMAweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
