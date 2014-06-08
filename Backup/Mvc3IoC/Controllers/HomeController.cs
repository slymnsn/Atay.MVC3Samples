namespace Mvc3IoC.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Mvc3IoC.Models;
    using Ninject.Injection;
    using Ninject;

    public class HomeController : Controller
    {
        [Inject]
        private readonly IRepository repository;

        public HomeController(IRepository repo)
        {
            this.repository = repo;
        }

        public ActionResult Index()
        {
            var employees = this.repository.GetAll().ToList();

            return View(employees);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
