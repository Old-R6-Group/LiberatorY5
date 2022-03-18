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

		public int SAVersion;

		public string GameModeParent;

		public PlaylistNetworkData(string Map, string Gamemode, string eventmode, string eventparent, int sa_version)
		{
			this.Map = Map;
			this.Gamemode = Gamemode;
			this.EventMode = eventmode;
			this.SAVersion = sa_version;
			this.GameModeParent = eventparent;
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
