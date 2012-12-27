using Microsoft.AspNet.SignalR;
using TwineDashboard.Hubs;

namespace TwineDashboard.Services
{
	//TODO: employ NSB for learning matters? :)
	public class TwineHubNotifier
	{
		public void Notify(string message)
		{
			var context = GlobalHost.ConnectionManager.GetHubContext<TwineHub>();
			context.Clients.All.addMessage(message);
		}
	}
}