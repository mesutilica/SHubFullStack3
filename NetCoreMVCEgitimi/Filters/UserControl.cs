using Microsoft.AspNetCore.Mvc.Filters;

namespace NetCoreMVCEgitimi.Filters
{
    public class UserControl : ActionFilterAttribute
    {
        override public void OnActionExecuting(ActionExecutingContext context)
        {
            var kullaniciId = context.HttpContext.Session.GetInt32("kullaniciId");
            if (kullaniciId == null)
            {
                context.HttpContext.Response.Redirect("/MVC12Session/Index");
            }
        }
        override public void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
        }
    }
}