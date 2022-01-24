using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public memoryHelper mh = new memoryHelper();
        bool procOpen = false;
        readonly string r6processname = "RainbowSix.exe";
        string r6mem = "RainbowSix.exe+";
        string events;
        string gamemode;
        string gamemode_parent;
        string mapname;
        string FulllbuildID;

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
                gamemode_parent = treeViewGameMode.SelectedNode.Parent.Tag.ToString();
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
                labelUpdate.Text = "Game found: " + FulllbuildID;  
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
            }
        }

        private async void Once_BuildID()
        {
            if (FulllbuildID == null)
            {
                IEnumerable<long> x = await m.AoBScan("59 ?? 53 ?? 2E ?? 2E ?? 2E ?? 5F 43", true, false, "").ConfigureAwait(false);
                //older version may have this as sig: 59 ?? 53 ?? 2E ?? 5F 43
                long firstaddress = x.FirstOrDefault();
                string address = string.Format("{0:X}", firstaddress);
                FulllbuildID = m.ReadString(address, "", 43, true);
                logs.WriteLog("Game Build ID: " + FulllbuildID);
            }
        }

        private void sendtor6_Clicked(object sender, EventArgs e)
        {
            if (procOpen)
            {
                //string version = m.ReadString(r6mem + VoidEdge.versionCheck, "", 32, true);
                if (FulllbuildID == VoidEdge.FuillBuildID)
                {
                    long house = m.ReadLong(r6mem + VoidEdge.house_Offset, "");
                    long hostage = m.ReadLong(r6mem + VoidEdge.hostage_Offset, "");
                    long elim = m.ReadLong(r6mem + VoidEdge.elim_Offset, "");
                    //map
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
                        VoidEdge.GameModeConverter(gamemode, gamemode_parent, hostage, elim, out long output_gamemode, out long difficulty);
                        if (output_gamemode != 0L)
                        {
                            m.WriteMemory(r6mem + VoidEdge.r6_gamemode, "long", output_gamemode.ToString(), "", null);
                            m.WriteMemory(r6mem + VoidEdge.r6_difficulty, "long", difficulty.ToString(), "", null);
                        }
                    }
                }
                else
                {
                    labelUpdate.Text = "Currently Void Edge supported";
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
            logs.WriteLog("idk " + procOpen);
            if (procOpen)
            {
                Once_BuildID();
                if (!string.IsNullOrEmpty(FulllbuildID))
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
    }
}
