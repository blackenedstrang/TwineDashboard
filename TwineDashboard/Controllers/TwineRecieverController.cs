using System.Web.Http;
using TwineDashboard.Helpers;
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
		[HttpGet] //http://localhost/TwineDashboard/api/TwineReciever/HighTemperature?temperature=42
		public void HighTemperature(string temperature)
		{
			var celsius = TemperatureConverter.FahrenheitToCelsius(temperature);
			_twineHubNotifier.Notify(string.Format("High temperature - {0} C", celsius));
		}

		[HttpGet]
		public void LowTemperature(string temperature)
		{
			var celsius = TemperatureConverter.FahrenheitToCelsius(temperature);
			_twineHubNotifier.Notify(string.Format("Low temperature - {0} C", celsius));
		}

		[HttpGet]
		public void WaterDetected()
		{
			_twineHubNotifier.Notify("Water detected!");
			//TODO: send SMS with Twilio
		}
	}
}