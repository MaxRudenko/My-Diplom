using System.Web;
using System.Web.Optimization;

namespace Diplom.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angularMainApp")
                .Include("~/bower_components/angular/angular.js")
                .Include("~/bower_components/angular-ui-router/release/angular-ui-router.min.js")
                .Include("~/app/app.js")
                .IncludeDirectory("~/app/common", "*.js")
                .IncludeDirectory("~/app/services", "*.js")
                .IncludeDirectory("~/app/controllers", "*.js"));
                


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
