using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test10.Startup))]
namespace test10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
