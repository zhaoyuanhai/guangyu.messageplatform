using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MsgUI.Startup))]
namespace MsgUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
