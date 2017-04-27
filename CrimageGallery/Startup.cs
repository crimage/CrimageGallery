using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrimageGallery.Startup))]
namespace CrimageGallery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
