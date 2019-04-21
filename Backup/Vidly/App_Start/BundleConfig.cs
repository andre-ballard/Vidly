using System;
using System.Web.Optimization;

namespace Vidly.App_Start
{
    public class BundleConfig
    {
        public BundleConfig()
        {
            
        }



        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/scripts/bootbox.js",
                        "~/Scripts/respond.js",
                        "~/scripts/datatables/jquery.datatables.js",
                        "~/scripts/datatables/datatables.bootstrap.js",
                        "~/scripts/typeahead.bundle.js",
                        "~/scripts/toastr.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/bootstrap-lumen.css",
                "~/Content/css/bootstrap-theme.css",
                "~/Content/css/datatables/css/datatables.bootstrap.css",
                "~/Content/css/typeahead.css",
                "~/Content/css/toastr.css",
                "~/Content/css/site.css"
            ));
        }
    }
}
