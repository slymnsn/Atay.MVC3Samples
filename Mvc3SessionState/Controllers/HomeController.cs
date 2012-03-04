namespace Mvc3SessionState.Controllers
{
    using System.Web.Mvc;

    using System.Web.SessionState;

    /// SessionStateBehavior.Disabled : session kapalı.
    /// SessionStateBehavior.Default  : session açık
    /// SessionStateBehavior.ReadOnly : session sadece okunabilir.
    /// SessionStateBehavior.Required : okuma ve yazamaya açık
    
    [SessionState(SessionStateBehavior.Required)]
    public class HomeController : Controller
    {
        public ActionResult Index(string message)
        {
            Session["NedirTv"] = message;

            if (message != string.Empty)
            {
                return View();
            }

            return RedirectToAction("About");
        }

        public ActionResult About()
        {
            string message = Session["NedirTv"] as string;

            return View(message);
        }
    }
}
