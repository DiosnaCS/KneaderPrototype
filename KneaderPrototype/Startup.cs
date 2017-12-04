using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KneaderPrototype.Startup))]
namespace KneaderPrototype
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
