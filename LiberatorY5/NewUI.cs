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
        long house = long.MaxValue;
        long hostage = long.MaxValue;
        long easy = long.MaxValue;
        long day = long.MaxValue;
        public static bool ClientConnected = false;
        public static bool IsHost = false;
        public static byte InMatch;
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
        }
        private void NewUI_Shown(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync(e);
        }
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
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
    }
}
