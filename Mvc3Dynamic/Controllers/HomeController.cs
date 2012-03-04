namespace Mvc3Dynamic.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    /// Dynamic View ve ViewModel 
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /// ASP.Net MVC 1-2 sürümlerinde kullandığım 
            ViewData["Message"] = "ASP.NET MVC 3 RC Sürümüne Bakış";

            /// ASP.Net MVC 3 sürümünde kullandığımız
            ViewBag.Message = "ASP.NET MVC 3 RC Sürümüne Bakış";

            return View();
        }
    }
}
