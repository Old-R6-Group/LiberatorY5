using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace LiberatorY5
{
    partial class NewUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Golden Gun");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Grand Larceny");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("M.U.T.E Protocol");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Attrition");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Reverse Hostage");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Sugar Fright");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Bank");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Bartlett University");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Border");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Chalet");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Club House");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Coastline");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Consulate");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Favela");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Fortress");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Hereford (Old)");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Hereford (Rework)");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("House");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Kanal");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Oregon");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Outback");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Presidential Plane");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Russian Kafe");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Skyscraper");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Theme Park");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("Tower");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("Villa");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Yacht");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("Hostage");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("Secure Area");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Bomb");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("Warmup");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Golden Gun");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("Bomb - No Prep Phase");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("Multiplayer", new System.Windows.Forms.TreeNode[] {
            treeNode90,
            treeNode91,
            treeNode92,
            treeNode93,
            treeNode94,
            treeNode95});
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("Normal");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("Hard");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("Realistic");
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Protect Hostage", new System.Windows.Forms.TreeNode[] {
            treeNode97,
            treeNode98,
            treeNode99});
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("Normal");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("Hard");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("Realistic");
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("Extract Hostage", new System.Windows.Forms.TreeNode[] {
            treeNode101,
            treeNode102,
            treeNode103});
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("Normal");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("Hard");
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("Realistic");
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("Disarm Bomb", new System.Windows.Forms.TreeNode[] {
            treeNode105,
            treeNode106,
            treeNode107});
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("Normal");
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("Hard");
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("Realistic");
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("Elimination", new System.Windows.Forms.TreeNode[] {
            treeNode109,
            treeNode110,
            treeNode111});
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("Terrorist Hunt", new System.Windows.Forms.TreeNode[] {
            treeNode100,
            treeNode104,
            treeNode108,
            treeNode112});
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("Hostage");
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("Secure Area");
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("Bomb");
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("Casual", new System.Windows.Forms.TreeNode[] {
            treeNode114,
            treeNode115,
            treeNode116});
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("Hostage");
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("Secure Area");
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("Bomb");
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("Ranked", new System.Windows.Forms.TreeNode[] {
            treeNode118,
            treeNode119,
            treeNode120});
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("Match Making", new System.Windows.Forms.TreeNode[] {
            treeNode117,
            treeNode121});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUI));
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.re_readButton = new System.Windows.Forms.Button();
            this.checkBoxClientMode = new System.Windows.Forms.CheckBox();
            this.labelEvent = new System.Windows.Forms.Label();
            this.labelMap = new System.Windows.Forms.Label();
            this.labelGameMode = new System.Windows.Forms.Label();
            this.sendtoR6Button = new System.Windows.Forms.Button();
            this.treeViewEvents = new System.Windows.Forms.TreeView();
            this.treeViewMap = new System.Windows.Forms.TreeView();
            this.treeViewGameMode = new System.Windows.Forms.TreeView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.AutoJoinCheckBox = new System.Windows.Forms.CheckBox();
            this.hostLable = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.discUserButton = new System.Windows.Forms.Button();
            this.connectedPlayers = new System.Windows.Forms.ListBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.IP_Label = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.joinButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SoonLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SMWrong = new System.Windows.Forms.Label();
            this.RInfoLabel = new System.Windows.Forms.Label();
            this.RGModeButton = new System.Windows.Forms.Button();
            this.RMapButton = new System.Windows.Forms.Button();
            this.RDiffButton = new System.Windows.Forms.Button();
            this.RDayButton = new System.Windows.Forms.Button();
            this.soonTavLabel = new System.Windows.Forms.Label();
            this.endRoundButton = new System.Windows.Forms.Button();
            this.endMatchButton = new System.Windows.Forms.Button();
            this.daynightCheckbox = new System.Windows.Forms.CheckBox();
            this.randomButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.helpers = new System.Windows.Forms.Label();
            this.throwbackLabel = new System.Windows.Forms.LinkLabel();
            this.jvavWebLink = new System.Windows.Forms.LinkLabel();
            this.supportLabel = new System.Windows.Forms.Label();
            this.thisToolLabel = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelUpdate = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SLInventory_Button = new System.Windows.Forms.Button();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(555, 40);
            this.materialTabSelector2.TabIndex = 1;
            this.materialTabSelector2.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 110);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(555, 447);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tabPage1.Controls.Add(this.re_readButton);
            this.tabPage1.Controls.Add(this.checkBoxClientMode);
            this.tabPage1.Controls.Add(this.labelEvent);
            this.tabPage1.Controls.Add(this.labelMap);
            this.tabPage1.Controls.Add(this.labelGameMode);
            this.tabPage1.Controls.Add(this.sendtoR6Button);
            this.tabPage1.Controls.Add(this.treeViewEvents);
            this.tabPage1.Controls.Add(this.treeViewMap);
            this.tabPage1.Controls.Add(this.treeViewGameMode);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(547, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // re_readButton
            // 
            this.re_readButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.re_readButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.re_readButton.Location = new System.Drawing.Point(220, 410);
            this.re_readButton.Name = "re_readButton";
            this.re_readButton.Size = new System.Drawing.Size(110, 25);
            this.re_readButton.TabIndex = 16;
            this.re_readButton.Text = "Re-Read Stuff";
            this.re_readButton.UseVisualStyleBackColor = true;
            this.re_readButton.Click += new System.EventHandler(this.re_readButton_Click);
            // 
            // checkBoxClientMode
            // 
            this.checkBoxClientMode.AutoSize = true;
            this.checkBoxClientMode.Location = new System.Drawing.Point(10, 410);
            this.checkBoxClientMode.Name = "checkBoxClientMode";
            this.checkBoxClientMode.Size = new System.Drawing.Size(92, 19);
            this.checkBoxClientMode.TabIndex = 15;
            this.checkBoxClientMode.Text = "Client Mode";
            this.checkBoxClientMode.UseVisualStyleBackColor = true;
            this.checkBoxClientMode.CheckedChanged += new System.EventHandler(this.checkBoxClientMode_CheckedChanged);
            // 
            // labelEvent
            // 
            this.labelEvent.AutoSize = true;
            this.labelEvent.Location = new System.Drawing.Point(375, 380);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(37, 15);
            this.labelEvent.TabIndex = 14;
            this.labelEvent.Text = "Event";
            // 
            // labelMap
            // 
            this.labelMap.AutoSize = true;
            this.labelMap.Location = new System.Drawing.Point(200, 380);
            this.labelMap.Name = "labelMap";
            this.labelMap.Size = new System.Drawing.Size(32, 15);
            this.labelMap.TabIndex = 13;
            this.labelMap.Text = "Map";
            // 
            // labelGameMode
            // 
            this.labelGameMode.AutoSize = true;
            this.labelGameMode.Location = new System.Drawing.Point(10, 380);
            this.labelGameMode.Name = "labelGameMode";
            this.labelGameMode.Size = new System.Drawing.Size(76, 15);
            this.labelGameMode.TabIndex = 12;
            this.labelGameMode.Text = "Game Mode";
            // 
            // sendtoR6Button
            // 
            this.sendtoR6Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendtoR6Button.Location = new System.Drawing.Point(420, 410);
            this.sendtoR6Button.Name = "sendtoR6Button";
            this.sendtoR6Button.Size = new System.Drawing.Size(110, 25);
            this.sendtoR6Button.TabIndex = 11;
            this.sendtoR6Button.Text = "Send to Siege";
            this.sendtoR6Button.UseVisualStyleBackColor = true;
            this.sendtoR6Button.Click += new System.EventHandler(this.sendtoR6Button_Click);
            // 
            // treeViewEvents
            // 
            this.treeViewEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.treeViewEvents.ForeColor = System.Drawing.Color.White;
            this.treeViewEvents.Location = new System.Drawing.Point(375, 5);
            this.treeViewEvents.Name = "treeViewEvents";
            treeNode62.Name = "NodeGoldenGunVE";
            treeNode62.Tag = "goldengun";
            treeNode62.Text = "Golden Gun";
            treeNode63.Name = "NodeGrandLarceny";
            treeNode63.Tag = "grandlarceny";
            treeNode63.Text = "Grand Larceny";
            treeNode64.Name = "NodeMute";
            treeNode64.Tag = "mute";
            treeNode64.Text = "M.U.T.E Protocol";
            treeNode65.Name = "NodeAttrition";
            treeNode65.Tag = "attrition";
            treeNode65.Text = "Attrition";
            treeNode66.Name = "NodeReverseHostage";
            treeNode66.Tag = "reversehostage";
            treeNode66.Text = "Reverse Hostage";
            treeNode67.Name = "NodeSugarFright";
            treeNode67.Tag = "sugarfright";
            treeNode67.Text = "Sugar Fright";
            this.treeViewEvents.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode62,
            treeNode63,
            treeNode64,
            treeNode65,
            treeNode66,
            treeNode67});
            this.treeViewEvents.ShowLines = false;
            this.treeViewEvents.Size = new System.Drawing.Size(155, 370);
            this.treeViewEvents.TabIndex = 10;
            this.treeViewEvents.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewEvents_AfterSelect);
            // 
            // treeViewMap
            // 
            this.treeViewMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.treeViewMap.ForeColor = System.Drawing.Color.White;
            this.treeViewMap.Location = new System.Drawing.Point(200, 5);
            this.treeViewMap.Name = "treeViewMap";
            treeNode68.Name = "NodeBank";
            treeNode68.Tag = "bank";
            treeNode68.Text = "Bank";
            treeNode69.Name = "NodeBartlettUniversity";
            treeNode69.Tag = "university";
            treeNode69.Text = "Bartlett University";
            treeNode70.Name = "NodeBorder";
            treeNode70.Tag = "border";
            treeNode70.Text = "Border";
            treeNode71.Name = "NodeChalet";
            treeNode71.Tag = "chalet";
            treeNode71.Text = "Chalet";
            treeNode72.Name = "NodeClubHouse";
            treeNode72.Tag = "club";
            treeNode72.Text = "Club House";
            treeNode73.Name = "NodeCoastline";
            treeNode73.Tag = "coastline";
            treeNode73.Text = "Coastline";
            treeNode74.Name = "NodeConsulate";
            treeNode74.Tag = "consulate";
            treeNode74.Text = "Consulate";
            treeNode75.Name = "NodeFavela";
            treeNode75.Tag = "favela";
            treeNode75.Text = "Favela";
            treeNode76.Name = "NodeFortress";
            treeNode76.Tag = "fortress";
            treeNode76.Text = "Fortress";
            treeNode77.Name = "NodeOldHereford";
            treeNode77.Tag = "oldhereford";
            treeNode77.Text = "Hereford (Old)";
            treeNode78.Name = "NodeHerefordRework";
            treeNode78.Tag = "hereford";
            treeNode78.Text = "Hereford (Rework)";
            treeNode79.Name = "NodeHouse";
            treeNode79.Tag = "house";
            treeNode79.Text = "House";
            treeNode80.Name = "NodeKanal";
            treeNode80.Tag = "kanal";
            treeNode80.Text = "Kanal";
            treeNode81.Name = "NodeOregon";
            treeNode81.Tag = "oregon";
            treeNode81.Text = "Oregon";
            treeNode82.Name = "NodeOutback";
            treeNode82.Tag = "outback";
            treeNode82.Text = "Outback";
            treeNode83.Name = "NodePresidentialPlane";
            treeNode83.Tag = "plane";
            treeNode83.Text = "Presidential Plane";
            treeNode84.Name = "NodeRussianKafe";
            treeNode84.Tag = "cafe";
            treeNode84.Text = "Russian Kafe";
            treeNode85.Name = "NodeSkyscraper";
            treeNode85.Tag = "skyscraper";
            treeNode85.Text = "Skyscraper";
            treeNode86.Name = "NodeThemePark";
            treeNode86.Tag = "theme";
            treeNode86.Text = "Theme Park";
            treeNode87.Name = "NodeTower";
            treeNode87.Tag = "tower";
            treeNode87.Text = "Tower";
            treeNode88.Name = "NodeVilla";
            treeNode88.Tag = "villa";
            treeNode88.Text = "Villa";
            treeNode89.Name = "NodeYacht";
            treeNode89.Tag = "yacht";
            treeNode89.Text = "Yacht";
            this.treeViewMap.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode68,
            treeNode69,
            treeNode70,
            treeNode71,
            treeNode72,
            treeNode73,
            treeNode74,
            treeNode75,
            treeNode76,
            treeNode77,
            treeNode78,
            treeNode79,
            treeNode80,
            treeNode81,
            treeNode82,
            treeNode83,
            treeNode84,
            treeNode85,
            treeNode86,
            treeNode87,
            treeNode88,
            treeNode89});
            this.treeViewMap.ShowLines = false;
            this.treeViewMap.Size = new System.Drawing.Size(155, 370);
            this.treeViewMap.TabIndex = 9;
            this.treeViewMap.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMap_AfterSelect);
            // 
            // treeViewGameMode
            // 
            this.treeViewGameMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.treeViewGameMode.ForeColor = System.Drawing.Color.White;
            this.treeViewGameMode.FullRowSelect = true;
            this.treeViewGameMode.HideSelection = false;
            this.treeViewGameMode.Location = new System.Drawing.Point(10, 5);
            this.treeViewGameMode.Name = "treeViewGameMode";
            treeNode90.Name = "NodeHostage";
            treeNode90.Tag = "hostage";
            treeNode90.Text = "Hostage";
            treeNode91.Name = "NodeSecureArea";
            treeNode91.Tag = "secure";
            treeNode91.Text = "Secure Area";
            treeNode92.Name = "NodeBomb";
            treeNode92.Tag = "bomb";
            treeNode92.Text = "Bomb";
            treeNode93.Name = "NodeWarmup";
            treeNode93.Tag = "warmup";
            treeNode93.Text = "Warmup";
            treeNode94.Name = "NodeGoldenGun";
            treeNode94.Tag = "goldengun";
            treeNode94.Text = "Golden Gun";
            treeNode95.Name = "NodeBombNoPrep";
            treeNode95.Tag = "bombnoprep";
            treeNode95.Text = "Bomb - No Prep Phase";
            treeNode96.Name = "NodeMultiplayer";
            treeNode96.Tag = "Multiplayer";
            treeNode96.Text = "Multiplayer";
            treeNode97.Name = "NodePHNormal";
            treeNode97.Tag = "normal";
            treeNode97.Text = "Normal";
            treeNode98.Name = "NodePHHard";
            treeNode98.Tag = "hard";
            treeNode98.Text = "Hard";
            treeNode99.Name = "NodePHRealistic";
            treeNode99.Tag = "realistic";
            treeNode99.Text = "Realistic";
            treeNode100.Name = "NodePH";
            treeNode100.Tag = "protect";
            treeNode100.Text = "Protect Hostage";
            treeNode101.Name = "NodeEHNormal";
            treeNode101.Tag = "normal";
            treeNode101.Text = "Normal";
            treeNode102.Name = "NodeEHHard";
            treeNode102.Tag = "hard";
            treeNode102.Text = "Hard";
            treeNode103.Name = "NodeEHRealistic";
            treeNode103.Tag = "realistic";
            treeNode103.Text = "Realistic";
            treeNode104.Name = "NodeEH";
            treeNode104.Tag = "extract";
            treeNode104.Text = "Extract Hostage";
            treeNode105.Name = "NodeDBNormal";
            treeNode105.Tag = "normal";
            treeNode105.Text = "Normal";
            treeNode106.Name = "NodeDBHard";
            treeNode106.Tag = "hard";
            treeNode106.Text = "Hard";
            treeNode107.Name = "NodeDBRealistic";
            treeNode107.Tag = "realistic";
            treeNode107.Text = "Realistic";
            treeNode108.Name = "NodeDB";
            treeNode108.Tag = "disarm";
            treeNode108.Text = "Disarm Bomb";
            treeNode109.Name = "NodeENormal";
            treeNode109.Tag = "normal";
            treeNode109.Text = "Normal";
            treeNode110.Name = "NodeEHard";
            treeNode110.Tag = "hard";
            treeNode110.Text = "Hard";
            treeNode111.Name = "NodeERealistic";
            treeNode111.Tag = "realistic";
            treeNode111.Text = "Realistic";
            treeNode112.Name = "NodeE";
            treeNode112.Tag = "elimination";
            treeNode112.Text = "Elimination";
            treeNode113.Name = "NodeThunt";
            treeNode113.Tag = "TerroristHunt";
            treeNode113.Text = "Terrorist Hunt";
            treeNode114.Name = "NodeMMCHostage";
            treeNode114.Tag = "hostage";
            treeNode114.Text = "Hostage";
            treeNode115.Name = "NodeMMCSecureArea";
            treeNode115.Tag = "secure";
            treeNode115.Text = "Secure Area";
            treeNode116.Name = "NodeMMCBomb";
            treeNode116.Tag = "bomb";
            treeNode116.Text = "Bomb";
            treeNode117.Name = "NodeCasual";
            treeNode117.Tag = "casual";
            treeNode117.Text = "Casual";
            treeNode118.Name = "NodeMMRHostage";
            treeNode118.Tag = "hostage";
            treeNode118.Text = "Hostage";
            treeNode119.Name = "NodeMMRSecureArea";
            treeNode119.Tag = "secure";
            treeNode119.Text = "Secure Area";
            treeNode120.Name = "NodeMMRBomb";
            treeNode120.Tag = "bomb";
            treeNode120.Text = "Bomb";
            treeNode121.Name = "NodeRanked";
            treeNode121.Tag = "ranked";
            treeNode121.Text = "Ranked";
            treeNode122.Name = "NodeMatchmaking";
            treeNode122.Tag = "Matchmaking";
            treeNode122.Text = "Match Making";
            this.treeViewGameMode.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode96,
            treeNode113,
            treeNode122});
            this.treeViewGameMode.Size = new System.Drawing.Size(175, 370);
            this.treeViewGameMode.TabIndex = 3;
            this.treeViewGameMode.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewGameMode_AfterSelect);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tabPage4.Controls.Add(this.AutoJoinCheckBox);
            this.tabPage4.Controls.Add(this.hostLable);
            this.tabPage4.Controls.Add(this.nameLabel);
            this.tabPage4.Controls.Add(this.nameBox);
            this.tabPage4.Controls.Add(this.discUserButton);
            this.tabPage4.Controls.Add(this.connectedPlayers);
            this.tabPage4.Controls.Add(this.disconnectButton);
            this.tabPage4.Controls.Add(this.IP_Label);
            this.tabPage4.Controls.Add(this.ipBox);
            this.tabPage4.Controls.Add(this.joinButton);
            this.tabPage4.Controls.Add(this.createButton);
            this.tabPage4.Controls.Add(this.StatusLabel);
            this.tabPage4.Controls.Add(this.SoonLabel);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(547, 421);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Lan";
            // 
            // AutoJoinCheckBox
            // 
            this.AutoJoinCheckBox.AutoSize = true;
            this.AutoJoinCheckBox.Location = new System.Drawing.Point(378, 370);
            this.AutoJoinCheckBox.Name = "AutoJoinCheckBox";
            this.AutoJoinCheckBox.Size = new System.Drawing.Size(76, 19);
            this.AutoJoinCheckBox.TabIndex = 27;
            this.AutoJoinCheckBox.Text = "Auto Join";
            this.AutoJoinCheckBox.UseVisualStyleBackColor = true;
            this.AutoJoinCheckBox.CheckedChanged += new System.EventHandler(this.AutoJoinCheckBox_CheckedChanged);
            // 
            // hostLable
            // 
            this.hostLable.AutoSize = true;
            this.hostLable.Location = new System.Drawing.Point(247, 150);
            this.hostLable.Name = "hostLable";
            this.hostLable.Size = new System.Drawing.Size(49, 15);
            this.hostLable.TabIndex = 26;
            this.hostLable.Text = "Host IP:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(247, 105);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(70, 15);
            this.nameLabel.TabIndex = 25;
            this.nameLabel.Text = "Your name:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(247, 124);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(132, 20);
            this.nameBox.TabIndex = 24;
            // 
            // discUserButton
            // 
            this.discUserButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.discUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discUserButton.ForeColor = System.Drawing.Color.Transparent;
            this.discUserButton.Location = new System.Drawing.Point(11, 297);
            this.discUserButton.Name = "discUserButton";
            this.discUserButton.Size = new System.Drawing.Size(115, 23);
            this.discUserButton.TabIndex = 23;
            this.discUserButton.Text = "Disconnect User";
            this.discUserButton.UseVisualStyleBackColor = true;
            this.discUserButton.Click += new System.EventHandler(this.discUserButton_Click);
            // 
            // connectedPlayers
            // 
            this.connectedPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.connectedPlayers.ForeColor = System.Drawing.Color.White;
            this.connectedPlayers.FormattingEnabled = true;
            this.connectedPlayers.Location = new System.Drawing.Point(11, 105);
            this.connectedPlayers.Name = "connectedPlayers";
            this.connectedPlayers.Size = new System.Drawing.Size(192, 186);
            this.connectedPlayers.TabIndex = 22;
            // 
            // disconnectButton
            // 
            this.disconnectButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.disconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnectButton.ForeColor = System.Drawing.Color.Transparent;
            this.disconnectButton.Location = new System.Drawing.Point(455, 69);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(84, 23);
            this.disconnectButton.TabIndex = 21;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // IP_Label
            // 
            this.IP_Label.AutoSize = true;
            this.IP_Label.Location = new System.Drawing.Point(35, 370);
            this.IP_Label.Name = "IP_Label";
            this.IP_Label.Size = new System.Drawing.Size(17, 15);
            this.IP_Label.TabIndex = 20;
            this.IP_Label.Text = "ip";
            this.IP_Label.Click += new System.EventHandler(this.IP_Label_Click);
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(247, 168);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(132, 20);
            this.ipBox.TabIndex = 19;
            // 
            // joinButton
            // 
            this.joinButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.joinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joinButton.ForeColor = System.Drawing.Color.Transparent;
            this.joinButton.Location = new System.Drawing.Point(455, 40);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(84, 23);
            this.joinButton.TabIndex = 18;
            this.joinButton.Text = "Join Lan";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // createButton
            // 
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.ForeColor = System.Drawing.Color.Transparent;
            this.createButton.Location = new System.Drawing.Point(455, 11);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(84, 23);
            this.createButton.TabIndex = 18;
            this.createButton.Text = "Create Lan";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(8, 11);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(72, 15);
            this.StatusLabel.TabIndex = 1;
            this.StatusLabel.Text = "StatusLabel";
            // 
            // SoonLabel
            // 
            this.SoonLabel.AutoSize = true;
            this.SoonLabel.Location = new System.Drawing.Point(35, 406);
            this.SoonLabel.Name = "SoonLabel";
            this.SoonLabel.Size = new System.Drawing.Size(45, 15);
            this.SoonLabel.TabIndex = 0;
            this.SoonLabel.Text = "Soon...";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tabPage2.Controls.Add(this.SMWrong);
            this.tabPage2.Controls.Add(this.RInfoLabel);
            this.tabPage2.Controls.Add(this.RGModeButton);
            this.tabPage2.Controls.Add(this.RMapButton);
            this.tabPage2.Controls.Add(this.RDiffButton);
            this.tabPage2.Controls.Add(this.RDayButton);
            this.tabPage2.Controls.Add(this.soonTavLabel);
            this.tabPage2.Controls.Add(this.endRoundButton);
            this.tabPage2.Controls.Add(this.endMatchButton);
            this.tabPage2.Controls.Add(this.daynightCheckbox);
            this.tabPage2.Controls.Add(this.randomButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(547, 421);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Extra";
            // 
            // SMWrong
            // 
            this.SMWrong.AutoSize = true;
            this.SMWrong.Location = new System.Drawing.Point(24, 355);
            this.SMWrong.Name = "SMWrong";
            this.SMWrong.Size = new System.Drawing.Size(144, 15);
            this.SMWrong.TabIndex = 25;
            this.SMWrong.Text = "Something is wrong with:\r\n";
            // 
            // RInfoLabel
            // 
            this.RInfoLabel.AutoSize = true;
            this.RInfoLabel.Location = new System.Drawing.Point(24, 283);
            this.RInfoLabel.Name = "RInfoLabel";
            this.RInfoLabel.Size = new System.Drawing.Size(302, 60);
            this.RInfoLabel.TabIndex = 24;
            this.RInfoLabel.Text = "Reading: (Or Re-Reading)\r\nBefore you press the button,please make sure\r\nyou are i" +
    "n House-Day-Hostage.\r\nOr if you use difficulty, go to THunt with normal difficul" +
    "ty";
            // 
            // RGModeButton
            // 
            this.RGModeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RGModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RGModeButton.Location = new System.Drawing.Point(334, 376);
            this.RGModeButton.Name = "RGModeButton";
            this.RGModeButton.Size = new System.Drawing.Size(110, 25);
            this.RGModeButton.TabIndex = 23;
            this.RGModeButton.Text = "Read GMode";
            this.RGModeButton.UseVisualStyleBackColor = true;
            this.RGModeButton.Click += new System.EventHandler(this.RGModeButton_Click);
            // 
            // RMapButton
            // 
            this.RMapButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RMapButton.Location = new System.Drawing.Point(334, 345);
            this.RMapButton.Name = "RMapButton";
            this.RMapButton.Size = new System.Drawing.Size(110, 25);
            this.RMapButton.TabIndex = 22;
            this.RMapButton.Text = "Read Map";
            this.RMapButton.UseVisualStyleBackColor = true;
            this.RMapButton.Click += new System.EventHandler(this.RMapButton_Click);
            // 
            // RDiffButton
            // 
            this.RDiffButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RDiffButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RDiffButton.Location = new System.Drawing.Point(334, 314);
            this.RDiffButton.Name = "RDiffButton";
            this.RDiffButton.Size = new System.Drawing.Size(110, 25);
            this.RDiffButton.TabIndex = 21;
            this.RDiffButton.Text = "Read Difficulty";
            this.RDiffButton.UseVisualStyleBackColor = true;
            this.RDiffButton.Click += new System.EventHandler(this.RDiffButton_Click);
            // 
            // RDayButton
            // 
            this.RDayButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RDayButton.Location = new System.Drawing.Point(334, 283);
            this.RDayButton.Name = "RDayButton";
            this.RDayButton.Size = new System.Drawing.Size(110, 25);
            this.RDayButton.TabIndex = 20;
            this.RDayButton.Text = "Read Day";
            this.RDayButton.UseVisualStyleBackColor = true;
            this.RDayButton.Click += new System.EventHandler(this.RDayButton_Click);
            // 
            // soonTavLabel
            // 
            this.soonTavLabel.AutoSize = true;
            this.soonTavLabel.Location = new System.Drawing.Point(24, 116);
            this.soonTavLabel.Name = "soonTavLabel";
            this.soonTavLabel.Size = new System.Drawing.Size(123, 15);
            this.soonTavLabel.TabIndex = 19;
            this.soonTavLabel.Text = "Soon New Extra stuff!";
            // 
            // endRoundButton
            // 
            this.endRoundButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.endRoundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endRoundButton.ForeColor = System.Drawing.Color.Transparent;
            this.endRoundButton.Location = new System.Drawing.Point(297, 65);
            this.endRoundButton.Name = "endRoundButton";
            this.endRoundButton.Size = new System.Drawing.Size(84, 23);
            this.endRoundButton.TabIndex = 18;
            this.endRoundButton.Text = "End Round";
            this.endRoundButton.UseVisualStyleBackColor = true;
            this.endRoundButton.Click += new System.EventHandler(this.endRoundButton_Click);
            // 
            // endMatchButton
            // 
            this.endMatchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.endMatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endMatchButton.ForeColor = System.Drawing.Color.Transparent;
            this.endMatchButton.Location = new System.Drawing.Point(297, 36);
            this.endMatchButton.Name = "endMatchButton";
            this.endMatchButton.Size = new System.Drawing.Size(84, 23);
            this.endMatchButton.TabIndex = 17;
            this.endMatchButton.Text = "End Match";
            this.endMatchButton.UseVisualStyleBackColor = true;
            this.endMatchButton.Click += new System.EventHandler(this.endMatchButton_Click);
            // 
            // daynightCheckbox
            // 
            this.daynightCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.daynightCheckbox.Location = new System.Drawing.Point(27, 32);
            this.daynightCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.daynightCheckbox.Name = "daynightCheckbox";
            this.daynightCheckbox.Size = new System.Drawing.Size(207, 30);
            this.daynightCheckbox.TabIndex = 16;
            this.daynightCheckbox.Text = "Day / Night (Off Day, On Night)";
            this.daynightCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.daynightCheckbox.UseVisualStyleBackColor = true;
            this.daynightCheckbox.CheckedChanged += new System.EventHandler(this.daynightCheckbox_CheckedChanged);
            // 
            // randomButton
            // 
            this.randomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.randomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomButton.ForeColor = System.Drawing.Color.Transparent;
            this.randomButton.Location = new System.Drawing.Point(27, 65);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(131, 23);
            this.randomButton.TabIndex = 15;
            this.randomButton.Text = "Randomize all stuff";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.versionLabel);
            this.tabPage3.Controls.Add(this.helpers);
            this.tabPage3.Controls.Add(this.throwbackLabel);
            this.tabPage3.Controls.Add(this.jvavWebLink);
            this.tabPage3.Controls.Add(this.supportLabel);
            this.tabPage3.Controls.Add(this.thisToolLabel);
            this.tabPage3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(547, 421);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 105);
            this.label1.TabIndex = 14;
            this.label1.Text = "  Helped:\r\n- Gibbo\r\n- Imarealperson\r\n- Mystc\r\n- Tavreth\r\n- AsianStreetMeat\r\n- Ska" +
    "j?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(201, 392);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(54, 15);
            this.versionLabel.TabIndex = 13;
            this.versionLabel.Text = "Version: ";
            // 
            // helpers
            // 
            this.helpers.AutoSize = true;
            this.helpers.Location = new System.Drawing.Point(112, 253);
            this.helpers.Name = "helpers";
            this.helpers.Size = new System.Drawing.Size(106, 45);
            this.helpers.TabIndex = 12;
            this.helpers.Text = "This tool made by:\r\n- SlejmUr\r\n- JVAV";
            this.helpers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // throwbackLabel
            // 
            this.throwbackLabel.AutoSize = true;
            this.throwbackLabel.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.throwbackLabel.Location = new System.Drawing.Point(295, 220);
            this.throwbackLabel.Name = "throwbackLabel";
            this.throwbackLabel.Size = new System.Drawing.Size(181, 15);
            this.throwbackLabel.TabIndex = 11;
            this.throwbackLabel.TabStop = true;
            this.throwbackLabel.Text = "The First OG Tool discord server";
            this.throwbackLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // jvavWebLink
            // 
            this.jvavWebLink.AutoSize = true;
            this.jvavWebLink.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.jvavWebLink.Location = new System.Drawing.Point(111, 220);
            this.jvavWebLink.Name = "jvavWebLink";
            this.jvavWebLink.Size = new System.Drawing.Size(114, 15);
            this.jvavWebLink.TabIndex = 10;
            this.jvavWebLink.TabStop = true;
            this.jvavWebLink.Text = "Join JVAV\'s website";
            this.jvavWebLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // supportLabel
            // 
            this.supportLabel.AutoSize = true;
            this.supportLabel.Location = new System.Drawing.Point(15, 55);
            this.supportLabel.Name = "supportLabel";
            this.supportLabel.Size = new System.Drawing.Size(520, 135);
            this.supportLabel.TabIndex = 9;
            this.supportLabel.Text = resources.GetString("supportLabel.Text");
            this.supportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thisToolLabel
            // 
            this.thisToolLabel.Location = new System.Drawing.Point(8, 10);
            this.thisToolLabel.Name = "thisToolLabel";
            this.thisToolLabel.Size = new System.Drawing.Size(531, 30);
            this.thisToolLabel.TabIndex = 8;
            this.thisToolLabel.Text = "This tool is for expanding the possibilities of Tom Clancy\'s Rainbow Six Siege in" +
    " local custom games.\r\nyou can not use it to cheat in matchmaking and will never " +
    "support that.";
            this.thisToolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tabPage5.Controls.Add(this.SLInventory_Button);
            this.tabPage5.Controls.Add(this.checkBox1);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(547, 421);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tav\'s Tab";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(268, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 19);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Psudo List Enabler";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(403, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 27);
            this.button1.TabIndex = 21;
            this.button1.Text = "Start Modding";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Thank you Tav! Future things is here!";
            // 
            // LabelUpdate
            // 
            this.LabelUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelUpdate.AutoSize = true;
            this.LabelUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LabelUpdate.Location = new System.Drawing.Point(75, 570);
            this.LabelUpdate.Name = "LabelUpdate";
            this.LabelUpdate.Size = new System.Drawing.Size(393, 13);
            this.LabelUpdate.TabIndex = 10;
            this.LabelUpdate.Text = "Can\'t find siege. Make sure Battleye is disabled and the game is at the main menu" +
    "!";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // timer
            // 
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // SLInventory_Button
            // 
            this.SLInventory_Button.Enabled = false;
            this.SLInventory_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SLInventory_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SLInventory_Button.ForeColor = System.Drawing.Color.Transparent;
            this.SLInventory_Button.Location = new System.Drawing.Point(74, 112);
            this.SLInventory_Button.Name = "SLInventory_Button";
            this.SLInventory_Button.Size = new System.Drawing.Size(211, 27);
            this.SLInventory_Button.TabIndex = 23;
            this.SLInventory_Button.Text = "Shadow Legacy Inventory Editor";
            this.SLInventory_Button.UseVisualStyleBackColor = true;
            this.SLInventory_Button.Click += new System.EventHandler(this.SLInventory_Button_Click);
            // 
            // NewUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(555, 590);
            this.Controls.Add(this.LabelUpdate);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberator Reloaded!";
            this.Load += new System.EventHandler(this.NewUI_Load);
            this.Shown += new System.EventHandler(this.NewUI_Shown);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialTabSelector materialTabSelector2;
        private MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TreeView treeViewGameMode;
        private Label thisToolLabel;
        private Label supportLabel;
        private Label LabelUpdate;
        private LinkLabel throwbackLabel;
        private LinkLabel jvavWebLink;
        private Label helpers;
        private Button endRoundButton;
        private Button endMatchButton;
        private CheckBox daynightCheckbox;
        private Button randomButton;
        private Button sendtoR6Button;
        private TreeView treeViewEvents;
        private TreeView treeViewMap;
        private Label labelEvent;
        private Label labelMap;
        private Label labelGameMode;
        private CheckBox checkBoxClientMode;
        private Button re_readButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private Label versionLabel;
        private TabPage tabPage4;
        private Label SoonLabel;
        private Label StatusLabel;
        private Button createButton;
        private Button joinButton;
        private TextBox ipBox;
        private Label IP_Label;
        private Button disconnectButton;
        private ListBox connectedPlayers;
        private Button discUserButton;
        private TextBox nameBox;
        private Timer timer;
        private Label nameLabel;
        private Label hostLable;
        private Label label1;
        private Label soonTavLabel;
        private CheckBox AutoJoinCheckBox;
        private Button RGModeButton;
        private Button RMapButton;
        private Button RDiffButton;
        private Button RDayButton;
        private Label RInfoLabel;
        private Label SMWrong;
        private TabPage tabPage5;
        private Label label2;
        private Button button1;
        private CheckBox checkBox1;
        private Button SLInventory_Button;
    }
}