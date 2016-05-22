using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebHost.Internalized.Sqlite.Startup))]

namespace WebHost.Internalized.Sqlite
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
