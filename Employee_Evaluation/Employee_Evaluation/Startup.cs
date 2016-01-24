using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Employee_Evaluation.Startup))]
namespace Employee_Evaluation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
