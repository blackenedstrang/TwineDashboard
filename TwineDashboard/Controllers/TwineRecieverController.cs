using System.Collections.Generic;
using System.Collections.Specialized;
using System.Web;
using System.Web.Http;

namespace TwineDashboard.Controllers
{
	public class TwineRecieverController : ApiController
	{
		//TODO: use POST instead when Twine supports that
		//TODO: try async/await
		public void Get()
		{
			//http://localhost:5935/api/TwineReciever/?temperature=25&orientation=top
			var nvc = HttpUtility.ParseQueryString(Request.RequestUri.Query);
			var temperature = nvc["temperature"];
			var orientation = nvc["orientation"];
		}

		// POST api/<controller>
		//public void Post([FromBody]string value)
		//{
		//}
	}
}