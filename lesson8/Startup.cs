using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lesson8.Startup))]
namespace lesson8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
