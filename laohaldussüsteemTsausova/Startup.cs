using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(laohaldussüsteemTsausova.Startup))]
namespace laohaldussüsteemTsausova
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
