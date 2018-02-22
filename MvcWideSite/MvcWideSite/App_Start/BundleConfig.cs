using System;
using System.Configuration;
using System.Web;
using System.Web.Optimization;

namespace MvcWideSite
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            var scriptsBundle = new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/jquery.validate*");

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            var modernizerBundle = new ScriptBundle("~/bundles/modernizr")
                .Include("~/Scripts/modernizr-*");

            var bootstrapBundle = new ScriptBundle("~/bundles/bootstrap")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/Scripts/respond.js");

            var cssBundle = new StyleBundle("~/Content/css")
                 .Include("~/Content/bootstrap.css")
                 .Include("~/Content/site.css");

            scriptsBundle.Transforms.Add(new JsMinify());
            modernizerBundle.Transforms.Add(new JsMinify());
            bootstrapBundle.Transforms.Add(new JsMinify());
            cssBundle.Transforms.Add(new CssMinify());
            
            bundles.Add(scriptsBundle);
            bundles.Add(modernizerBundle);
            bundles.Add(bootstrapBundle);
            bundles.Add(cssBundle);            
            BundleTable.EnableOptimizations = GetOptimizationSetting();
        }

        private static bool GetOptimizationSetting()
        {
            try
            {
                return Convert.ToBoolean(ConfigurationManager.AppSettings["Optimize"]);
            }
            catch
            {
                return false;
            }            
        }
    }
}
