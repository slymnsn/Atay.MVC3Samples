using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc3GlobalActionFilters.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            /// ...
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            /// ...
        }

        protected override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            /// ...
        }
    }
}
