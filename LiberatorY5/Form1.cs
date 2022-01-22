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
        bool procOpen = false;
        string game = "RainbowSix.exe";
        

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
                labelEvent.Text = "Event";
                //treeViewEvents = null;
            }
        }

        private void treeViewMap_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewMap.SelectedNode.IsSelected)
            {
                labelMap.Text = treeViewMap.SelectedNode.FullPath;
                labelEvent.Text = "Event";
                //treeViewEvents = null;
            }
        }

        private void treeViewEvents_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewEvents.SelectedNode.IsSelected)
            {
                labelEvent.Text = treeViewEvents.SelectedNode.FullPath;
                //treeViewGameMode = null;
                //treeViewMap = null;
                labelGameMode.Text = "Game Mode";
                labelMap.Text = "Map";
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

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
    }
}
