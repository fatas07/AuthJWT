using AuthJWT.Business.Helpers;
using AuthJWT.Business.Models.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace AuthJWT.Api.Filters
{
    public class ModelStateValidFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(new ResponseModelError { Error = ErrorHandlerHelper.MODEL_VALIDATION_ERROR });
            }
        }
    }
}
