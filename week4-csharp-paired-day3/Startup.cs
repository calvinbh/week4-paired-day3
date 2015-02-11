using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(week4_csharp_paired_day3.Startup))]
namespace week4_csharp_paired_day3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
