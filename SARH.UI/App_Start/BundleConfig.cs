using System.Web;
using System.Web.Optimization;

namespace SARH.UI
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            //<!-- BEGIN GLOBAL MANDATORY STYLES -->
            bundles.Add(new StyleBundle("~/Content/GlobalStyle").Include(
                     "~/Content/theme/assets/global/plugins/font-awesome/css/font-awesome.min.css",
                     "~/Content/theme/assets/global/plugins/simple-line-icons/simple-line-icons.min.css",
                     "~/Content/theme/assets/global/plugins/bootstrap/css/bootstrap.min.css",
                     "~/Content/theme/assets/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css",
                     "~/Content/theme/assets/global/plugins/bootstrap-daterangepicker/daterangepicker.min.css",
                     "~/Content/theme/assets/global/plugins/morris/morris.css",
                     "~/Content/theme/assets/global/plugins/fullcalendar/fullcalendar.min.css",
                     "~/Content/theme/assets/global/plugins/jqvmap/jqvmap/jqvmap.css",
                     "~/Content/theme/assets/global/css/components-md.min.css",
                     "~/Content/theme/assets/global/css/plugins-md.min.css",
                     "~/Content/theme/assets/layouts/layout/css/layout.min.css",
                     "~/Content/theme/assets/layouts/layout/css/themes/darkblue.min.css",
                     "~/Content/theme/assets/layouts/layout/css/custom.min.css"));


            bundles.Add(new ScriptBundle("~/bundles/ComponentPlugin").Include(
                    "~/Content/theme/assets/global/plugins/jquery.min.js",
                    "~/Content/theme/assets/global/plugins/bootstrap/js/bootstrap.min.js",
                    "~/Content/theme/assets/global/plugins/js.cookie.min.js",
                    "~/Content/theme/assets/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js",
                    "~/Content/theme/assets/global/plugins/jquery.blockui.min.js",
                    "~/Content/theme/assets/global/plugins/bootstrap-switch/js/bootstrap-switch.min.js",
                    "~/Content/theme/assets/global/plugins/moment.min.js",
                    "~/Content/theme/assets/global/plugins/bootstrap-daterangepicker/daterangepicker.min.js",
                    "~/Content/theme/assets/global/plugins/morris/morris.min.js",
                    "~/Content/theme/assets/global/plugins/morris/raphael-min.js",
                    "~/Content/theme/assets/global/plugins/counterup/jquery.waypoints.min.js",
                    "~/Content/theme/assets/global/plugins/counterup/jquery.counterup.min.js",
                    "~/Content/theme/assets/global/plugins/amcharts/amcharts/amcharts.js",
                    "~/Content/theme/assets/global/plugins/amcharts/amcharts/serial.js",
                    "~/Content/theme/assets/global/plugins/amcharts/amcharts/pie.js",
                    "~/Content/theme/assets/global/plugins/amcharts/amcharts/radar.js",
                    "~/Content/theme/assets/global/plugins/amcharts/amcharts/themes/light.js",
                    "~/Content/theme/assets/global/plugins/amcharts/amcharts/themes/patterns.js",
                    "~/Content/theme/assets/global/plugins/amcharts/amcharts/themes/chalk.js",
                    "~/Content/theme/assets/global/plugins/amcharts/ammap/ammap.js",
                    "~/Content/theme/assets/global/plugins/amcharts/ammap/maps/js/worldLow.js",
                    "~/Content/theme/assets/global/plugins/amcharts/amstockcharts/amstock.js",
                    "~/Content/theme/assets/assets/global/plugins/fullcalendar/fullcalendar.min.js",
                    "~/Content/theme/assets/global/plugins/horizontal-timeline/horizontal-timeline.js",
                    "~/Content/theme/assets/global/plugins/flot/jquery.flot.min.js",
                    "~/Content/theme/assets/global/plugins/flot/jquery.flot.resize.min.js",
                    "~/Content/theme/assets/global/plugins/flot/jquery.flot.categories.min.js",
                    "~/Content/theme/assets/global/plugins/jquery-easypiechart/jquery.easypiechart.min.js",
                    "~/Content/theme/assets/global/plugins/jquery.sparkline.min.js",
                    "~/Content/theme/assets/global/plugins/jqvmap/jqvmap/jquery.vmap.js",
                    "~/Content/theme/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.russia.js",
                    "~/Content/theme/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.world.js",
                    "~/Content/theme/assets/global/plugins/jqvmap/jqvmap/data/jquery.vmap.sampledata.js"));


              bundles.Add(new ScriptBundle("~/bundles/ThemeScript").Include(
                   "~/Content/theme/assets/global/scripts/app.min.js",
                   "~/Content/theme/assets/pages/scripts/dashboard.min.js",
                   "~/Content/theme/assets/layouts/layout/scripts/layout.min.js",
                   "~/Content/theme/assets/layouts/layout/scripts/demo.min.js",
                   "~/Content/theme/assets/layouts/global/scripts/quick-sidebar.min.js",
                   "~/Content/theme/assets/layouts/global/scripts/quick-nav.min.js"));

        }
    }
}
