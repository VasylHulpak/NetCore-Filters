using Microsoft.AspNetCore.Mvc.Filters;

namespace NetCore_Filters.Filters
{
	public class ActionFilter: IActionFilter
	{
		public void OnActionExecuting(ActionExecutingContext context)
		{
			Console.WriteLine("ActionFilter: OnActionExecuting");
		}
		
		public void OnActionExecuted(ActionExecutedContext context)
		{
			Console.WriteLine("ActionFilter: OnActionExecuted");
		}
	}
}
