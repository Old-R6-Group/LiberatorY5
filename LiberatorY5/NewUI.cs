using System;
using System.ComponentModel;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Memory;
using System.Threading;

namespace LiberatorY5
{
    public partial class NewUI : MaterialForm
    {
        #region Variables
        public Mem m = new Mem();
        public Random random = new Random();
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
            //Currently Nothing inside it :)
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
                Thread.Sleep(100);
                return;
            }
            Thread.Sleep(1000);
            backgroundWorker.ReportProgress(0);
        }
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (procOpen)
            {
                Once_BuildID();
                if (!string.IsNullOrWhiteSpace(FulllbuildID))
                {
                    LabelUpdate.Text = "Game found: " + FulllbuildID;
                }
                else
                {
                    LabelUpdate.Text = "This Build is NOT supported! or Currently Reading from your Game";
                }
            }
            else
            {
                LabelUpdate.Text = "Can't find siege. Make sure Battleye is disabled and the game is at the main menu!";
                FulllbuildID = null;
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
                if (version == VoidEdge_Shey.FuillBuildID)
                {
                    int state = m.ReadInt(r6mem + VoidEdge_Shey.gamestate, "");
                    logs.WriteLog("Game State: " + state.ToString());
                    if (state >= 2)
                    {
                        treeViewEvents.Nodes.Clear();
                        for (int index = 0; index < VoidEdge_Shey.EventView.Length; index++)
                        {
                            var item = VoidEdge_Shey.EventView[index];
                            var item2 = VoidEdge_Shey.EventView_Tag[index];
                            treeViewEvents.Nodes.Add(item);
                            treeViewEvents.Nodes[index].Tag = item2;
                        }
                        house = m.ReadLong(r6mem + VoidEdge_Shey.house_Offset, "");
                        hostage = m.ReadLong(r6mem + VoidEdge_Shey.hostage_Offset, "");
                        easy = m.ReadLong(r6mem + VoidEdge_Shey.easyDifficulty_Offset, "");
                        day = m.ReadLong(r6mem + VoidEdge_Shey.day_Offset, "");
                        FulllbuildID = version;
                        logs.WriteLog("House: " + house.ToString() + " Hostage: " + hostage.ToString() + " Easy:" + easy.ToString() + " Day:" + day.ToString());
                    }
                }
                version = m.ReadString(r6mem + VoidEdge_MU.BuildID_Check, "", 43, true);
                if (version == VoidEdge_MU.FuillBuildID)
                {
                    int state = m.ReadInt(r6mem + VoidEdge_MU.gamestate, "");
                    logs.WriteLog("Game State: " + state.ToString());
                    if (state >= 2)
                    {
                        treeViewEvents.Nodes.Clear();
                        for (int index = 0; index < VoidEdge_MU.EventView.Length; index++)
                        {
                            var item = VoidEdge_MU.EventView[index];
                            var item2 = VoidEdge_MU.EventView_Tag[index];
                            treeViewEvents.Nodes.Add(item);
                            treeViewEvents.Nodes[index].Tag = item2;
                        }
                        house = m.ReadLong(r6mem + VoidEdge_MU.house_Offset, "");
                        hostage = m.ReadLong(r6mem + VoidEdge_MU.hostage_Offset, "");
                        easy = m.ReadLong(r6mem + VoidEdge_MU.easyDifficulty_Offset, "");
                        day = m.ReadLong(r6mem + VoidEdge_MU.day_Offset, "");
                        FulllbuildID = version;
                        logs.WriteLog("House: " + house.ToString() + " Hostage: " + hostage.ToString() + " Easy:" + easy.ToString() + " Day:" + day.ToString());
                    }
                }
                version = m.ReadString(r6mem + SteelWave.BuildID_Check, "", 46, true);
                if (version == SteelWave.FuillBuildID)
                {
                    int state = m.ReadInt(r6mem + SteelWave.gamestate, "");
                    if (state >= 2)
                    {
                        treeViewEvents.Nodes.Clear();
                        for (int index = 0; index < SteelWave.EventView.Length; index++)
                        {
                            var item = SteelWave.EventView[index];
                            var item2 = SteelWave.EventView_Tag[index];
                            treeViewEvents.Nodes.Add(item);
                            treeViewEvents.Nodes[index].Tag = item2;
                        }
                        house = m.ReadLong(r6mem + SteelWave.house_Offset, "");
                        hostage = m.ReadLong(r6mem + SteelWave.hostage_Offset, "");
                        easy = m.ReadLong(r6mem + SteelWave.easyDifficulty_Offset, "");
                        day = m.ReadLong(r6mem + SteelWave.day_Offset, "");
                        FulllbuildID = version;
                        logs.WriteLog("House: " + house.ToString() + " Hostage: " + hostage.ToString() + " Easy:" + easy.ToString() + " Day:" + day.ToString());
                    }
                }
                version = m.ReadString(r6mem + ShadowLegacy_Global.BuildID_Check, "", 43, true);
                if (version == ShadowLegacy_Global.FuillBuildID)
                {
                    int state = m.ReadInt(r6mem + ShadowLegacy_Global.gamestate, "");
                    if (state >= 2)
                    {
                        treeViewEvents.Nodes.Clear();
                        for (int index = 0; index < ShadowLegacy_Global.EventView.Length; index++)
                        {
                            var item = ShadowLegacy_Global.EventView[index];
                            var item2 = ShadowLegacy_Global.EventView_Tag[index];
                            treeViewEvents.Nodes.Add(item);
                            treeViewEvents.Nodes[index].Tag = item2;
                        }
                        house = m.ReadLong(r6mem + ShadowLegacy_Global.house_Offset, "");
                        hostage = m.ReadLong(r6mem + ShadowLegacy_Global.hostage_Offset, "");
                        easy = m.ReadLong(r6mem + ShadowLegacy_Global.easyDifficulty_Offset, "");
                        day = m.ReadLong(r6mem + ShadowLegacy_Global.day_Offset, "");
                        FulllbuildID = version;
                        logs.WriteLog("House: " + house.ToString() + " Hostage: " + hostage.ToString() + " Easy:" + easy.ToString() + " Day:" + day.ToString());
                    }
                }
                if (!string.IsNullOrWhiteSpace(FulllbuildID)) logs.WriteLog("Game Build ID: " + FulllbuildID);
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
                if (FulllbuildID == VoidEdge_Shey.FuillBuildID)
                {
                    treeViewEvents.Nodes.Clear();
                    for (int index = 0; index < VoidEdge_Shey.EventView.Length; index++)
                    {
                        var item = VoidEdge_Shey.EventView[index];
                        var item2 = VoidEdge_Shey.EventView_Tag[index];
                        treeViewEvents.Nodes.Add(item);
                        treeViewEvents.Nodes[index].Tag = item2;
                    }
                    house = m.ReadLong(r6mem + VoidEdge_Shey.house_Offset, "");
                    hostage = m.ReadLong(r6mem + VoidEdge_Shey.hostage_Offset, "");
                    easy = m.ReadLong(r6mem + VoidEdge_Shey.easyDifficulty_Offset, "");
                    day = m.ReadLong(r6mem + VoidEdge_Shey.day_Offset, "");
                    logs.WriteLog("House: " + house.ToString() + " Hostage: " + hostage.ToString() + " Easy:" + easy.ToString() + " Day:" + day.ToString());
                }
                if (FulllbuildID == VoidEdge_MU.FuillBuildID)
                {
                    treeViewEvents.Nodes.Clear();
                    for (int index = 0; index < VoidEdge_MU.EventView.Length; index++)
                    {
                        var item = VoidEdge_MU.EventView[index];
                        var item2 = VoidEdge_MU.EventView_Tag[index];
                        treeViewEvents.Nodes.Add(item);
                        treeViewEvents.Nodes[index].Tag = item2;
                    }
                    house = m.ReadLong(r6mem + VoidEdge_MU.house_Offset, "");
                    hostage = m.ReadLong(r6mem + VoidEdge_MU.hostage_Offset, "");
                    easy = m.ReadLong(r6mem + VoidEdge_MU.easyDifficulty_Offset, "");
                    day = m.ReadLong(r6mem + VoidEdge_MU.day_Offset, "");
                    logs.WriteLog("House: " + house.ToString() + " Hostage: " + hostage.ToString() + " Easy:" + easy.ToString() + " Day:" + day.ToString());
                }
                if (FulllbuildID == SteelWave.FuillBuildID)
                {
                    treeViewEvents.Nodes.Clear();
                    for (int index = 0; index < SteelWave.EventView.Length; index++)
                    {
                        var item = SteelWave.EventView[index];
                        var item2 = SteelWave.EventView_Tag[index];
                        treeViewEvents.Nodes.Add(item);
                        treeViewEvents.Nodes[index].Tag = item2;
                    }

                    house = m.ReadLong(r6mem + SteelWave.house_Offset, "");
                    hostage = m.ReadLong(r6mem + SteelWave.hostage_Offset, "");
                    easy = m.ReadLong(r6mem + SteelWave.easyDifficulty_Offset, "");
                    day = m.ReadLong(r6mem + SteelWave.day_Offset, "");
                    logs.WriteLog("House: " + house.ToString() + " Hostage: " + hostage.ToString() + " Easy:" + easy.ToString() + " Day:" + day.ToString());
                }
                if (FulllbuildID == ShadowLegacy_Global.FuillBuildID)
                {
                    treeViewEvents.Nodes.Clear();
                    for (int index = 0; index < ShadowLegacy_Global.EventView.Length; index++)
                    {
                        var item = ShadowLegacy_Global.EventView[index];
                        var item2 = ShadowLegacy_Global.EventView_Tag[index];
                        treeViewEvents.Nodes.Add(item);
                        treeViewEvents.Nodes[index].Tag = item2;
                    }

                    house = m.ReadLong(r6mem + ShadowLegacy_Global.house_Offset, "");
                    hostage = m.ReadLong(r6mem + ShadowLegacy_Global.hostage_Offset, "");
                    easy = m.ReadLong(r6mem + ShadowLegacy_Global.easyDifficulty_Offset, "");
                    day = m.ReadLong(r6mem + ShadowLegacy_Global.day_Offset, "");
                    logs.WriteLog("House: " + house.ToString() + " Hostage: " + hostage.ToString() + " Easy:" + easy.ToString() + " Day:" + day.ToString());
                }
                //treeViewGameMode.Nodes.Find("NodeHostage", true)[0].Remove();
                //This will remove existing nodes!
                //Helped for future

                LabelUpdate.Text = "Reading addresses again!";
            }
        }
        private void sendtoR6Button_Click(object sender, EventArgs e)
        {
            if (procOpen)
            {
                #region Void Edge Shey
                if (FulllbuildID == VoidEdge_Shey.FuillBuildID)
                {
                    if (mapname != null)
                    {
                        if (mapname == "oldhereford")
                        {
                            long oldhereford = m.ReadLong(r6mem + VoidEdge_Shey.oldHereford_Offset, "");
                            m.WriteMemory(r6mem + VoidEdge_Shey.r6_map, "long", oldhereford.ToString(), "", null);
                        }
                        else
                        {
                            VoidEdge_Shey.MapConverter(mapname, house, out long output_map);
                            if (output_map != 0L)
                            {
                                m.WriteMemory(r6mem + VoidEdge_Shey.r6_map, "long", output_map.ToString(), "", null);
                            }
                        }
                    }
                    if (events != null)
                    {
                        VoidEdge_Shey.EventConverter(events, house, hostage, out long output_map, out long output_gamemode);
                        if (output_map != 0L | output_gamemode != 0L)
                        {
                            m.WriteMemory(r6mem + VoidEdge_Shey.r6_map, "long", output_map.ToString(), "", null);
                            m.WriteMemory(r6mem + VoidEdge_Shey.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                        }
                    }
                    if (gamemode != null)
                    {
                        VoidEdge_Shey.GameModeConverter(gamemode, gamemode_parent, house, hostage, easy, out long output_gamemode, out long difficulty, out long outmap);
                        if (output_gamemode != 0L)
                        {
                            m.WriteMemory(r6mem + VoidEdge_Shey.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                            m.WriteMemory(r6mem + VoidEdge_Shey.r6_difficulty, "long", difficulty.ToString(), "", null);
                            if (outmap == 0L)
                            {
                                VoidEdge_Shey.MapConverter(mapname, house, out long output_map);
                                if (output_map != 0L)
                                {
                                    m.WriteMemory(r6mem + VoidEdge_Shey.r6_map, "long", output_map.ToString(), "", null);
                                }
                            }
                            else
                            {
                                m.WriteMemory(r6mem + VoidEdge_Shey.r6_map, "long", outmap.ToString(), "", null);
                            }

                        }
                    }
                }
                #endregion
                #region Void Edge MU
                if (FulllbuildID == VoidEdge_MU.FuillBuildID)
                {
                    if (mapname != null)
                    {
                        VoidEdge_MU.MapConverter(mapname, house, out long output_map);
                        if (output_map != 0L)
                        {
                            m.WriteMemory(r6mem + VoidEdge_MU.r6_map, "long", output_map.ToString(), "", null);
                        }
                    }
                    if (events != null)
                    {
                        VoidEdge_MU.EventConverter(events, house, hostage, out long output_map, out long output_gamemode);
                        if (output_map != 0L | output_gamemode != 0L)
                        {
                            m.WriteMemory(r6mem + VoidEdge_MU.r6_map, "long", output_map.ToString(), "", null);
                            m.WriteMemory(r6mem + VoidEdge_MU.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                        }
                    }
                    if (gamemode != null)
                    {
                        VoidEdge_MU.GameModeConverter(gamemode, gamemode_parent, house, hostage, easy, out long output_gamemode, out long difficulty, out long outmap);
                        if (output_gamemode != 0L)
                        {
                            m.WriteMemory(r6mem + VoidEdge_MU.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                            m.WriteMemory(r6mem + VoidEdge_MU.r6_difficulty, "long", difficulty.ToString(), "", null);
                            if (outmap == 0L)
                            {
                                VoidEdge_MU.MapConverter(mapname, house, out long output_map);
                                if (output_map != 0L)
                                {
                                    m.WriteMemory(r6mem + VoidEdge_MU.r6_map, "long", output_map.ToString(), "", null);
                                }
                            }
                            else
                            {
                                m.WriteMemory(r6mem + VoidEdge_MU.r6_map, "long", outmap.ToString(), "", null);
                            }

                        }
                    }
                }
                #endregion
                #region SteelWave
                if (FulllbuildID == SteelWave.FuillBuildID)
                {
                    if (mapname != null)
                    {
                        if (mapname == "oldhereford")
                        {
                            long oldhereford = m.ReadLong(r6mem + SteelWave.oldHereford_Offset, "");
                            m.WriteMemory(r6mem + SteelWave.r6_map, "long", oldhereford.ToString(), "", null);
                        }
                        else
                        {
                            SteelWave.MapConverter(mapname, house, out long output_map);
                            if (output_map != 0L)
                            {
                                m.WriteMemory(r6mem + SteelWave.r6_map, "long", output_map.ToString(), "", null);
                            }
                        }
                    }
                    if (events != null)
                    {
                        SteelWave.EventConverter(events, house, hostage, out long output_map, out long output_gamemode);
                        if (output_map != 0L | output_gamemode != 0L)
                        {
                            m.WriteMemory(r6mem + SteelWave.r6_map, "long", output_map.ToString(), "", null);
                            m.WriteMemory(r6mem + SteelWave.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                        }
                    }
                    if (gamemode != null)
                    {
                        SteelWave.GameModeConverter(gamemode, gamemode_parent, house, hostage, easy, out long output_gamemode, out long difficulty, out long outmap);
                        if (output_gamemode != 0L)
                        {
                            m.WriteMemory(r6mem + SteelWave.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                            m.WriteMemory(r6mem + SteelWave.r6_difficulty, "long", difficulty.ToString(), "", null);
                            if (outmap == 0L)
                            {
                                SteelWave.MapConverter(mapname, house, out long output_map);
                                if (output_map != 0L)
                                {
                                    m.WriteMemory(r6mem + SteelWave.r6_map, "long", output_map.ToString(), "", null);
                                }
                            }
                            else
                            {
                                m.WriteMemory(r6mem + SteelWave.r6_map, "long", outmap.ToString(), "", null);
                            }

                        }
                    }
                }
                #endregion
                #region Shadow Legacy Global
                if (FulllbuildID == ShadowLegacy_Global.FuillBuildID)
                {
                    if (mapname != null)
                    {
                        ShadowLegacy_Global.MapConverter(mapname, house, out long output_map);
                        if (output_map != 0L)
                        {
                            m.WriteMemory(r6mem + ShadowLegacy_Global.r6_map, "long", output_map.ToString(), "", null);
                        }
                    }
                    if (events != null)
                    {
                        ShadowLegacy_Global.EventConverter(events, house, hostage, out long output_map, out long output_gamemode);
                        if (output_map != 0L | output_gamemode != 0L)
                        {
                            m.WriteMemory(r6mem + ShadowLegacy_Global.r6_map, "long", output_map.ToString(), "", null);
                            m.WriteMemory(r6mem + ShadowLegacy_Global.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                        }
                    }
                    if (gamemode != null)
                    {
                        ShadowLegacy_Global.GameModeConverter(gamemode, gamemode_parent, house, hostage, easy, out long output_gamemode, out long difficulty, out long outmap);
                        if (output_gamemode != 0L)
                        {
                            m.WriteMemory(r6mem + ShadowLegacy_Global.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                            m.WriteMemory(r6mem + ShadowLegacy_Global.r6_difficulty, "long", difficulty.ToString(), "", null);
                            if (outmap == 0L)
                            {
                                ShadowLegacy_Global.MapConverter(mapname, house, out long output_map);
                                if (output_map != 0L)
                                {
                                    m.WriteMemory(r6mem + ShadowLegacy_Global.r6_map, "long", output_map.ToString(), "", null);
                                }
                            }
                            else
                            {
                                m.WriteMemory(r6mem + ShadowLegacy_Global.r6_map, "long", outmap.ToString(), "", null);
                            }

                        }
                    }
                }
                #endregion
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
            if (FulllbuildID == VoidEdge_Shey.FuillBuildID)
            {
                GlobalStuff.DayChange(daynightCheckbox.Checked, day, out daynight);
                m.WriteMemory(r6mem + VoidEdge_Shey.r6_daynight, "long", daynight.ToString(), "", null);
            }
            if (FulllbuildID == VoidEdge_MU.FuillBuildID)
            {
                GlobalStuff.DayChange(daynightCheckbox.Checked, day, out daynight);
                m.WriteMemory(r6mem + VoidEdge_MU.r6_daynight, "long", daynight.ToString(), "", null);
            }
            if (FulllbuildID == SteelWave.FuillBuildID)
            {
                GlobalStuff.DayChange(daynightCheckbox.Checked, day, out daynight);
                m.WriteMemory(r6mem + SteelWave.r6_daynight, "long", daynight.ToString(), "", null);
            }
            if (FulllbuildID == ShadowLegacy_Global.FuillBuildID)
            {
                GlobalStuff.DayChange(daynightCheckbox.Checked, day, out daynight);
                m.WriteMemory(r6mem + ShadowLegacy_Global.r6_daynight, "long", daynight.ToString(), "", null);
            }
        }
        private void randomButton_Click(object sender, EventArgs e)
        {
            #region Void Edge Shey
            if (FulllbuildID == VoidEdge_Shey.FuillBuildID)
            {
                VoidEdge_Shey.GameModeConverter("Random", "Random", house, hostage, easy, out long output_gamemode, out long difficulty, out long outmap);
                if (output_gamemode != 0L)
                {
                    m.WriteMemory(r6mem + VoidEdge_Shey.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                    m.WriteMemory(r6mem + VoidEdge_Shey.r6_difficulty, "long", difficulty.ToString(), "", null);
                    if (outmap == 0L)
                    {
                        VoidEdge_Shey.MapConverter(mapname, house, out long output_map);
                        if (output_map != 0L)
                        {
                            m.WriteMemory(r6mem + VoidEdge_Shey.r6_map, "long", output_map.ToString(), "", null);
                        }
                    }
                    else
                    {
                        m.WriteMemory(r6mem + VoidEdge_Shey.r6_map, "long", outmap.ToString(), "", null);
                    }
                    GlobalStuff.DayChange((random.Next(2) == 1), day, out long daynight);
                    m.WriteMemory(r6mem + VoidEdge_Shey.r6_daynight, "long", daynight.ToString(), "", null);
                }
            }
            #endregion
            #region Void Edge Mu
            if (FulllbuildID == VoidEdge_MU.FuillBuildID)
            {
                VoidEdge_MU.GameModeConverter("Random", "Random", house, hostage, easy, out long output_gamemode, out long difficulty, out long outmap);
                if (output_gamemode != 0L)
                {
                    m.WriteMemory(r6mem + VoidEdge_MU.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                    m.WriteMemory(r6mem + VoidEdge_MU.r6_difficulty, "long", difficulty.ToString(), "", null);
                    if (outmap == 0L)
                    {
                        VoidEdge_MU.MapConverter(mapname, house, out long output_map);
                        if (output_map != 0L)
                        {
                            m.WriteMemory(r6mem + VoidEdge_MU.r6_map, "long", output_map.ToString(), "", null);
                        }
                    }
                    else
                    {
                        m.WriteMemory(r6mem + VoidEdge_MU.r6_map, "long", outmap.ToString(), "", null);
                    }
                    GlobalStuff.DayChange((random.Next(2) == 1), day, out long daynight);
                    m.WriteMemory(r6mem + VoidEdge_MU.r6_daynight, "long", daynight.ToString(), "", null);
                }
            }
            #endregion
            #region SteelWave
            if (FulllbuildID == SteelWave.FuillBuildID)
            {
                SteelWave.GameModeConverter("Random", "Random", house, hostage, easy, out long output_gamemode, out long difficulty, out long outmap);
                if (output_gamemode != 0L)
                {
                    m.WriteMemory(r6mem + SteelWave.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                    m.WriteMemory(r6mem + SteelWave.r6_difficulty, "long", difficulty.ToString(), "", null);
                    if (outmap == 0L)
                    {
                        SteelWave.MapConverter(mapname, house, out long output_map);
                        if (output_map != 0L)
                        {
                            m.WriteMemory(r6mem + SteelWave.r6_map, "long", output_map.ToString(), "", null);
                        }
                    }
                    else
                    {
                        m.WriteMemory(r6mem + SteelWave.r6_map, "long", outmap.ToString(), "", null);
                    }
                    GlobalStuff.DayChange((random.Next(2) == 1), day, out long daynight);
                    m.WriteMemory(r6mem + SteelWave.r6_daynight, "long", daynight.ToString(), "", null);
                }
            }
            #endregion
            #region Shadow Legacy Global
            if (FulllbuildID == ShadowLegacy_Global.FuillBuildID)
            {
                ShadowLegacy_Global.GameModeConverter("Random", "Random", house, hostage, easy, out long output_gamemode, out long difficulty, out long outmap);
                if (output_gamemode != 0L)
                {
                    m.WriteMemory(r6mem + ShadowLegacy_Global.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                    m.WriteMemory(r6mem + ShadowLegacy_Global.r6_difficulty, "long", difficulty.ToString(), "", null);
                    if (outmap == 0L)
                    {
                        ShadowLegacy_Global.MapConverter(mapname, house, out long output_map);
                        if (output_map != 0L)
                        {
                            m.WriteMemory(r6mem + ShadowLegacy_Global.r6_map, "long", output_map.ToString(), "", null);
                        }
                    }
                    else
                    {
                        m.WriteMemory(r6mem + ShadowLegacy_Global.r6_map, "long", outmap.ToString(), "", null);
                    }
                    GlobalStuff.DayChange((random.Next(2) == 1), day, out long daynight);
                    m.WriteMemory(r6mem + ShadowLegacy_Global.r6_daynight, "long", daynight.ToString(), "", null);
                }
            }
            #endregion
        }
        private void endMatchButton_Click(object sender, EventArgs e)
        {
            if (FulllbuildID == VoidEdge_Shey.FuillBuildID)
            {
                m.WriteMemory(r6mem + VoidEdge_Shey.gamestate, "int", "3", "", null);
            }
            if (FulllbuildID == VoidEdge_MU.FuillBuildID)
            {
                m.WriteMemory(r6mem + VoidEdge_MU.gamestate, "int", "3", "", null);
            }
            if (FulllbuildID == SteelWave.FuillBuildID)
            {
                m.WriteMemory(r6mem + SteelWave.gamestate, "int", "3", "", null);
            }
            if (FulllbuildID == ShadowLegacy_Global.FuillBuildID)
            {
                m.WriteMemory(r6mem + ShadowLegacy_Global.gamestate, "int", "3", "", null);
            }
        }
        private void endRoundButton_Click(object sender, EventArgs e)
        {
            if (FulllbuildID == VoidEdge_Shey.FuillBuildID)
            {
                m.WriteMemory(r6mem + VoidEdge_Shey.gamestate, "int", "2", "", null);
            }
            if (FulllbuildID == VoidEdge_MU.FuillBuildID)
            {
                m.WriteMemory(r6mem + VoidEdge_MU.gamestate, "int", "2", "", null);
            }
            if (FulllbuildID == SteelWave.FuillBuildID)
            {
                m.WriteMemory(r6mem + SteelWave.gamestate, "int", "2", "", null);
            }
            if (FulllbuildID == ShadowLegacy_Global.FuillBuildID)
            {
                m.WriteMemory(r6mem + ShadowLegacy_Global.gamestate, "int", "2", "", null);
            }
        }
        #endregion
    }
}
