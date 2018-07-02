using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitWebZ.Startup))]
namespace GitWebZ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
