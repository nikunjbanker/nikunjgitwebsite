using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NikunjGitWebsite.Startup))]
namespace NikunjGitWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
