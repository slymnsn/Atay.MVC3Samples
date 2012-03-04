namespace Mvc3Code404.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        ///  Uygulama içerisinde 404 yani kaynak bulunamadığı 
        ///  durumlarda bu fonksiyon tetiklendir.
        protected override HttpNotFoundResult HttpNotFound(string 
                                                     statusDescription)
        {
            return base.HttpNotFound(statusDescription);
        }

        /// Controller içerisinde yaşanacak tüm hataları kontrol edebilecek 
        /// hata yönetim fonksiyonu
        protected override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
        }
    }
}
