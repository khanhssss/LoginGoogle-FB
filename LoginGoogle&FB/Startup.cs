using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoginGoogle_FB.Startup))]
namespace LoginGoogle_FB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
