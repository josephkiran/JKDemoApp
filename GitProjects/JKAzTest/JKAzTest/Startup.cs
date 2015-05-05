using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JKAzTest.Startup))]
namespace JKAzTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
