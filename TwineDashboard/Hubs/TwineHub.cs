using Microsoft.AspNet.SignalR.Hubs;

namespace TwineDashboard.Hubs
{
	[HubName("twine")]
	public class TwineHub : Hub
	{
		public void Send(string message)
		{
			// Call the addMessage method on all clients            
			Clients.All.addMessage(message);
		}
	}
}