using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GITHUBSAMPLEPROJECT.Startup))]
namespace GITHUBSAMPLEPROJECT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
