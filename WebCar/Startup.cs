using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebCar.Startup))]
namespace WebCar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
