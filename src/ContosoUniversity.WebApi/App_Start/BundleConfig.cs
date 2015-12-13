using System.Web;
using System.Web.Optimization;

namespace ContosoUniversity.WebApi
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/vendors").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/toastr.js",
                "~/Scripts/jquery.raty.js",
                "~/Scripts/respond.src.js",
                "~/Scripts/angular.js",
                "~/Scripts/angular-route.js",
                "~/Scripts/angular-cookies.js",
                "~/Scripts/angular-validator.js",
                "~/Scripts/angular-ui/ui-bootstrap-tpls.js",
                "~/Scripts/underscore.js",
                "~/Scripts/raphael.js",
                "~/Scripts/morris.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/app/modules/common.core.js",
                "~/Scripts/app/modules/common.ui.js",
                "~/Scripts/app/app.js",
                "~/Scripts/app/layout/sideBar.directive.js",
                "~/Scripts/app/student/studentsCtrl.js",
                "~/Scripts/app/student/studentAddCtrl.js",
                "~/Scripts/app/student/studentEditCtrl.js",
                "~/Scripts/app/account/loginCtrl.js",
                "~/Scripts/app/account/registerCtrl.js",
                "~/Scripts/app/home/rootCtrl.js",
                "~/Scripts/app/home/indexCtrl.js",
                "~/Scripts/app/customers/customersCtrl.js",
                "~/Scripts/app/customers/customersRegCtrl.js",
                "~/Scripts/app/customers/customerEditCtrl.js",
                "~/Scripts/app/movies/moviesCtrl.js",
                "~/Scripts/app/movies/movieAddCtrl.js",
                "~/Scripts/app/movies/movieDetailsCtrl.js",
                "~/Scripts/app/movies/movieEditCtrl.js",
                "~/Scripts/app/controllers/rentalCtrl.js",
                "~/Scripts/app/rental/rentMovieCtrl.js",
                "~/Scripts/app/rental/rentStatsCtrl.js"
                ));
        }
    }
}
