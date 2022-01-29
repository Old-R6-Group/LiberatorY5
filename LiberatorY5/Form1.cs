﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Memory;

namespace LiberatorY5
{
    public partial class LiberatorY5 : Form
    {

        //array gamemode (void edge, steel wave, shadow legacy)
        //array maps (void edge, steel wave, shadow legacy)
        //array events(void edge, steel wave, shadow legacy)
        //array casual maps(void edge, steel wave, shadow legacy)
        //array ranked maps(void edge, steel wave, shadow legacy)
        //select first gamemode then map or vice versa
        //if select event gamemode and map will be ereased

        //variables
        public Mem m = new Mem();
        bool procOpen = false;
        readonly string r6processname = "RainbowSix.exe";
        string r6mem = "RainbowSix.exe+";
        string events;
        string gamemode;
        string gamemode_parent;
        string mapname;
        string FulllbuildID;
        long house = long.MaxValue;
        long hostage = long.MaxValue;
        long easy = long.MaxValue;
        long day = long.MaxValue;

        public LiberatorY5()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://r6downloads.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://r6modding.com");
        }

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
                labelEvent.Text = "Event";
                //treeViewEvents = null;
            }
        }

        private void treeViewMap_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewMap.SelectedNode.IsSelected)
            {
                labelMap.Text = treeViewMap.SelectedNode.FullPath;
                mapname = treeViewMap.SelectedNode.Tag.ToString();
                labelEvent.Text = "Event";
                //treeViewEvents = null;
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
                //treeViewGameMode = null;
                //treeViewMap = null;
                labelGameMode.Text = "Game Mode";
                labelMap.Text = "Map";
            }
        }
        //search for siege and hook
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            procOpen = m.OpenProcess(r6processname, out string fail);
            //logs.WriteLog(fail);
            if (!procOpen)
            {
                Thread.Sleep(100);
                return;
            }

            Thread.Sleep(1000);
            backgroundWorker.ReportProgress(0);
        }

        //updates the label ath the bottom
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //logs.WriteLog("idk " + procOpen);
            if (procOpen)
            {
                Once_BuildID();
                if (!string.IsNullOrWhiteSpace(FulllbuildID))
                {

                    labelUpdate.Text = "Game found: " + FulllbuildID;
                }
                else
                {
                    labelUpdate.Text = "This Build is NOT supported!";
                } 
            }
            else
            {
                labelUpdate.Text = "Can't find siege. Make sure Battleye is disabled and the game is at the main menu!";
                FulllbuildID = null;
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
                label3.Visible = false;
                labelGameMode.Visible = false;
                labelMap.Visible = false;
                labelEvent.Visible = false;
                labelSelecting.Visible = false;
                sendtoR6Button.Visible = false;
                randomButton.Visible = false;
                daynightCheckbox.Visible = false;
            }
            else
            {
                treeViewGameMode.Visible = true;
                treeViewMap.Visible = true;
                treeViewEvents.Visible = true;
                label3.Visible = true;
                labelGameMode.Visible = true;
                labelMap.Visible = true;
                labelEvent.Visible = true;
                labelSelecting.Visible = true;
                sendtoR6Button.Visible = true;
                randomButton.Visible = true;
                daynightCheckbox.Visible = true;
            }
        }

        private /*async*/ void Once_BuildID()
        {
            string version;
            if (FulllbuildID == null)
            {
                version = m.ReadString(r6mem + VoidEdge.BuildID_Check, "", 43, true);
                if (version == VoidEdge.FuillBuildID)
                {
                    house = m.ReadLong(r6mem + VoidEdge.house_Offset, "");
                    hostage = m.ReadLong(r6mem + VoidEdge.hostage_Offset, "");
                    easy = m.ReadLong(r6mem + VoidEdge.easyDifficulty_Offset, "");
                    day = m.ReadLong(r6mem + VoidEdge.day_Offset, "");
                    treeViewEvents.Nodes.Clear();
                    for (int index = 0; index < VoidEdge.EventView.Length; index++)
                    {
                        var item = VoidEdge.EventView[index];
                        var item2 = VoidEdge.EventView_Tag[index];
                        treeViewEvents.Nodes.Add(item);
                        treeViewEvents.Nodes[index].Tag = item2;
                    }
                    FulllbuildID = version;
                    logs.WriteLog("House: " + house.ToString() + " Hostage: " + hostage.ToString() + " Easy:" + easy.ToString() + " Day:" + day.ToString());
                }
                version = m.ReadString(r6mem + SteelWave.BuildID_Check, "", 46, true);
                if (version == SteelWave.FuillBuildID)
                {
                    house = m.ReadLong(r6mem + SteelWave.house_Offset, "");
                    hostage = m.ReadLong(r6mem + SteelWave.hostage_Offset, "");
                    easy = m.ReadLong(r6mem + SteelWave.easyDifficulty_Offset, "");
                    day = m.ReadLong(r6mem + SteelWave.day_Offset, "");
                    treeViewEvents.Nodes.Clear();
                    for (int index = 0; index < SteelWave.EventView.Length; index++)
                    {
                        var item = SteelWave.EventView[index];
                        var item2 = SteelWave.EventView_Tag[index];
                        treeViewEvents.Nodes.Add(item);
                        treeViewEvents.Nodes[index].Tag = item2;
                    }
                    FulllbuildID = version;
                    logs.WriteLog("House: " + house.ToString() + " Hostage: " + hostage.ToString() + " Easy:" + easy.ToString() + " Day:" + day.ToString());
                }
                /*
                IEnumerable<long> x = await m.AoBScan("59 ?? 53 ?? 2E ?? 2E ?? 2E ?? 5F 43", true, false, "").ConfigureAwait(false);
                59 ?? 53 ?? 2E ?? 2E ?? 2E ?? 5F 43 =>  Y?S?.?.?.?_C
                59 ?? 53 ?? 2E ?? 2E ?? 2E ?? 70 63 5F 43 =>  Y?S?.?.?.?pc_C
                //older version may have this as sig: 59 ?? 53 ?? 2E ?? 5F 43
                long firstaddress = x.FirstOrDefault();
                string address = string.Format("{0:X}", firstaddress);
                FulllbuildID = m.ReadString(address, "", 43, true);*/
                logs.WriteLog("Game Build ID: " + FulllbuildID);
            }
        }

        private void sendtor6_Clicked(object sender, EventArgs e)
        {
            if (procOpen)
            {
                if (FulllbuildID == VoidEdge.FuillBuildID)
                {
                    if (mapname != null)
                    {
                        if (mapname == "oldhereford")
                        {
                            long oldhereford = m.ReadLong(r6mem + VoidEdge.oldHereford_Offset, "");
                            m.WriteMemory(r6mem + VoidEdge.r6_map, "long", oldhereford.ToString(), "", null);
                        }
                        else
                        {
                            VoidEdge.MapConverter(mapname, house, out long output_map);
                            if (output_map != 0L)
                            {
                                m.WriteMemory(r6mem + VoidEdge.r6_map, "long", output_map.ToString(), "", null);
                            }
                        }
                    }
                    if (events != null)
                    {
                        VoidEdge.EventConverter(events, house, hostage, out long output_map, out long output_gamemode);
                        if (output_map != 0L | output_gamemode != 0L)
                        {
                            m.WriteMemory(r6mem + VoidEdge.r6_map, "long", output_map.ToString(), "", null);
                            m.WriteMemory(r6mem + VoidEdge.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                        }
                    }
                    if (gamemode != null)
                    {
                        VoidEdge.GameModeConverter(gamemode, gamemode_parent, house ,hostage,easy, out long output_gamemode, out long difficulty,out long outmap);
                        if (output_gamemode != 0L)
                        {
                            m.WriteMemory(r6mem + VoidEdge.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                            m.WriteMemory(r6mem + VoidEdge.r6_difficulty, "long", difficulty.ToString(), "", null);
                            if (outmap == 0L)
                            {
                                VoidEdge.MapConverter(mapname, house, out long output_map);
                                if (output_map != 0L)
                                {
                                    m.WriteMemory(r6mem + VoidEdge.r6_map, "long", output_map.ToString(), "", null);
                                }
                            }
                            else
                            {
                                m.WriteMemory(r6mem + VoidEdge.r6_map, "long", outmap.ToString(), "", null);
                            }
                            
                        }
                    }
                }
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
                else
                {
                    labelUpdate.Text = "Build Currently NOT supported";
                }
            }
            else
            {
                labelUpdate.Text = "Can't find siege";
                FulllbuildID = null;
            }
        }

        private void manual_hookClicked(object sender, EventArgs e)
        {
            procOpen = m.OpenProcess(r6processname, out string fail);
            logs.WriteLog("Failed? " + fail);
            if (!procOpen)
            {
                Thread.Sleep(100);
                return;
            }
            Thread.Sleep(1000);
            logs.WriteLog("Process is Opened already? " + procOpen);
            if (procOpen)
            {
                Once_BuildID();
                if (!string.IsNullOrWhiteSpace(FulllbuildID))
                {
                    
                    labelUpdate.Text = "Game found: " + FulllbuildID;
                }
                else
                {
                    labelUpdate.Text = "Something broken";
                }

            }
            else
            {
                labelUpdate.Text = "Can't find siege. Make sure Battleye is disabled and the game is at the main menu!";
                FulllbuildID = null;
            }
        }
        //added this to have the background acync
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker.RunWorkerAsync(e);
        }
        
        private void LiberatorY5_Shown(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync(e);
        }

        private void LibY5_Load(object sender, EventArgs e)
        {

        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            if (FulllbuildID == VoidEdge.FuillBuildID)
            {
                VoidEdge.GameModeConverter("Random", "Random", house, hostage, easy, out long output_gamemode, out long difficulty, out long outmap);
                if (output_gamemode != 0L)
                {
                    m.WriteMemory(r6mem + VoidEdge.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                    m.WriteMemory(r6mem + VoidEdge.r6_difficulty, "long", difficulty.ToString(), "", null);
                    if (outmap == 0L)
                    {
                        VoidEdge.MapConverter(mapname, house, out long output_map);
                        if (output_map != 0L)
                        {
                            m.WriteMemory(r6mem + VoidEdge.r6_map, "long", output_map.ToString(), "", null);
                        }
                    }
                    else
                    {
                        m.WriteMemory(r6mem + VoidEdge.r6_map, "long", outmap.ToString(), "", null);
                    }
                    var random = new Random();
                    GlobalStuff.DayChange((random.Next(2) == 1), day, out long daynight);
                    m.WriteMemory(r6mem + VoidEdge.r6_daynight, "long", daynight.ToString(), "", null);
                }
            }
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
                    var random = new Random();
                    GlobalStuff.DayChange((random.Next(2) == 1), day, out long daynight);
                    m.WriteMemory(r6mem + SteelWave.r6_daynight, "long", daynight.ToString(), "", null);
                }
            }
        }

        private void daynightCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            long daynight;
            if (FulllbuildID == VoidEdge.FuillBuildID)
            {
                GlobalStuff.DayChange(daynightCheckbox.Checked, day, out daynight);
                m.WriteMemory(r6mem + VoidEdge.r6_daynight, "long", daynight.ToString(), "", null);
            }
            if (FulllbuildID == SteelWave.FuillBuildID)
            {
                GlobalStuff.DayChange(daynightCheckbox.Checked, day, out daynight);
                m.WriteMemory(r6mem + SteelWave.r6_daynight, "long", daynight.ToString(), "", null);
            }
        }
    }
}
