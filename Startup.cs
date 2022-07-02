using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaDeInscripcionUniversitario.Startup))]
namespace SistemaDeInscripcionUniversitario
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
