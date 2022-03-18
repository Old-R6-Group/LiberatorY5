namespace LiberatorY5
{
    public class HostStatus
    {
		public enum Statuses
		{
			Default,
			Hosting,
			Connected,
			Disconnected,
			DataRecived
		}
		public static string Status { get; internal set; }
		public static void ChangeStatus(Statuses status)
		{
			switch (status)
			{
				default:
					Status = "Server Status: Not Hosting or Connected to server";
					break;
				case Statuses.Default:
					Status = "Server Status: Not Hosting or Connected to server";
					break;
				case Statuses.Hosting:
					Status = "Server Status: Hosting a Server";
					break;
				case Statuses.Connected:
					Status = "Server Status: Connected to Server";
					break;
				case Statuses.Disconnected:
					Status = "Server Status: Disconnected from Server";
					break;
				case Statuses.DataRecived:
					Status = "Server Status: Data recieved from Server";
					break;
			}
		}
	}
}
