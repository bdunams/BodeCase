using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BodeCase.Startup))]
namespace BodeCase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
