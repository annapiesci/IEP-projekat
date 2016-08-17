using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pa130555d_projekat.Startup))]
namespace pa130555d_projekat
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
