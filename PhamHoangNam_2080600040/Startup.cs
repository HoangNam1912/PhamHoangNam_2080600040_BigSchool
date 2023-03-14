using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhamHoangNam_2080600040.Startup))]
namespace PhamHoangNam_2080600040
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
