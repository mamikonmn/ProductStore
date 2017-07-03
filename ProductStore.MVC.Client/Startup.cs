using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductStore.MVC.Client.Startup))]
namespace ProductStore.MVC.Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
