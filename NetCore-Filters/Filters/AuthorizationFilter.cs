using Microsoft.AspNetCore.Mvc.Filters;

namespace NetCore_Filters.Filters
{
	public class AuthorizationFilter : IAuthorizationFilter
	{
		public void OnAuthorization(AuthorizationFilterContext context)
		{
			Console.WriteLine("AuthorizationFilter: OnAuthorization");
		}
	}
}
