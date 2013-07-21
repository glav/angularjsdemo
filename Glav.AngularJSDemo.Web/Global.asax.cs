using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Services;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Glav._WebApiDemo.Web.Data;
using Glav.AgularJSDemo.Web;
using Glav.AgularJSDemo.Web.Controllers;
using System.Web.Http.Description;
using System.Web.Http.ModelBinding;

namespace Glav._WebApiDemo.Web
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class WebApiApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			SetupApiRoutes();

			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);

		}


		private void SetupApiRoutes()
		{
			RouteTable.Routes.MapHttpRoute("default-http", "api/{controller}/{slideNumber}");
		}


	}
}