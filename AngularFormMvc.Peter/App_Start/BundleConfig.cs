﻿using System.Web;
using System.Web.Optimization;

namespace AngularFormMvc.Peter
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

            bundles.Add(new StyleBundle("~/bundles/mini-spa/style").Include(
                   "~/Content/bootstrap.css",
                   "~/Content/app.css"));

            bundles.Add(new ScriptBundle("~/bundles/mini-spa/script").Include(
                      "~/Scripts/angular.js",
                      "~/Scripts/angular-route.js",
                      "~/Scripts/angular-ui/ui-bootstrap-tpls.js",
                      "~/app/AngularFormsApp.js",
                      "~/app/DataService.js",
                      "~/app/ValidationDirective.js",
                      "~/app/EmployeeForm/efController.js",
                      "~/app/EmployeeForm/efDirective.js"));



            // Set EnableOptimizations to false for debugging.
            BundleTable.EnableOptimizations = false;
        }
    }
}
