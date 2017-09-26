using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prova01.Startup))]
namespace Prova01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
