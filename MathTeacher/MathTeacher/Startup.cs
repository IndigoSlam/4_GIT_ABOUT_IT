using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MathTeacher.Startup))]
namespace MathTeacher
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
