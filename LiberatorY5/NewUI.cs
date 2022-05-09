using System;
using System.ComponentModel;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Memory;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiberatorY5
{
    public partial class NewUI : MaterialForm
    {
        #region Variables
        static private Mem m = new();
        static private rpc rpc = new();
        static private Season_Addon SA = new();
        static bool procOpen = false;
        static readonly string r6processname = "RainbowSix.exe";
        static readonly string r6mem = "RainbowSix.exe+";
        string events;
        string gamemode;
        string gamemode_parent;
        string mapname;
        string ConnectToIP = null;
        static string FulllbuildID;
        public static long house = 0;
        public static long hostage = 0;
        public static long easy = 0;
        public static long day = 0;
        public static int IsHost = 0;
        public static int InMatch = 0;
        public static byte eventHostBool = 0;
        public static string HandleMap;
        public static string HandleMode;
        public static string HandleSpecial;
        public static string HandleDiff;
        public static bool HandleDay;
        public static int HandleSA_ver = -1;
        public static bool ClientConnected = false;
        public static bool ClientRecieved_Playlist = false;
        public static bool IsUsingNetwork = false;
        public static bool AutoJoin = false;
        bool itWasAHost = false;
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
                    if (SA.ConnectedIP != "") //Using this magic to not auto connect, and read incorrect things
                    {
                        ConnectToIP = GlobalStuff.LongToIP(m.ReadLong(r6mem + SA.ConnectedIP));
                    }
                    if (SA.InHost != "")
                        IsHost = m.ReadByte(r6mem + SA.InHost);
                    if (SA.InMatch != "")
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
                SMWrong.Text = "Something is wrong with:";
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
            BuildIDCheck();
            if (!string.IsNullOrWhiteSpace(FulllbuildID))
            {
                treeViewEvents.Nodes.Clear();
                for (int index = 0; index < SA.EventView.Length; index++)
                {
                    var item = SA.EventView[index];
                    var item2 = SA.EventView_Tag[index];
                    treeViewEvents.Nodes.Add(item);
                    treeViewEvents.Nodes[index].Tag = item2;
                }
                if (SA.FuillBuildID == "Y5S4.2.0_C5914517_D1181197_S40892_15241382")
                {
                    if (treeViewMap.Nodes.ContainsKey("NodeOldHouse")) { treeViewMap.Nodes.Find("NodeOldHouse", true)[0].Remove(); }
                    treeViewMap.Nodes.Insert(12, "NodeOldHouse", "House (Old)").Tag = "oldhouse";
                    treeViewMap.EndUpdate();
                }
                if (SA.FuillBuildID == "Y5S3.3.1_C5789341_D1135607_S40332_15018155")
                {
                    byte[] buffer3 = new byte[4] { 65, 180, 0, 144 }; //65 128 244 1 69 8 231 116 14 131
                    m.WriteBytes(r6mem + "3843080", buffer3);
                }
            }
        }
        private static string BuildIDCheck()
        {
            string version = null;
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
                version = m.ReadString(r6mem + DemonVeil_Release.BuildID_Check, "", 42, true);
                if (version == DemonVeil_Release.FuillBuildID) { FulllbuildID = version; }

                if (!string.IsNullOrWhiteSpace(FulllbuildID))
                {
                    logs.WriteLog("Game Build ID: " + FulllbuildID);
                    rpc.ChangeAssetByVersion(FulllbuildID);
                    SA.Seasons_Changer(FulllbuildID);
                    SA.SetInternal();
                    if (SA.house_Offset != "")
                        house = m.ReadLong(r6mem + SA.house_Offset, "");
                    if (SA.hostage_Offset != "")
                        hostage = m.ReadLong(r6mem + SA.hostage_Offset, "");
                    if (SA.easyDifficulty_Offset != "")
                        easy = m.ReadLong(r6mem + SA.easyDifficulty_Offset, "");
                    if (SA.day_Offset != "")
                        day = m.ReadLong(r6mem + SA.day_Offset, "");
                    logs.WriteLog("House: " + house.ToString() + " Hostage: " + hostage.ToString() + " Easy:" + easy.ToString() + " Day:" + day.ToString());
                }
            }
            return version;
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
                logs.WriteLog("Gamemode Selected: " + gamemode + " " + gamemode_parent);
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
                logs.WriteLog("Map Selected: " + mapname);
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
                logs.WriteLog("Event Selected: " + events);
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
        private void AutoJoinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AutoJoin = AutoJoinCheckBox.Checked;
            logs.WriteLog("AutoJoin Set to: " + AutoJoin);
        }
        #endregion
        #region Memory editing!

        #region Re-Reading
        private void re_readButton_Click(object sender, EventArgs e)
        {
            Once_BuildID();
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
                if (SA.house_Offset != "")
                    house = m.ReadLong(r6mem + SA.house_Offset, "");
                if (SA.hostage_Offset != "")
                    hostage = m.ReadLong(r6mem + SA.hostage_Offset, "");
                if ( SA.easyDifficulty_Offset != "")
                    easy = m.ReadLong(r6mem + SA.easyDifficulty_Offset, "");
                if (SA.day_Offset != "")
                    day = m.ReadLong(r6mem + SA.day_Offset, "");
                if (SA.FuillBuildID == "Y5S4.2.0_C5914517_D1181197_S40892_15241382")
                {
                    if (treeViewMap.Nodes.ContainsKey("NodeOldHouse")) { treeViewMap.Nodes.Find("NodeOldHouse", true)[0].Remove(); }
                    treeViewMap.Nodes.Insert(12,"NodeOldHouse", "House (Old)").Tag = "oldhouse";
                    treeViewMap.EndUpdate();
                }
                logs.WriteLog("[RE] House: " + house.ToString() + " Hostage: " + hostage.ToString() + " Easy:" + easy.ToString() + " Day:" + day.ToString());
                LabelUpdate.Text = "Reading addresses again!";
            }
        }
        private void RDayButton_Click(object sender, EventArgs e)
        {
            day = m.ReadLong(r6mem + SA.r6_daynight, "");
            logs.WriteLog("Newly read Day value: " + day);
        }
        private void RDiffButton_Click(object sender, EventArgs e)
        {
            easy = m.ReadLong(r6mem + SA.r6_difficulty, "");
            logs.WriteLog("Newly read Easy value: " + easy);
        }
        private void RMapButton_Click(object sender, EventArgs e)
        {
            house = m.ReadLong(r6mem + SA.r6_map, "");
            logs.WriteLog("Newly read House value: " + house);
        }
        private void RGModeButton_Click(object sender, EventArgs e)
        {
            hostage = m.ReadLong(r6mem + SA.r6_gamemode, "");
            logs.WriteLog("Newly read Hostage value: " + hostage);
        }
        #endregion

        private void sendtoR6Button_Click(object sender, EventArgs e)
        {
            if (procOpen)
            {
                if (SA.SeasonVersion != -1)
                {
                    ClientRecieved_Playlist = false;

                    if (events == null)
                    {
                        SA.ParentParser(gamemode, gamemode_parent, mapname, out string mode, out string diff, out string map);
                        HandleMap = map;
                        HandleMode = mode;
                        HandleDiff = diff;
                        
                    }
                    else
                    {
                        HandleMap = null;
                        HandleMode = null;
                        HandleDiff = null;
                    }
                    HandleSpecial = events;
                    HandleSA_ver = SA.SeasonVersion;

                    NetworkManagement.SendPlaylistLoop(HandleMap, HandleMode, events, HandleDiff, SA.SeasonVersion);
                    logs.WriteLog($"[PLAYLISTDATA] Sent: Map {HandleMap}, Mode {HandleMode}, Difficulty {HandleDiff}, Event {events}, Version {SA.SeasonVersion}");
                    WritePlayList(m, SA);

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
                SMWrong.Text = "Something is wrong with:";
            }
        }
        private void daynightCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen)
            {
                if (SA.SeasonVersion != -1)
                {
                    ClientRecieved_Playlist = false;

                    HandleSA_ver = SA.SeasonVersion;
                    NetworkManagement.SendDayData(daynightCheckbox.Checked, HandleSA_ver);
                    logs.WriteLog($"[DAYDATA] Sent: Day or Night(0 is Day, 1 is Night) {daynightCheckbox.Checked}, Version {SA.SeasonVersion}");
                    WritePlayList(m, SA);


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
                SMWrong.Text = "Something is wrong with:";
            }

        }
        private void randomButton_Click(object sender, EventArgs e)
        {
            if (SA.SeasonVersion != -1)
            {
                SA.ParentParser("Random", "Random", mapname, out string mode, out string diff, out string map);
                HandleMap = map;
                HandleMode = mode;
                HandleDiff = diff;
                NetworkManagement.SendPlaylistLoop(mode, mode, null, diff, SA.SeasonVersion);
                WritePlayList(m, SA);
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
        #region Handles
        public static void HandlePlaylistData(PlaylistNetworkData Data)
        {
            HandleMap = Data.Map;
            HandleMode = Data.Gamemode;
            HandleSpecial = Data.EventMode;
            HandleSA_ver = Data.SAVersion;
            HandleDiff = Data.Difficulty;
            ClientRecieved_Playlist = true;
            logs.WriteLog("[PLAYLISTDATA] Recieved: " + HandleMap + " " + HandleMode + " " + HandleSpecial + " " + HandleDiff + " " + HandleSA_ver);
            HostStatus.ChangeStatus(HostStatus.Statuses.DataRecieved);
            WritePlayList(m,SA);
        }
        public static void HandleDayData(DayData Data)
        {
            HandleDay = Data.IsDay;
            HandleSA_ver = Data.SAVersion;
            ClientRecieved_Playlist = true;
            logs.WriteLog("[DAYDATA] Recieved: " + HandleDay + " " + HandleSA_ver);
            HostStatus.ChangeStatus(HostStatus.Statuses.DataRecieved);
            WriteDayData(m, SA);
        }
        public static void HandleExitData(ExitMessage Data)
        {
            IsUsingNetwork = false;
            ClientConnected = false;
            NetworkManagement.StatusPublic = Data.status;
            HostStatus.ChangeStatus(Data.status);
        }
        public static void HandleUnknownData(NetworkMessage Data)
        {
            logs.WriteLog("UNKNOWNDATA\n " + Data.ToString()  + "\n" + Data.MessageData.ToString());
        }
        #endregion
        private void IP_Label_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(NetworkManagement.RadminHostIp);
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (eventHostBool == 1)
            {
                IsUsingNetwork = false;
                eventHostBool = 0;
                connectedPlayers.Items.Clear();
                NetworkManagement.StopServer();
            }
            else
            {
                IsUsingNetwork = true;
                eventHostBool = 1;
                NetworkManagement.StartServer(connectedPlayers);
            }
        }
        private void JoinButton_Click(object sender, EventArgs e)
        {
            if (IsHost==1) { return; }
            if (ClientConnected == false)
            {
                if (string.IsNullOrWhiteSpace(ConnectToIP)) { ConnectToIP = ipBox.Text; }
                IsUsingNetwork = true;
                if (string.IsNullOrWhiteSpace(nameBox.Text)) { nameBox.Text = Environment.UserName; }
                string usernameInGame = nameBox.Text;
                NetworkManagement.CloseClientConnection();
                NetworkManagement.ConnectServer(ConnectToIP, usernameInGame);
            }
            else
            {
                SoonLabel.Text = "Client already connected";
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
        private void timer_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FulllbuildID))
            {
                if (SA.ConnectedIP != "") //Using this magic to not auto connect, and read incorrect things
                {
                    ConnectToIP = GlobalStuff.LongToIP(m.ReadLong(r6mem + SA.ConnectedIP));
                }

                if (SA.InHost != "")
                    IsHost = m.ReadByte(r6mem + SA.InHost);
                if (SA.InMatch != "")
                    InMatch = m.ReadByte(r6mem + SA.InMatch);

                if (SA.FuillBuildID == "Y5S3.3.1_C5789341_D1135607_S40332_15018155")
                {
                    int checklumaply = m.ReadByte(r6mem + "5B2CFB8"); //killing lumaplay, prevent shadow copy
                    if (checklumaply == 1)
                    {
                        m.CloseProcess();
                        logs.WriteLog("Game shutted down, lumaplay still up");
                        MessageBox.Show("Your Game is not completly closed!\nPlease exit or kill your game! (TASKKILL.EXE /IM RainbowSix.exe /F)");
                        //Process[] ps = Process.GetProcessesByName(r6processname);

                        //foreach (Process p in ps)
                            //p.Kill();
                    }
                }
                //Check for if anything null, reread it
                if (house == 0 && SA.house_Offset != "")
                {
                    house = m.ReadLong(r6mem + SA.house_Offset, "");
                    logs.WriteLog("House was 0, now new House: " + house);
                }

                if (hostage == 0 && SA.hostage_Offset != "")
                {
                    hostage = m.ReadLong(r6mem + SA.hostage_Offset, "");
                    logs.WriteLog("Hostage was 0, now new Hostage: " + hostage);
                }

                if (easy == 0 && SA.easyDifficulty_Offset != "")
                {
                    easy = m.ReadLong(r6mem + SA.easyDifficulty_Offset, "");
                    logs.WriteLog("Easy was 0, now new Easy: " + easy);
                }

                if (day == 0 && SA.day_Offset != "")
                {
                    day = m.ReadLong(r6mem + SA.day_Offset, "");
                    logs.WriteLog("Day was 0, now new Day: " + day);
                }

                if (day == 0) { if (!SMWrong.Text.Contains("Day")) { SMWrong.Text += "\nDay"; } }
                if (house == 0) { if (!SMWrong.Text.Contains("Map")) { SMWrong.Text += "\nMap"; } }
                if (hostage == 0) { if (!SMWrong.Text.Contains("GameMode")) { SMWrong.Text += "\nGameMode"; } }
                if (easy == 0) { if (!SMWrong.Text.Contains("Difficulty")) { SMWrong.Text += "\nDifficulty"; } }

                if (AutoJoin == true)
                {
                    if (InMatch >= 1)
                    {
                        if (IsHost >= 1)
                        {
                            if (NetworkManagement.server == null)
                            {
                                NetworkManagement.StartServer(connectedPlayers);
                                itWasAHost = true;
                            }
                        }
                        else
                        {
                            if (ConnectToIP != null)
                            {
                                if (ClientConnected == false)
                                {
                                    NetworkManagement.ConnectServer(ConnectToIP, Environment.UserName);
                                    itWasAHost = false;
                                }
                            }
                            else
                            {
                                SoonLabel.Text = "The IP is null or not found! Not be able auto connect!";
                            }
                        }
                    }
                    else
                    {
                        if (itWasAHost)
                        {
                            if (NetworkManagement.server != null)
                            {
                                NetworkManagement.StopServer();
                            }
                        }
                        else
                        {
                            if (NetworkManagement.client != null)
                            {
                                NetworkManagement.CloseClientConnection();
                            }
                        }
                    }
                }
            }
        }
        public static void WritePlayList(Mem mem, Season_Addon season_addon)
        {
            //Returning if something goes wrong
            bool OpenedInVoid = false;
            if (mem == null) return;
            if (season_addon == null) return;
            if (procOpen == false) { procOpen = mem.OpenProcess(r6processname); OpenedInVoid = true;  }

            if (OpenedInVoid)
            {
                logs.WriteLog("Opened!");
                BuildIDCheck();
                //Setting internal parameters
                season_addon.Seasons_Changer(FulllbuildID);
                season_addon.SetInternal();
            }

            if (string.IsNullOrWhiteSpace(FulllbuildID)) return;

            if (ClientRecieved_Playlist)
            {
                logs.WriteLog("Your Version: " + season_addon.SeasonVersion + " Server Sent version: " + HandleSA_ver);
                if (season_addon.SeasonVersion != HandleSA_ver)
                {
                    NetworkManagement.StatusPublic = HostStatus.Statuses.Disconnected_Version;
                    if (ClientConnected)
                    {
                        ClientConnected = false;
                        NetworkManagement.CloseClientConnection();
                    } 
                    return;
                }
            }

            //Discord RPC
            if (!IsUsingNetwork)
            {
                if (HandleMap != null && HandleMode != null)
                {
                    rpc.client.UpdateState(HandleMap + " - " + HandleMode);
                }
                if (HandleSpecial != null)
                {
                    rpc.client.UpdateState("Event: " + HandleSpecial);
                }
            }
            else
            {
                if (HandleMap != null && HandleMode != null)
                {
                    if (IsHost == 1)
                    {
                        rpc.client.UpdateState(HandleMap + " - " + HandleMode + " (Host)");
                    }
                    else
                    {
                        rpc.client.UpdateState(HandleMap + " - " + HandleMode + " (Client)");
                    }
                }
                if (HandleSpecial != null)
                {
                    if (IsHost == 1)
                    {
                        rpc.client.UpdateState("Event: " + HandleSpecial + " (Host)");
                    }
                    else
                    {
                        rpc.client.UpdateState("Event: " + HandleSpecial + " (Client)");
                    }
                }
            }

            //Writing
            if (season_addon.SeasonVersion == HandleSA_ver)
            {
                if (HandleMap != null)
                {
                    season_addon.MapConverter(HandleMap, house, out long output_map);
                    if (output_map != 0L)
                    {
                        mem.WriteMemory(r6mem + season_addon.r6_map, "long", output_map.ToString(), "", null);
                    }
                }
                if (HandleSpecial != null)
                {
                    season_addon.EventConverter(HandleSpecial, house, hostage, out long output_map, out long output_gamemode);
                    if (output_map != 0L | output_gamemode != 0L)
                    {
                        mem.WriteMemory(r6mem + season_addon.r6_map, "long", output_map.ToString(), "", null);
                        mem.WriteMemory(r6mem + season_addon.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                    }
                }
                if (HandleMode != null)
                {
                    season_addon.GameModeConverter(HandleMode, HandleDiff, hostage, easy, out long output_gamemode, out long difficulty);
                    if (output_gamemode != 0L)
                    {
                        mem.WriteMemory(r6mem + season_addon.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                        mem.WriteMemory(r6mem + season_addon.r6_difficulty, "long", difficulty.ToString(), "", null);
                    }
                }
            }

            if (OpenedInVoid)
            {
                mem.CloseProcess();
            }
        }
        public static void WriteDayData(Mem mem, Season_Addon season_addon)
        {
            //Returning if something goes wrong
            bool OpenedInVoid = false;
            if (mem == null) return;
            if (season_addon == null) return;
            if (procOpen == false) { procOpen = mem.OpenProcess(r6processname); OpenedInVoid = true; }

            if (OpenedInVoid)
            {
                logs.WriteLog("Opened!");
                BuildIDCheck();
                //Setting internal parameters
                season_addon.Seasons_Changer(FulllbuildID);
                season_addon.SetInternal();
            }

            if (string.IsNullOrWhiteSpace(FulllbuildID)) return;

            if (ClientRecieved_Playlist)
            {
                logs.WriteLog("Your Version: " + season_addon.SeasonVersion + " Server Sent version: " + HandleSA_ver);
                if (season_addon.SeasonVersion != HandleSA_ver)
                {
                    NetworkManagement.StatusPublic = HostStatus.Statuses.Disconnected_Version;
                    if (ClientConnected)
                    {
                        ClientConnected = false;
                        NetworkManagement.CloseClientConnection();
                    }
                    return;
                }
            }

            //Writing
            if (season_addon.SeasonVersion == HandleSA_ver)
            {
                GlobalStuff.DayChange(HandleDay,day,out long daynight);
                mem.WriteMemory(r6mem + season_addon.r6_daynight, "long", daynight.ToString(), "", null);
            }

            if (OpenedInVoid)
            {
                mem.CloseProcess();
            }
        }
        #endregion
        #region ForgeSwap
        //  If Needed I Upload this section, all things is on SlejmSaved.txt (That are not showed on Github) [KEYBASE PRIVATE]
        #endregion
    }
}
