namespace Mvc3SessionState.Controllers
{
    using System.Web.Mvc;

    using System.Web.SessionState;

    /// SessionStateBehavior.Disabled : session kapalı.
    /// SessionStateBehavior.Default  : session açık
    /// SessionStateBehavior.ReadOnly : session sadece okunabilir.
    /// SessionStateBehavior.Required : okuma ve yazamaya açık
    
    //[SessionState(SessionStateBehavior.Required)]
    public class HomeController : Controller
    {
        public ActionResult Index(string message)
        {
            Session["NedirTv"] = message;

            if (message != null)
            {
                return RedirectToAction("About");
            }

            return View();
        }

        public ActionResult About()
        {
            string message = Session["NedirTv"] as string;

            if (!string.IsNullOrEmpty(message))
            {
                ViewData["NedirTv"] = message;
            }

            return View();
        }
    }
}
