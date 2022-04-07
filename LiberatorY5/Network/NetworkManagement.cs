using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using SimpleTcp;

namespace LiberatorY5
{
    public class NetworkManagement
    {
		public static string RadminHostIp;

		public static SimpleTcpServer server = null;

		public static SimpleTcpClient client = null;

		public static Dictionary<string, string> IPS = new Dictionary<string, string>();

		private static ListBox connectedplayerList;
		public static HostStatus.Statuses StatusPublic;

		public static void SendPlaylistLoop(string Map, string Gamemode, string Events,string difficulty,int sa_version)
		{
			if (NewUI.InMatch == 1)
			{
				string[] ip_keys = IPS.Keys.ToArray();
				NetworkMessage playlist_data = new NetworkMessage(new PlaylistNetworkData(Map, Gamemode, Events, difficulty, sa_version));
				foreach (string ip in ip_keys)
				{
					server.Send(ip, ObjectToByteArray(playlist_data));
				}
			}
		}
		public static void SendDayData(bool day, int sa_version)
		{
			if (NewUI.InMatch == 1)
			{
				string[] ip_keys = IPS.Keys.ToArray();
				NetworkMessage day_data = new NetworkMessage(new DayData(day, sa_version));
				foreach (string ip in ip_keys)
				{
					server.Send(ip, ObjectToByteArray(day_data));
				}
			}
		}
		public static void SendUnknown(object uknown)
		{
			string[] ip_keys = IPS.Keys.ToArray();
			NetworkMessage unknowndata = new NetworkMessage(uknown);
			foreach (string ip in ip_keys)
			{
				server.Send(ip, ObjectToByteArray(unknowndata));
			}
		}

		public static void SendDisconnect(string ip)
		{
			NetworkMessage playlist_data = new NetworkMessage(new ExitMessage(HostStatus.Statuses.Disconnected_Kicked, false));
			server.Send(ip, ObjectToByteArray(playlist_data));
		}

		public static void StartServer(ListBox playerlist)
		{
			if (server == null || !server.IsListening)
			{
				connectedplayerList = playerlist;
				server = new SimpleTcpServer(RadminHostIp + ":5000");
				server.Events.ClientDisconnected += (sender, args) => Server_ClientDisconnected(sender, args);
				server.Events.DataReceived += (sender, args) => Server_DataReceived(sender, args);
				server.Start();
				HostStatus.ChangeStatus(HostStatus.Statuses.Hosting);
			}
		}

		public static void StopServer()
		{
			if (server != null && server.IsListening)
			{
				server.Stop();
				HostStatus.ChangeStatus(HostStatus.Statuses.Shutdown);
			}
		}

		public static void CloseClientConnection()
		{
			if (client != null && client.IsConnected)
			{
				client.Disconnect();
				NewUI.ClientConnected = false;
			}
		}

		public static void ConnectServer(string ConnectToIP, string username)
		{
			client = new SimpleTcpClient(ConnectToIP + ":5000");
			client.Events.Disconnected += (sender, args) => Client_Disconnected(sender, args);
			client.Events.DataReceived += (sender, args) => Client_DataReceived(sender, args);
			try
			{
				client.Connect();
				client.Send(username);
				HostStatus.ChangeStatus(HostStatus.Statuses.Connected);
				NewUI.ClientConnected = true;
			}
			catch
			{
				HostStatus.ChangeStatus(HostStatus.Statuses.Disconnected);
				NewUI.ClientConnected = false;
			}
		}

		public static void DisconnectClient(string name)
		{
			var ip = IPS.Where(x => x.Value == name).FirstOrDefault().Key;
			SendDisconnect(ip);
			server.DisconnectClient(ip);
		}

		public static void GetIP()
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(Dns.GetHostName());
			foreach (IPAddress iPAddress in hostAddresses)
			{
				if (iPAddress.ToString().Substring(0, 2) == "26")
				{
					RadminHostIp = iPAddress.ToString();
				}
			}
		}

		//	Client/Serer stuff
		private static void Client_Disconnected(object sender, EventArgs e)
		{
			if (NewUI.IsHost==0)
			{
				HostStatus.ChangeStatus(StatusPublic);
			}
		}

		private static void Client_DataReceived(object sender, DataReceivedEventArgs e)
		{
			NetworkMessage networkMessage = (NetworkMessage)ByteArrayToObject(e.Data);
			object messageData = networkMessage.MessageData;
			switch (messageData)
			{
				default:
					NewUI.HandleUnknownData((NetworkMessage)networkMessage.MessageData);
					return;
                case PlaylistNetworkData:
					NewUI.HandlePlaylistData((PlaylistNetworkData)networkMessage.MessageData);
					return;
				case ExitMessage:
					NewUI.HandleExitData((ExitMessage)networkMessage.MessageData);
					return;
				case NetworkMessage:
					NewUI.HandleUnknownData((NetworkMessage)networkMessage.MessageData);
					return;
				case DayData:
					NewUI.HandleDayData((DayData)networkMessage.MessageData);
					return;

			}
		}

		private static void Server_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
		{
			connectedplayerList.Items.Remove(IPS[e.IpPort]);
			IPS.Remove(e.IpPort);
		}

		private static void Server_DataReceived(object sender, DataReceivedEventArgs e)
		{
			IPS.Add(e.IpPort, Encoding.UTF8.GetString(e.Data));
			connectedplayerList.Items.Add(IPS[e.IpPort]);
		}
		public static byte[] ObjectToByteArray(object obj)
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			using MemoryStream memoryStream = new MemoryStream();
			binaryFormatter.Serialize(memoryStream, obj);
			return memoryStream.ToArray();
		}

		public static object ByteArrayToObject(byte[] arrBytes)
		{
			using MemoryStream memoryStream = new MemoryStream();
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			memoryStream.Write(arrBytes, 0, arrBytes.Length);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			try
			{
				return binaryFormatter.Deserialize(memoryStream);
			}
			catch
			{
				return null;
			}
		}
	}
}
