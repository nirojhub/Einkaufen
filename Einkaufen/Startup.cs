using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Einkaufen.Startup))]
namespace Einkaufen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
