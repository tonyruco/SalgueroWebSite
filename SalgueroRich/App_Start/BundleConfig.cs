using System.Web;
using System.Web.Optimization;

namespace SalgueroRich
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/plugins/jquery.min.js",
                "~/bootstrap/js/bootstrap.min.js",
                "~/plugins/modernizr.js",
                "~/plugins/flexslider/jquery.flexslider.js",
                "~/plugins/owl-carousel/owl.carousel.js",
                "~/plugins/magnific-popup/jquery.magnific-popup.min.js",
                "~/plugins/jquery.appear.js",
                "~/plugins/jquery.countTo.js",
                "~/plugins/flowtype.js",
                "~/plugins/jquery.parallax-1.1.3.js",
                "~/plugins/jquery.validate.js",
                "~/js/template.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/bootstrap/css/bootstrap.css",
                      "~/fonts/font-awesome/css/font-awesome.css",
                      "~/plugins/flexslider/flexslider.css",
                      "~/css/animations.css",
                      "~/plugins/owl-carousel/owl.carousel.css",
                      "~/css/style.css",
                      "~/css/skins/blue.css",
                      "~/css/custom.css"));
        }
    }
}