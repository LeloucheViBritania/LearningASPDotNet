﻿using System.Web;
using System.Web.Optimization;

namespace DynamikTemplateGrp
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            # region template Desing

            bundles.Add(new ScriptBundle("~/template/js").Include(
                        "~/Scripts/jquery.min.js",
                        "~/Scripts/jquery.easing.1.3.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/jquery.waypoints.min..js",
                        "~/Scripts/jquery.stellar.min.js",
                        "~/Scripts/owl.carousel.min.js",
                        "~/Scripts/jquery.countTo.js",
                        "~/Scripts/jquery.magnific-popup.min.js",
                        "~/Scripts/magnific-popup-options.js",
                        "~/Scripts/main.js",
                        "~/Scripts/modernizr-2.6.2.min.js"));


            bundles.Add(new StyleBundle("~/template/css").Include(
                      "~/Content/css/animate.css",
                      "~/Content/css/icomoon.css",
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/magnific-popup.css",
                      "~/Content/css/owl.carousel.min.css",
                      "~/Content/css/owl.theme.default.min.css",
                      "~/Content/css/style.css"));


            #  endregion

        }
    }
}
