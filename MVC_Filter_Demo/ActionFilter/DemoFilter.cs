using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MVC_Filter_Demo.ActionFilter
{
    public class DemoFilter : IActionFilter
    {
        private ILogger _objLogger;
        public DemoFilter(ILoggerFactory objFactory)
        {
            _objLogger = objFactory.CreateLogger<DemoFilter>();
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            //before the action executes
            _objLogger.LogInformation("OnActionExecuting");
            _objLogger.LogInformation($"Action {context.ActionDescriptor.DisplayName} is starting");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //after the action executes
            _objLogger.LogInformation("OnActionExecuted");
            _objLogger.LogInformation($"Action {context.ActionDescriptor.DisplayName} has completed");
        }

    }
}