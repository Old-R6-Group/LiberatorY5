using System;

namespace LiberatorY5
{
	[Serializable]
	public class NetworkMessage
	{
		public object MessageData;

		public NetworkMessage(object MessageData)
		{
			this.MessageData = MessageData;
		}
	}

	[Serializable]
	public class PlaylistNetworkData
	{
		public string Map;

		public string Gamemode;

		public string EventMode;

		public PlaylistNetworkData(string Map, string Gamemode, string eventmode)
		{
			this.Map = Map;
			this.Gamemode = Gamemode;
			this.EventMode = eventmode;
		}
	}

	[Serializable]
	public class ExitMessage
	{
		public HostStatus.Statuses status;
		public bool ClientDisconneted;

		public ExitMessage(HostStatus.Statuses statusData, bool clientdisc)
		{
			this.status = statusData;
			this.ClientDisconneted = clientdisc;
		}
	}
}
