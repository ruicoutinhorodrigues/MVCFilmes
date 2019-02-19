using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFilmes.Startup))]
namespace MVCFilmes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
