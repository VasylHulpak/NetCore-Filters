using Microsoft.AspNetCore.Mvc.Filters;

namespace NetCore_Filters.Filters
{
	public class ResultFilter : IResultFilter
	{
		public void OnResultExecuting(ResultExecutingContext context)
		{
			Console.WriteLine("ResultFilter: OnResourceExecuted");
		}
		public void OnResultExecuted(ResultExecutedContext context)
		{
			Console.WriteLine("ResultFilter: OnResourceExecuted");
		}
	}
}
