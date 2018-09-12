using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Customer.Startup))]
namespace Customer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
