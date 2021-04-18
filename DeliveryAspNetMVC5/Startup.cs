using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeliveryAspNetMVC5.Startup))]
namespace DeliveryAspNetMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
