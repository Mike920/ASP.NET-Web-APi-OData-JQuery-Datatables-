using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OData_Grid.Startup))]
namespace OData_Grid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
