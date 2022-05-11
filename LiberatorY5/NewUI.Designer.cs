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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Golden Gun");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Grand Larceny");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("M.U.T.E Protocol");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Attrition");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Reverse Hostage");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Sugar Fright");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Bank");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Bartlett University");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Border");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Chalet");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Club House");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Coastline");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Consulate");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Favela");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Fortress");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Hereford (Old)");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Hereford (Rework)");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("House");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Kanal");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Oregon");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Outback");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Presidential Plane");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Russian Kafe");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Skyscraper");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Theme Park");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Tower");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Villa");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Yacht");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Hostage");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Secure Area");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Bomb");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Warmup");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Golden Gun");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Bomb - No Prep Phase");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Multiplayer", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Normal");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Hard");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Realistic");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Protect Hostage", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Normal");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Hard");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Realistic");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Extract Hostage", new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode41,
            treeNode42});
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Normal");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Hard");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Realistic");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Disarm Bomb", new System.Windows.Forms.TreeNode[] {
            treeNode44,
            treeNode45,
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Normal");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Hard");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Realistic");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Elimination", new System.Windows.Forms.TreeNode[] {
            treeNode48,
            treeNode49,
            treeNode50});
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Terrorist Hunt", new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode43,
            treeNode47,
            treeNode51});
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Hostage");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Secure Area");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Bomb");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Casual", new System.Windows.Forms.TreeNode[] {
            treeNode53,
            treeNode54,
            treeNode55});
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Hostage");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Secure Area");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Bomb");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Ranked", new System.Windows.Forms.TreeNode[] {
            treeNode57,
            treeNode58,
            treeNode59});
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Match Making", new System.Windows.Forms.TreeNode[] {
            treeNode56,
            treeNode60});
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
            this.label2 = new System.Windows.Forms.Label();
            this.LabelUpdate = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Timer(this.components);
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
            treeNode1.Name = "NodeGoldenGunVE";
            treeNode1.Tag = "goldengun";
            treeNode1.Text = "Golden Gun";
            treeNode2.Name = "NodeGrandLarceny";
            treeNode2.Tag = "grandlarceny";
            treeNode2.Text = "Grand Larceny";
            treeNode3.Name = "NodeMute";
            treeNode3.Tag = "mute";
            treeNode3.Text = "M.U.T.E Protocol";
            treeNode4.Name = "NodeAttrition";
            treeNode4.Tag = "attrition";
            treeNode4.Text = "Attrition";
            treeNode5.Name = "NodeReverseHostage";
            treeNode5.Tag = "reversehostage";
            treeNode5.Text = "Reverse Hostage";
            treeNode6.Name = "NodeSugarFright";
            treeNode6.Tag = "sugarfright";
            treeNode6.Text = "Sugar Fright";
            this.treeViewEvents.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
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
            treeNode7.Name = "NodeBank";
            treeNode7.Tag = "bank";
            treeNode7.Text = "Bank";
            treeNode8.Name = "NodeBartlettUniversity";
            treeNode8.Tag = "university";
            treeNode8.Text = "Bartlett University";
            treeNode9.Name = "NodeBorder";
            treeNode9.Tag = "border";
            treeNode9.Text = "Border";
            treeNode10.Name = "NodeChalet";
            treeNode10.Tag = "chalet";
            treeNode10.Text = "Chalet";
            treeNode11.Name = "NodeClubHouse";
            treeNode11.Tag = "club";
            treeNode11.Text = "Club House";
            treeNode12.Name = "NodeCoastline";
            treeNode12.Tag = "coastline";
            treeNode12.Text = "Coastline";
            treeNode13.Name = "NodeConsulate";
            treeNode13.Tag = "consulate";
            treeNode13.Text = "Consulate";
            treeNode14.Name = "NodeFavela";
            treeNode14.Tag = "favela";
            treeNode14.Text = "Favela";
            treeNode15.Name = "NodeFortress";
            treeNode15.Tag = "fortress";
            treeNode15.Text = "Fortress";
            treeNode16.Name = "NodeOldHereford";
            treeNode16.Tag = "oldhereford";
            treeNode16.Text = "Hereford (Old)";
            treeNode17.Name = "NodeHerefordRework";
            treeNode17.Tag = "hereford";
            treeNode17.Text = "Hereford (Rework)";
            treeNode18.Name = "NodeHouse";
            treeNode18.Tag = "house";
            treeNode18.Text = "House";
            treeNode19.Name = "NodeKanal";
            treeNode19.Tag = "kanal";
            treeNode19.Text = "Kanal";
            treeNode20.Name = "NodeOregon";
            treeNode20.Tag = "oregon";
            treeNode20.Text = "Oregon";
            treeNode21.Name = "NodeOutback";
            treeNode21.Tag = "outback";
            treeNode21.Text = "Outback";
            treeNode22.Name = "NodePresidentialPlane";
            treeNode22.Tag = "plane";
            treeNode22.Text = "Presidential Plane";
            treeNode23.Name = "NodeRussianKafe";
            treeNode23.Tag = "cafe";
            treeNode23.Text = "Russian Kafe";
            treeNode24.Name = "NodeSkyscraper";
            treeNode24.Tag = "skyscraper";
            treeNode24.Text = "Skyscraper";
            treeNode25.Name = "NodeThemePark";
            treeNode25.Tag = "theme";
            treeNode25.Text = "Theme Park";
            treeNode26.Name = "NodeTower";
            treeNode26.Tag = "tower";
            treeNode26.Text = "Tower";
            treeNode27.Name = "NodeVilla";
            treeNode27.Tag = "villa";
            treeNode27.Text = "Villa";
            treeNode28.Name = "NodeYacht";
            treeNode28.Tag = "yacht";
            treeNode28.Text = "Yacht";
            this.treeViewMap.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28});
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
            treeNode29.Name = "NodeHostage";
            treeNode29.Tag = "hostage";
            treeNode29.Text = "Hostage";
            treeNode30.Name = "NodeSecureArea";
            treeNode30.Tag = "secure";
            treeNode30.Text = "Secure Area";
            treeNode31.Name = "NodeBomb";
            treeNode31.Tag = "bomb";
            treeNode31.Text = "Bomb";
            treeNode32.Name = "NodeWarmup";
            treeNode32.Tag = "warmup";
            treeNode32.Text = "Warmup";
            treeNode33.Name = "NodeGoldenGun";
            treeNode33.Tag = "goldengun";
            treeNode33.Text = "Golden Gun";
            treeNode34.Name = "NodeBombNoPrep";
            treeNode34.Tag = "bombnoprep";
            treeNode34.Text = "Bomb - No Prep Phase";
            treeNode35.Name = "NodeMultiplayer";
            treeNode35.Tag = "Multiplayer";
            treeNode35.Text = "Multiplayer";
            treeNode36.Name = "NodePHNormal";
            treeNode36.Tag = "normal";
            treeNode36.Text = "Normal";
            treeNode37.Name = "NodePHHard";
            treeNode37.Tag = "hard";
            treeNode37.Text = "Hard";
            treeNode38.Name = "NodePHRealistic";
            treeNode38.Tag = "realistic";
            treeNode38.Text = "Realistic";
            treeNode39.Name = "NodePH";
            treeNode39.Tag = "protect";
            treeNode39.Text = "Protect Hostage";
            treeNode40.Name = "NodeEHNormal";
            treeNode40.Tag = "normal";
            treeNode40.Text = "Normal";
            treeNode41.Name = "NodeEHHard";
            treeNode41.Tag = "hard";
            treeNode41.Text = "Hard";
            treeNode42.Name = "NodeEHRealistic";
            treeNode42.Tag = "realistic";
            treeNode42.Text = "Realistic";
            treeNode43.Name = "NodeEH";
            treeNode43.Tag = "extract";
            treeNode43.Text = "Extract Hostage";
            treeNode44.Name = "NodeDBNormal";
            treeNode44.Tag = "normal";
            treeNode44.Text = "Normal";
            treeNode45.Name = "NodeDBHard";
            treeNode45.Tag = "hard";
            treeNode45.Text = "Hard";
            treeNode46.Name = "NodeDBRealistic";
            treeNode46.Tag = "realistic";
            treeNode46.Text = "Realistic";
            treeNode47.Name = "NodeDB";
            treeNode47.Tag = "disarm";
            treeNode47.Text = "Disarm Bomb";
            treeNode48.Name = "NodeENormal";
            treeNode48.Tag = "normal";
            treeNode48.Text = "Normal";
            treeNode49.Name = "NodeEHard";
            treeNode49.Tag = "hard";
            treeNode49.Text = "Hard";
            treeNode50.Name = "NodeERealistic";
            treeNode50.Tag = "realistic";
            treeNode50.Text = "Realistic";
            treeNode51.Name = "NodeE";
            treeNode51.Tag = "elimination";
            treeNode51.Text = "Elimination";
            treeNode52.Name = "NodeThunt";
            treeNode52.Tag = "TerroristHunt";
            treeNode52.Text = "Terrorist Hunt";
            treeNode53.Name = "NodeMMCHostage";
            treeNode53.Tag = "hostage";
            treeNode53.Text = "Hostage";
            treeNode54.Name = "NodeMMCSecureArea";
            treeNode54.Tag = "secure";
            treeNode54.Text = "Secure Area";
            treeNode55.Name = "NodeMMCBomb";
            treeNode55.Tag = "bomb";
            treeNode55.Text = "Bomb";
            treeNode56.Name = "NodeCasual";
            treeNode56.Tag = "casual";
            treeNode56.Text = "Casual";
            treeNode57.Name = "NodeMMRHostage";
            treeNode57.Tag = "hostage";
            treeNode57.Text = "Hostage";
            treeNode58.Name = "NodeMMRSecureArea";
            treeNode58.Tag = "secure";
            treeNode58.Text = "Secure Area";
            treeNode59.Name = "NodeMMRBomb";
            treeNode59.Tag = "bomb";
            treeNode59.Text = "Bomb";
            treeNode60.Name = "NodeRanked";
            treeNode60.Tag = "ranked";
            treeNode60.Text = "Ranked";
            treeNode61.Name = "NodeMatchmaking";
            treeNode61.Tag = "Matchmaking";
            treeNode61.Text = "Match Making";
            this.treeViewGameMode.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode52,
            treeNode61});
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
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(547, 421);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tav\'s Tab";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 132);
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
    }
}