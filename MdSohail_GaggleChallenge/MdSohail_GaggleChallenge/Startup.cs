using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MdSohail_GaggleChallenge.Startup))]
namespace MdSohail_GaggleChallenge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
