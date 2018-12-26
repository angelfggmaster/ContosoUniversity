﻿using System.Web;
using System.Web.Optimization;

namespace ContosoUniversity
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/bootstrap.min.css",
                "~/Content/css/font-awesome.min.css",
                "~/Content/css/animate.min.css",
                "~/Content/css/et-line-font.css",
                "~/Content/css/nivo-lightbox.css",
                "~/Content/css/nivo_themes/default/default.css",
                "~/Content/css/style.css"
            ));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Scripts/jquery.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/smoothscroll.js",
                "~/Scripts/isotope.js",
                "~/Scripts/imagesloaded.min.js",
                "~/Scripts/nivo-lightbox.min.js",
                "~/Scripts/jquery.backstretch.min.js",
                "~/Scripts/wow.min.js",
                "~/Scripts/custom.js"
            ));
        }
    }
}
