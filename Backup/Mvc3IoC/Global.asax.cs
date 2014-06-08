namespace Mvc3IoC
{
    using System.Reflection;
    using System.Web.Mvc;
    using System.Web.Routing;
    using Mvc3IoC.Controllers;
    using Mvc3IoC.Models;
    using Mvc3IoC.Utils;
    using Ninject;

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }

        public static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IRepository>().To<EmployeeRepository>();
            kernel.Bind<IController>().To<HomeController>();
        }

        public void SetupDependencyInjection()
        {
            IKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            RegisterServices(kernel);

            /// ASP.
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }

        protected void Application_Start()
        {
            this.SetupDependencyInjection();

            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}