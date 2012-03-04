namespace Mvc3GlobalActionFilters.Utils
{
    using System.Diagnostics;
    using System.Web.Mvc;

    public class StopWatchAttribute : ActionFilterAttribute
    {
        private Stopwatch wath;

        public StopWatchAttribute()
        {
            this.wath = new Stopwatch();
        }

        public override void OnActionExecuting(
                ActionExecutingContext filterContext)
        {
            this.wath.Start();

            base.OnActionExecuting(filterContext);
        }

        public override void OnResultExecuted(
                    ResultExecutedContext filterContext)
        {
            this.wath.Stop();

            var context = filterContext.HttpContext;
            var response = context.Response;

            context.Response.Write(
                string.Format("<!-- oluşturma süresi {0} -->", 
                                this.wath.Elapsed.ToString()));

            base.OnResultExecuted(filterContext);
        }
    }
}