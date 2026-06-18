using Microsoft.AspNetCore.Mvc.Filters;

namespace NetCoreMVCEgitimi.Filters
{
    public class UserControl : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var kullaniciId = context.HttpContext.Session.GetInt32("kullaniciId");
            if (kullaniciId == null)
            {
                context.HttpContext.Response.Redirect("/MVC12Session/index");
            }
        
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
        }
    }
}
