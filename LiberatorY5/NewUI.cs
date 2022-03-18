using System;
using System.ComponentModel;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Memory;
using System.Threading;
using System.Linq;
using System.Diagnostics;

namespace LiberatorY5
{
    public partial class NewUI : MaterialForm
    {
        #region Variables
        private Mem m = new();
        private Random random = new();
        private rpc rpc = new();
        private Season_Addon SA = new();
        bool procOpen = false;
        readonly string r6processname = "RainbowSix.exe";
        readonly string r6mem = "RainbowSix.exe+";
        string events;
        string gamemode;
        string gamemode_parent;
        string mapname;
        string FulllbuildID;
        public static long house = long.MaxValue;
        public static long hostage = long.MaxValue;
        public static long easy = long.MaxValue;
        public static long day = long.MaxValue;
        public static bool ClientConnected = false;
        public static int IsHost = 0;
        public static int InMatch;
        public static byte eventHostBool = 0;
        string ConnectToIP;
        #endregion
        #region Load + Hooking
        public NewUI()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void NewUI_Load(object sender, EventArgs e)
        {
            versionLabel.Text = "Version: " + Stuff.Version;
            rpc.Initialize();
            HostStatus.ChangeStatus(HostStatus.Statuses.Default);
            NetworkManagement.GetIP();
            if (NetworkManagement.RadminHostIp == "")
            {
                MessageBox.Show("Please Install Radmin VPN to use server capability");
            }
            IP_Label.Text = "Your IP: " + NetworkManagement.RadminHostIp;
            StatusLabel.Text = HostStatus.Status;
        }
        private void NewUI_Shown(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync(e);
        }
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            StatusLabel.Text = HostStatus.Status;
            procOpen = m.OpenProcess(r6processname, out string fail);
            //logs.WriteLog(fail);
            if (!procOpen)
            {
                LabelUpdate.Text = "Can't find siege. Make sure Battleye is disabled and the game is at the main menu!";
                FulllbuildID = null;
                rpc.client.UpdateDetails("Liberator Reloaded!");
                rpc.client.UpdateState("Waiting for a game!");
                rpc.client.UpdateLargeAsset("base", "Waiting...");
                Thread.Sleep(100);
                return;
            }
            Thread.Sleep(1000);
            backgroundWorker.ReportProgress(0);
        }
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            StatusLabel.Text = HostStatus.Status;
            if (procOpen)
            {
                Once_BuildID();
                if (!string.IsNullOrWhiteSpace(FulllbuildID))
                {
                    
                    LabelUpdate.Text = "Game found: " + FulllbuildID;
                    ConnectToIP = GlobalStuff.LongToIP(m.ReadLong(r6mem + SA.ConnectedIP));
                    IsHost = m.ReadByte(r6mem+ SA.InHost);
                    InMatch = m.ReadByte(r6mem + SA.InMatch);
                    timer.Start();
                }
                else
                {
                    rpc.client.UpdateState("Version Not supported!");
                    LabelUpdate.Text = "This Build is NOT supported! or Currently Reading from your Game";
                }
            }
            else
            {
                LabelUpdate.Text = "Can't find siege. Make sure Battleye is disabled and the game is at the main menu!";
                FulllbuildID = null;
                rpc.client.UpdateDetails("Liberator Reloaded!");
                rpc.client.UpdateState("Waiting for a game!");
                rpc.client.UpdateLargeAsset("base", "Waiting...");
                timer.Stop();
            }
        }
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker.RunWorkerAsync(e);
        }
        private void Once_BuildID()
        {
            string version;
            if (FulllbuildID == null)
            {
                version = m.ReadString(r6mem + VoidEdge_Shey.BuildID_Check, "", 43, true);
                if (version == VoidEdge_Shey.FuillBuildID) { FulllbuildID = version; }
                version = m.ReadString(r6mem + VoidEdge_MU.BuildID_Check, "", 43, true);
                if (version == VoidEdge_MU.FuillBuildID) { FulllbuildID = version; }
                version = m.ReadString(r6mem + SteelWave.BuildID_Check, "", 46, true);
                if (version == SteelWave.FuillBuildID) { FulllbuildID = version; }
                version = m.ReadString(r6mem + ShadowLegacy_Global.BuildID_Check, "", 43, true);
                if (version == ShadowLegacy_Global.FuillBuildID) { FulllbuildID = version; }
                version = m.ReadString(r6mem + NeonDawn_Event.BuildID_Check, "", 43, true);
                if (version == NeonDawn_Event.FuillBuildID) { FulllbuildID = version; }

                if (!string.IsNullOrWhiteSpace(FulllbuildID))
                {
                    logs.WriteLog("Game Build ID: " + FulllbuildID);
                    rpc.ChangeAssetByVersion(FulllbuildID);
                    SA.Seasons_Changer(FulllbuildID);
                    SA.SetInternal();
                    treeViewEvents.Nodes.Clear();
                    for (int index = 0; index < SA.EventView.Length; index++)
                    {
                        var item = SA.EventView[index];
                        var item2 = SA.EventView_Tag[index];
                        treeViewEvents.Nodes.Add(item);
                        treeViewEvents.Nodes[index].Tag = item2;
                    }
                    house = m.ReadLong(r6mem + SA.house_Offset, "");
                    hostage = m.ReadLong(r6mem + SA.hostage_Offset, "");
                    easy = m.ReadLong(r6mem + SA.easyDifficulty_Offset, "");
                    day = m.ReadLong(r6mem + SA.day_Offset, "");
                    if (SA.FuillBuildID == "Y5S4.2.0_C5914517_D1181197_S40892_15241382")
                    {
                        if (treeViewMap.Nodes.ContainsKey("NodeOldHouse")) { treeViewMap.Nodes.Find("NodeOldHouse", true)[0].Remove(); }
                        treeViewMap.Nodes.Add("NodeOldHouse", "Old House").Tag = "oldhouse";
                        treeViewMap.EndUpdate();
                    }
                    logs.WriteLog("House: " + house.ToString() + " Hostage: " + hostage.ToString() + " Easy:" + easy.ToString() + " Day:" + day.ToString());
                } 
            }
        }
        #endregion
        #region UI Changing stuff (Clientmode,treeView)
        private void treeViewGameMode_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewGameMode.SelectedNode.IsSelected)
            {
                labelGameMode.Text = treeViewGameMode.SelectedNode.FullPath;
                gamemode = treeViewGameMode.SelectedNode.Tag.ToString();
                if (treeViewGameMode.SelectedNode.Parent != null)
                {
                    gamemode_parent = treeViewGameMode.SelectedNode.Parent.Tag.ToString();
                }
                else
                {
                    gamemode_parent = treeViewGameMode.SelectedNode.Tag.ToString();
                }
                events = null;
                labelEvent.Text = "Event";
            }
        }
        private void treeViewMap_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewMap.SelectedNode.IsSelected)
            {
                labelMap.Text = treeViewMap.SelectedNode.FullPath;
                mapname = treeViewMap.SelectedNode.Tag.ToString();
                events = null;
                labelEvent.Text = "Event";
            }
        }
        private void treeViewEvents_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewEvents.SelectedNode.IsSelected)
            {
                labelEvent.Text = treeViewEvents.SelectedNode.FullPath;
                events = treeViewEvents.SelectedNode.Tag.ToString();
                mapname = null;
                gamemode = null;
                labelGameMode.Text = "Game Mode";
                labelMap.Text = "Map";
            }
        }
        private void checkBoxClientMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxClientMode.Checked == true && checkBoxClientMode.Enabled == true)
            {
                treeViewGameMode.SelectedNode = null;
                treeViewMap.SelectedNode = null;
                treeViewEvents.SelectedNode = null;
                treeViewGameMode.Visible = false;
                treeViewMap.Visible = false;
                treeViewEvents.Visible = false;
                labelGameMode.Visible = false;
                labelMap.Visible = false;
                labelEvent.Visible = false;
                sendtoR6Button.Visible = false;
                randomButton.Visible = false;
                daynightCheckbox.Visible = false;
                endMatchButton.Visible = false;
                endRoundButton.Visible = false;
            }
            else
            {
                treeViewGameMode.Visible = true;
                treeViewMap.Visible = true;
                treeViewEvents.Visible = true;
                labelGameMode.Visible = true;
                labelMap.Visible = true;
                labelEvent.Visible = true;
                sendtoR6Button.Visible = true;
                randomButton.Visible = true;
                daynightCheckbox.Visible = true;
                endMatchButton.Visible = true;
                endRoundButton.Visible = true;
            }
        }

        #endregion
        #region Memory editing!
        private void re_readButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FulllbuildID))
            {
                SA.SetInternal();
                treeViewEvents.Nodes.Clear();
                for (int index = 0; index < SA.EventView.Length; index++)
                {
                    var item = SA.EventView[index];
                    var item2 = SA.EventView_Tag[index];
                    treeViewEvents.Nodes.Add(item);
                    treeViewEvents.Nodes[index].Tag = item2;
                }
                house = m.ReadLong(r6mem + SA.house_Offset, "");
                hostage = m.ReadLong(r6mem + SA.hostage_Offset, "");
                easy = m.ReadLong(r6mem + SA.easyDifficulty_Offset, "");
                day = m.ReadLong(r6mem + SA.day_Offset, "");
                if (SA.FuillBuildID == "Y5S4.2.0_C5914517_D1181197_S40892_15241382")
                {
                    if (treeViewMap.Nodes.ContainsKey("NodeOldHouse")) { treeViewMap.Nodes.Find("NodeOldHouse", true)[0].Remove(); }
                    treeViewMap.Nodes.Add("NodeOldHouse", "Old House").Tag = "oldhouse";
                    treeViewMap.EndUpdate();
                }
                logs.WriteLog("House: " + house.ToString() + " Hostage: " + hostage.ToString() + " Easy:" + easy.ToString() + " Day:" + day.ToString());
                LabelUpdate.Text = "Reading addresses again!";
            }
        }
        private void sendtoR6Button_Click(object sender, EventArgs e)
        {
            if (procOpen)
            {
                if (mapname != null && gamemode != null)
                {
                    string map = treeViewMap.Nodes.OfType<TreeNode>().FirstOrDefault(node => node.Tag.Equals(mapname)).Text;
                    rpc.client.UpdateState(map + " - " + gamemode);
                }
                if (events != null)
                {
                    string eventname = treeViewEvents.Nodes.OfType<TreeNode>().FirstOrDefault(node => node.Tag.Equals(events)).Text;
                    rpc.client.UpdateState("Event: " + eventname);
                }
                if (SA.SeasonVersion != int.MinValue)
                {
                    NetworkManagement.SendPlaylistLoop(mapname,gamemode,events, gamemode_parent, SA.SeasonVersion);
                    logs.WriteLog("playlist sent");
                    if (mapname != null)
                    {
                        SA.MapConverter(mapname, house, out long output_map);
                        if (output_map != 0L)
                        {
                            m.WriteMemory(r6mem + SA.r6_map, "long", output_map.ToString(), "", null);
                        }
                    }
                    if (events != null)
                    {
                        SA.EventConverter(events, house, hostage, out long output_map, out long output_gamemode);
                        if (output_map != 0L | output_gamemode != 0L)
                        {
                            m.WriteMemory(r6mem + SA.r6_map, "long", output_map.ToString(), "", null);
                            m.WriteMemory(r6mem + SA.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                        }
                    }
                    if (gamemode != null)
                    {
                        SA.GameModeConverter(gamemode, gamemode_parent, house, hostage, easy, out long output_gamemode, out long difficulty, out long outmap);
                        if (output_gamemode != 0L)
                        {
                            m.WriteMemory(r6mem + SA.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                            m.WriteMemory(r6mem + SA.r6_difficulty, "long", difficulty.ToString(), "", null);
                            if (outmap == 0L)
                            {
                                SA.MapConverter(mapname, house, out long output_map);
                                if (output_map != 0L)
                                {
                                    m.WriteMemory(r6mem + SA.r6_map, "long", output_map.ToString(), "", null);
                                }
                            }
                            else
                            {
                                m.WriteMemory(r6mem + SA.r6_map, "long", outmap.ToString(), "", null);
                            }

                        }
                    }
                }
                else
                {
                    LabelUpdate.Text = "Build Currently NOT supported";
                }
            }
            else
            {
                LabelUpdate.Text = "Can't find siege";
                FulllbuildID = null;
            }
        }
        private void daynightCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            long daynight;
            GlobalStuff.DayChange(daynightCheckbox.Checked, day, out daynight);
            m.WriteMemory(r6mem + SA.r6_daynight, "long", daynight.ToString(), "", null);
        }
        private void randomButton_Click(object sender, EventArgs e)
        {
            if (SA.SeasonVersion != -1)
            {
                SA.GameModeConverter("Random", "Random", house, hostage, easy, out long output_gamemode, out long difficulty, out long outmap);
                if (output_gamemode != 0L)
                {
                    m.WriteMemory(r6mem + SA.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                    m.WriteMemory(r6mem + SA.r6_difficulty, "long", difficulty.ToString(), "", null);
                    if (outmap == 0L)
                    {
                        SA.MapConverter(mapname, house, out long output_map);
                        if (output_map != 0L)
                        {
                            m.WriteMemory(r6mem + SA.r6_map, "long", output_map.ToString(), "", null);
                        }
                    }
                    else
                    {
                        m.WriteMemory(r6mem + SA.r6_map, "long", outmap.ToString(), "", null);
                    }
                    GlobalStuff.DayChange((random.Next(2) == 1), day, out long daynight);
                    m.WriteMemory(r6mem + SA.r6_daynight, "long", daynight.ToString(), "", null);
                }
            }
        }
        private void endMatchButton_Click(object sender, EventArgs e)
        {
            if (SA.gamestate == "")
            {
                LabelUpdate.Text = "This version is not support this function!";
            }
            else
            {
                m.WriteMemory(r6mem + SA.gamestate, "int", "3", "", null);
            }
        }
        private void endRoundButton_Click(object sender, EventArgs e)
        {
            if (SA.gamestate == "")
            {
                LabelUpdate.Text = "This version is not support this function!";
            }
            else
            {
                m.WriteMemory(r6mem + SA.gamestate, "int", "3", "", null);
            }
        }
        #endregion
        #region website links
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //added JVAV website
            Process.Start("https://r6downloads.com/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //added website throwback
            Process.Start("http://r6modding.com/");
        }
        #endregion
        #region Network
        public static string HandleMap;
        public static string HandleMode;
        public static string HandleSpecial;
        public static int HandleSA_ver;
        public static string HandleGameModeParent;
        public static void HandlePlaylistData(PlaylistNetworkData Data)
        {
            HandleMap = Data.Map;
            HandleMode = Data.Gamemode;
            HandleSpecial = Data.EventMode;
            HandleSA_ver = Data.SAVersion;
            HandleGameModeParent = Data.GameModeParent;
            logs.WriteLog("[PLAYLISTDATA] " + HandleMap + " " + HandleMode + " " + HandleSpecial + " " + HandleSA_ver + " " + HandleGameModeParent);
            HostStatus.ChangeStatus(HostStatus.Statuses.DataRecived);
        }
        public static void HandleExitData(ExitMessage Data)
        {
            ClientConnected = false;
            HostStatus.ChangeStatus(Data.status);
        }
        public static void HandleUnknownData(NetworkMessage Data)
        {
            logs.WriteLog("UNKNOWNDATA\n " + Data.ToString()  + "\n" + Data.MessageData.ToString());
        }
        private void IP_Label_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(NetworkManagement.RadminHostIp);
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (eventHostBool == 1)
            {
                eventHostBool = 0;
                connectedPlayers.Items.Clear();
                NetworkManagement.StopServer();

            }
            else
            {
                eventHostBool = 1;
                NetworkManagement.StartServer(connectedPlayers);
                

            }
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            if (IsHost==1) { return; }
            if (ClientConnected == false)
            {
                if (ConnectToIP == "0.0.0.0") { ConnectToIP = ipBox.Text; }

                string usernameInGame = textBox1.Text;
                NetworkManagement.ConnectServer(ConnectToIP, usernameInGame);
            }
            else
            {
                label3.Text = "Client already connected";
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            ClientConnected = false;
            NetworkManagement.CloseClientConnection();
            if (eventHostBool == 1)
            {
                eventHostBool = 0;
                connectedPlayers.Items.Clear();
                NetworkManagement.StopServer();

            }
        }

        private void discUserButton_Click(object sender, EventArgs e)
        {
            if (connectedPlayers.SelectedIndex != -1)
            {
                NetworkManagement.DisconnectClient(connectedPlayers.SelectedItem.ToString());
            }
        }
        #endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FulllbuildID))
            {
                ConnectToIP = GlobalStuff.LongToIP(m.ReadLong(r6mem + SA.ConnectedIP));
                IsHost = m.ReadByte(r6mem + SA.InHost);
                InMatch = m.ReadByte(r6mem + SA.InMatch);
                logs.WriteLog(ConnectToIP + " " + IsHost + " " + InMatch);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (HandleMap != null && HandleMode != null)
            {
                string map = treeViewMap.Nodes.OfType<TreeNode>().FirstOrDefault(node => node.Tag.Equals(HandleMap)).Text;
                rpc.client.UpdateState(map + " - " + HandleMode + " (On lan)");
            }
            if (HandleSpecial != null)
            {
                string eventname = treeViewEvents.Nodes.OfType<TreeNode>().FirstOrDefault(node => node.Tag.Equals(HandleSpecial)).Text;
                rpc.client.UpdateState("Event: " + eventname + " (On lan)");
            }
            if (SA.SeasonVersion == HandleSA_ver)
            {
                if (HandleMap != null)
                {
                    SA.MapConverter(HandleMap, house, out long output_map);
                    if (output_map != 0L)
                    {
                        m.WriteMemory(r6mem + SA.r6_map, "long", output_map.ToString(), "", null);
                    }
                }
                if (HandleSpecial != null)
                {
                    SA.EventConverter(HandleSpecial, house, hostage, out long output_map, out long output_gamemode);
                    if (output_map != 0L | output_gamemode != 0L)
                    {
                        m.WriteMemory(r6mem + SA.r6_map, "long", output_map.ToString(), "", null);
                        m.WriteMemory(r6mem + SA.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                    }
                }
                if (HandleMode != null)
                {
                    SA.GameModeConverter(HandleMode, HandleGameModeParent, house, hostage, easy, out long output_gamemode, out long difficulty, out long outmap);
                    if (output_gamemode != 0L)
                    {
                        m.WriteMemory(r6mem + SA.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                        m.WriteMemory(r6mem + SA.r6_difficulty, "long", difficulty.ToString(), "", null);
                        if (outmap == 0L)
                        {
                            SA.MapConverter(HandleMap, house, out long output_map);
                            if (output_map != 0L)
                            {
                                m.WriteMemory(r6mem + SA.r6_map, "long", output_map.ToString(), "", null);
                            }
                        }
                        else
                        {
                            m.WriteMemory(r6mem + SA.r6_map, "long", outmap.ToString(), "", null);
                        }

                    }
                }
            }
        }
    }
}
