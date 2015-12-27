using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_datsan.Startup))]
namespace Project_datsan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
