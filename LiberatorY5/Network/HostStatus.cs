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
			Disconnected_Kicked,
			Disconnected_Version,
			Disconnected_Unknown,
			DataRecieved,
			Shutdown
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
				case Statuses.DataRecieved:
					Status = "Server Status: Data recieved from Server";
					break;
				case Statuses.Disconnected_Version:
					Status = "Server Status: Disconnected from Server (Version Mismatch)";
					break;
				case Statuses.Disconnected_Kicked:
					Status = "Server Status: Disconnected from Server (Kicked by Server)";
					break;
				case Statuses.Disconnected_Unknown:
					Status = "Server Status: Disconnected from Server (Unknown Reason)";
					break;
				case Statuses.Shutdown:
					Status = "Server Status: Server is shutted down";
					break;
			}
		}
	}
}
