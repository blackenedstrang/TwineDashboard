using System.Collections.Generic;
using System.Collections.Specialized;
using System.Web.Http;

namespace TwineDashboard.Controllers
{
	public class TwineRecieverController : ApiController
	{
		//TODO: use POST when Twine supports that
		//TODO: try async/await
		[HttpGet]
		public string HighTemperature(string temperature)
		{
			return temperature += "";
		}
	}
}