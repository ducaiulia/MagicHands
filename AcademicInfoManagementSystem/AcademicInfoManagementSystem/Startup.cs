using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AcademicInfoManagementSystem.Startup))]
namespace AcademicInfoManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
