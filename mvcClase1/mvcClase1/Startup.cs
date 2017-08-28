using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcClase1.Startup))]
namespace mvcClase1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
