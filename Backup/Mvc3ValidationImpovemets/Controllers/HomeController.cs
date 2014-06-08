namespace Mvc3ValidationImpovemets.Controllers
{
    using System.Web.Mvc;
    using Mvc3ValidationImpovemets.Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Person p = new Person();
            return View(p);
        }

        /// [ValidateInput(false)]
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "ID")]Person p)
        {
            var a = p.Bio;

            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
