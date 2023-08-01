using Microsoft.AspNetCore.Mvc;
using NetCore_Filters.Filters;

namespace NetCore_Filters.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class TestController : ControllerBase
	{
		private static readonly string[] List = {
			"Test1", "Test2", "Test3", "Test4", "Test5", "Test6", "Test7", "Test8", "Test9", "Test10"
		};

		[HttpGet(Name = "GetWeatherForecast")]
		[ServiceFilter(typeof(ActionFilter))]
		[ServiceFilter(typeof(AuthorizationFilter))]
		[ServiceFilter(typeof(ResultFilter))]
		[ServiceFilter(typeof(ResourceFilter))]
		[ServiceFilter(typeof(ExceptionFilter))]
		public IEnumerable<string> Get()
		{
			throw new Exception();
		}
	}
}
