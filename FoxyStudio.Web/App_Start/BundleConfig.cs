using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace FoxyStudio.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Main Page Bundles START
            bundles.Add(new ScriptBundle("~/j")
                      .Include(
                "~/Scripts/js/jquery.2.2.3.js",
                 "~/Scripts/js/popper.js",
                  "~/Scripts/js/bootstrap.js",
                   "~/Scripts/js/mega-menu.js",
                    "~/Scripts/js/aos.js",
                     "~/Scripts/js/wow.js",
                      "~/Scripts/js/owl.carousel.js",
                       "~/Scripts/js/jquery.appear.js",
                        "~/Scripts/js/jquery.countTo.js",
                         "~/Scripts/js/jquery.fancybox.js",
                          "~/Scripts/js/isotope.pkgd.min.js",
                          "~/Scripts/js/theme.js"

              ));
            bundles.Add(new StyleBundle("~/c")
                    .Include(
                "~/Content/css/circular-std.css",
"~/Content/css/bootstrap.css",
"~/Content/css/menu.css",
"~/Content/css/font-awesome.css",
"~/Content/css/owl.carousel.css",
"~/Content/css/owl.theme.css",
"~/Content/css/animate.css",
"~/Content/css/aos.css",
"~/Content/css/jquery.fancybox.css",
"~/Content/css/snazzy-info-window.css",
"~/Content/css/flaticon.css",
"~/Content/css/custom-animation.css",
"~/Content/css/animated-headline-master",
"~/Content/css/style.css",
"~/Content/css/iziModal.css",
"~/Content/css/jquery-ui.css",
"~/Content/css/selectize.css",
"~/Content/css/style.css",
"~/Content/css/responsive.css"

              ));

            BundleTable.EnableOptimizations = true;

        }
    }
}