using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FitnessCenterReservation.Startup))]
namespace FitnessCenterReservation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
