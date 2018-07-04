using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MsgManagement.Startup))]
namespace MsgManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
