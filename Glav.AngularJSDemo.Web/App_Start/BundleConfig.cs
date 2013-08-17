using System.Web;
using System.Web.Optimization;

namespace Glav._WebApiDemo.Web
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-2.*"));

			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

		    bundles.Add(new ScriptBundle("~/bundles/angularJS").Include(
		        "~/Scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularJSDemo").Include(
                        "~/Scripts/bootstrap/demoAppBootstrap.js",
                        "~/Scripts/bootstrap/demoAppRouteConfig.js",
                        "~/Scripts/controllers/slidesController.js",
                        "~/Scripts/controllers/navigationController.js",
                        "~/Scripts/services/triggerService.js",
                        "~/Scripts/directives/showSlideListDirective.js",
                        "~/Scripts/directives/SlideKeyboardNavigationDirective.js",
                        "~/Scripts/factories/slideFactory.js"));
		}
	}
}