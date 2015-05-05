using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JKAzureTest.Startup))]
namespace JKAzureTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
