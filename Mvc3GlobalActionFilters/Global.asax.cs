namespace Mvc3GlobalActionFilters
{
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;
    using Mvc3GlobalActionFilters.Utils;

    public class MvcApplication : HttpApplication
    {
        public static void RegisterGlobalFilters(
                        GlobalFilterCollection filters)
        {
            /// Uygulama içerisinde hata yönetimini 
            /// yapana globalfilter nesnesini 
            /// ASP.Net MVC sistemine kayıt edildi.
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", 
                    id = UrlParameter.Optional });
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            /// Hazırlamış olduğumuzu global action filter nesnesini
            /// ASP.Net MVC sistemine tanıtmış olduk.
            GlobalFilters.Filters.Add(new StopWatchAttribute());

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}