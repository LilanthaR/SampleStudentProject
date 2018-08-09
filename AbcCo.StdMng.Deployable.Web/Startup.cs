using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AbcCo.StdMng.Deployable.Web.Startup))]
namespace AbcCo.StdMng.Deployable.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
