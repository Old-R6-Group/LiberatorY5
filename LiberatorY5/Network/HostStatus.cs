namespace LiberatorY5
{
    public class HostStatus
    {
		public enum Statuses
		{
			Default,
			Hosting,
			Connected,
			Disconnected
		}
		public static string StatusBack { get; internal set; }
		public static void HostStatusString(Statuses status)
		{
			switch (status)
			{
				default:
					StatusBack = "Server Status: Not Hosting or Connected to server";
					break;
				case Statuses.Default:
					StatusBack = "Server Status: Not Hosting or Connected to server";
					break;
				case Statuses.Hosting:
					StatusBack = "Server Status: Hosting a Server";
					break;
				case Statuses.Connected:
					StatusBack = "Server Status: Connected to Server";
					break;
				case Statuses.Disconnected:
					StatusBack = "Server Status: Disconnected from Server";
					break;
			}
		}
	}
}
