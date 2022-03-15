using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberatorY5
{
    public class rpc
    {
        public DiscordRpcClient client;
		public void Initialize()
		{
			client = new DiscordRpcClient("952188687737831484");

			client.Initialize();

			client.SetPresence(new RichPresence()
			{
				Details = "Liberator Reloaded!",
				State = "Waiting for a game",
				Timestamps = Timestamps.Now,
				Assets = new Assets()
				{
					LargeImageKey = "base",
					LargeImageText = "Secret"
				}
			});
		}
		public void ChangeAssetByVersion(string verison)
		{
			if (string.IsNullOrWhiteSpace(verison))
			{
				client.UpdateDetails("Game Launching...");
				client.UpdateLargeAsset("base", "Launching");
				return;

			}
			client.UpdateState("Game Launching...");
			switch (verison)
			{
				case "Y5S1.2.0.1_C5183038_D967006_S37789_14303219": //VE Shey
					client.UpdateDetails("Playing Void Edge Shey Version");
					client.UpdateLargeAsset("grandlarceny", "Void Edge Shey");
					return;
				case "Y5S1.2.0.2_C5218952_D973190_S37789_14335319": //VE MU
					client.UpdateDetails("Playing Void Edge MU Version");
					client.UpdateLargeAsset("voidedge", "Void Edge MU");
					return;
				case "Y5S2.3.1.1pc_C5493616_D1043836_S38774_14664131": //Steel wave
					client.UpdateDetails("Playing Steel Wave Version");
					client.UpdateLargeAsset("steelwave", "Steel Wave");
					return;
				case "Y5S3.3.1_C5789341_D1135607_S40332_15018155": //SL Global
					client.UpdateDetails("Playing Shadow Legacy Global Version");
					client.UpdateLargeAsset("telly", "Shadow Legacy Global");
					return;
				case "Y5S3.3.1_C5789341_D1135232321155": //SL Event
					client.UpdateDetails("Playing Shadow Legacy Event Version");
					client.UpdateLargeAsset("shadowlegacy", "Shadow Legacy Event");
					return;
				case "Y5S4.2.0_C5914517_D1181197_S40892_15241382": //Neon event
					client.UpdateDetails("Playing Neon Dawn Event Version");
					client.UpdateLargeAsset("snowball", "Neon Dawn Event");
					return;
				default:
					client.UpdateDetails("Version is not supported?");
					client.UpdateLargeAsset("base", "No Idea");
					return;
			}
		}
	}
}
