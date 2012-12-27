using System.Web.Http;
using TwineDashboard.Services;

namespace TwineDashboard.Controllers
{
	public class TwineRecieverController : ApiController
	{
		private readonly TwineHubNotifier _twineHubNotifier;

		public TwineRecieverController()
		{
			_twineHubNotifier = new TwineHubNotifier();
		}

		//TODO: use POST when Twine supports that
		//TODO: try async/await
		[HttpGet] //http://localhost/TwineDashboard/api/TwineReciever/HighTemperature?temperature=42
		public string HighTemperature(string temperature)
		{
			_twineHubNotifier.Notify(string.Format("High temperature - {0}", temperature));
			return temperature;
		}

		[HttpGet]
		public void WaterDetected()
		{
			_twineHubNotifier.Notify("Water detected!");
			//TODO: send SMS with Twilio
		}
	}
}