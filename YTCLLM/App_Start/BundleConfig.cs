using System.Web;
using System.Web.Optimization;

namespace YTCLLM
{
    public static class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-1.11.4.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

	        bundles.Add(new StyleBundle("~/Content/css").Include(
				  "~/Content/bootstrap-theme.css", 
		        "~/Content/bootstrap.css",
				  "~/Content/mainStyle.css"));

            bundles.Add(new StyleBundle("~/Content/accountCss").Include(
                "~/Content/bootstrap-theme.css",
                "~/Content/bootstrap.css"
                ));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));


				//Per-page bundles. (bundled for optimizations, and for the fact that @media cannot be used in html form)
	        bundles.Add(new StyleBundle("~/Content/css/accountLogging").Include(
		        "~/Content/accountLoggingStyle.css",
                "~/Content/jquery-ui.css"));

				bundles.Add(new StyleBundle("~/Content/css/coverPage").Include(
					 "~/Content/coverPage.css"));



				BundleTable.EnableOptimizations = true;
        }
    }
}