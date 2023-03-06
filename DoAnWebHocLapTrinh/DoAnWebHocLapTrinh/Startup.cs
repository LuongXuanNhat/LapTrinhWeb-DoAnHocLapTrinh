using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoAnWebHocLapTrinh.Startup))]
namespace DoAnWebHocLapTrinh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
