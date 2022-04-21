using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoginAttacks.Startup))]
namespace LoginAttacks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
