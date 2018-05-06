using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SMS_Sender.Startup))]
namespace SMS_Sender
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
