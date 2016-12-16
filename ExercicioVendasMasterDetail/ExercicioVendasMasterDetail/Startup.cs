using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExercicioVendasMasterDetail.Startup))]
namespace ExercicioVendasMasterDetail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
