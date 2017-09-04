using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRChat1.Startup))]
namespace SignalRChat1
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
