using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L_CRM_MVC.Startup))]
namespace L_CRM_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
