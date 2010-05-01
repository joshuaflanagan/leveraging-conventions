using System;
using FubuMVC.StructureMap;
using System.Web.Routing;
using StructureMap;

namespace MyApp
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            var container = new Container();
            new StructureMapBootstrapper(container, new MyFubuRegistry()).Bootstrap(RouteTable.Routes);
        }
    }
}