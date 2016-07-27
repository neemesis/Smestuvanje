using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Smestuvanje.Startup))]
namespace Smestuvanje
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
