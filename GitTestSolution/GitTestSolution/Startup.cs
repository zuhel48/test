using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitTestSolution.Startup))]
namespace GitTestSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
