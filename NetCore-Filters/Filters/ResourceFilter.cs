using Microsoft.AspNetCore.Mvc.Filters;

namespace NetCore_Filters.Filters
{
	public class ResourceFilter : IResourceFilter
	{
		public void OnResourceExecuting(ResourceExecutingContext context)
		{
			Console.WriteLine("ResourceFilter: OnResourceExecuting");
		}
		public void OnResourceExecuted(ResourceExecutedContext context)
		{
			Console.WriteLine("ResourceFilter: OnResourceExecuted");
		}
	}
}
