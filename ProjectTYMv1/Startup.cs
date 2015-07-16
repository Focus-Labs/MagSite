using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectTYMv1.Startup))]
namespace ProjectTYMv1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
