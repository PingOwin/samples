using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebHost.SqlLite.Startup))]

namespace WebHost.SqlLite
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
