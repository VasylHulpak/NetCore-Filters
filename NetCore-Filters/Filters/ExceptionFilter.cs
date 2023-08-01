using Microsoft.AspNetCore.Mvc.Filters;

namespace NetCore_Filters.Filters
{
	public class ExceptionFilter : IExceptionFilter
	{
		public void OnException(ExceptionContext context)
		{
			Console.WriteLine("ExceptionFilter: OnException");
		}
	}
}
