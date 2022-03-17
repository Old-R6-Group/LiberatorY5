using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using SimpleTcp;

namespace LiberatorY5
{
    public class NetworkManagement
    {
		private static string RadminHostIp = NewUI.HostIp;

		private static SimpleTcpServer server;

		private static SimpleTcpClient client;

		public static Dictionary<string, string> IPS = new Dictionary<string, string>();

		private static ListBox connectedplayerList;

		public static Action<HostStatus.Statuses> HostStatusChange;

		public static void SendPlaylistLoop(string Map, string Gamemode, string Events)
		{
			if (NewUI.eventHostBool == 1)
			{
				string[] ip_keys = IPS.Keys.ToArray();
				NetworkMessage playlist_data = new NetworkMessage(new PlaylistNetworkData(Map, Gamemode, Events));
				foreach (string ip in ip_keys)
				{
					server.Send(ip, ObjectToByteArray(playlist_data));
				}
			}
		}

		public static void SendDisconnect(string ip)
		{
			NetworkMessage playlist_data = new NetworkMessage(new ExitMessage(HostStatus.Statuses.Disconnected, false));
			server.Send(ip, ObjectToByteArray(playlist_data));
		}

		public static void StartServer(ListBox playerlist)
		{
			RadminHostIp = NewUI.HostIp;
			if (server == null || !server.IsListening)
			{
				connectedplayerList = playerlist;
				server = new SimpleTcpServer(RadminHostIp + ":9000");
				server.Events.ClientDisconnected += (sender, args) => SClientDisconnected(sender, args);
				server.Events.DataReceived += (sender, args) => SDataReceived(sender, args);
				server.Start();
				HostStatusChange(HostStatus.Statuses.Hosting);
			}
		}

		public static void StopServer()
		{
			if (server != null && server.IsListening)
			{
				server.Stop();
				HostStatusChange(HostStatus.Statuses.Disconnected);
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
			client = new SimpleTcpClient(ConnectToIP + ":9000");
			client.Events.Disconnected += (sender, args) => CDisconnected(sender, args);
			client.Events.DataReceived += (sender, args) => CDataReceived(sender, args);
			try
			{
				client.Connect();
				client.Send(username);
				HostStatusChange(HostStatus.Statuses.Connected);
				NewUI.ClientConnected = true;
			}
			catch
			{
				HostStatusChange(HostStatus.Statuses.Disconnected);
				NewUI.ClientConnected = false;
			}
		}


		public static void DisconnectClient(string name)
		{
			var ip = IPS.Where(x => x.Value == name).FirstOrDefault().Key;
			SendDisconnect(ip);
			server.DisconnectClient(ip);
		}


		private static void CDisconnected(object sender, EventArgs e)
		{
			if (NewUI.IsHost == false)
			{
				HostStatusChange(HostStatus.Statuses.Disconnected);
			}
		}

		private static void CDataReceived(object sender, DataReceivedEventArgs e)
		{
			NetworkMessage networkMessage = (NetworkMessage)ByteArrayToObject(e.Data);
			object messageData = networkMessage.MessageData;
			if (messageData is PlaylistNetworkData)
			{
				//NewUI.HandlePlaylistData((PlaylistNetworkData)networkMessage.MessageData);
			}
			if (messageData is ExitMessage)
			{
				//NewUI.HandleExitData((ExitMessage)networkMessage.MessageData);
			}
		}

		private static void SClientDisconnected(object sender, ClientDisconnectedEventArgs e)
		{
			connectedplayerList.Items.Remove(IPS[e.IpPort]);
			IPS.Remove(e.IpPort);
		}

		private static void SDataReceived(object sender, DataReceivedEventArgs e)
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
