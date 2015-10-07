using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test_J_DataTable_3.Startup))]
namespace test_J_DataTable_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
