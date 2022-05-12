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
            System.Windows.Forms.TreeNode treeNode245 = new System.Windows.Forms.TreeNode("Golden Gun");
            System.Windows.Forms.TreeNode treeNode246 = new System.Windows.Forms.TreeNode("Grand Larceny");
            System.Windows.Forms.TreeNode treeNode247 = new System.Windows.Forms.TreeNode("M.U.T.E Protocol");
            System.Windows.Forms.TreeNode treeNode248 = new System.Windows.Forms.TreeNode("Attrition");
            System.Windows.Forms.TreeNode treeNode249 = new System.Windows.Forms.TreeNode("Reverse Hostage");
            System.Windows.Forms.TreeNode treeNode250 = new System.Windows.Forms.TreeNode("Sugar Fright");
            System.Windows.Forms.TreeNode treeNode251 = new System.Windows.Forms.TreeNode("Bank");
            System.Windows.Forms.TreeNode treeNode252 = new System.Windows.Forms.TreeNode("Bartlett University");
            System.Windows.Forms.TreeNode treeNode253 = new System.Windows.Forms.TreeNode("Border");
            System.Windows.Forms.TreeNode treeNode254 = new System.Windows.Forms.TreeNode("Chalet");
            System.Windows.Forms.TreeNode treeNode255 = new System.Windows.Forms.TreeNode("Club House");
            System.Windows.Forms.TreeNode treeNode256 = new System.Windows.Forms.TreeNode("Coastline");
            System.Windows.Forms.TreeNode treeNode257 = new System.Windows.Forms.TreeNode("Consulate");
            System.Windows.Forms.TreeNode treeNode258 = new System.Windows.Forms.TreeNode("Favela");
            System.Windows.Forms.TreeNode treeNode259 = new System.Windows.Forms.TreeNode("Fortress");
            System.Windows.Forms.TreeNode treeNode260 = new System.Windows.Forms.TreeNode("Hereford (Old)");
            System.Windows.Forms.TreeNode treeNode261 = new System.Windows.Forms.TreeNode("Hereford (Rework)");
            System.Windows.Forms.TreeNode treeNode262 = new System.Windows.Forms.TreeNode("House");
            System.Windows.Forms.TreeNode treeNode263 = new System.Windows.Forms.TreeNode("Kanal");
            System.Windows.Forms.TreeNode treeNode264 = new System.Windows.Forms.TreeNode("Oregon");
            System.Windows.Forms.TreeNode treeNode265 = new System.Windows.Forms.TreeNode("Outback");
            System.Windows.Forms.TreeNode treeNode266 = new System.Windows.Forms.TreeNode("Presidential Plane");
            System.Windows.Forms.TreeNode treeNode267 = new System.Windows.Forms.TreeNode("Russian Kafe");
            System.Windows.Forms.TreeNode treeNode268 = new System.Windows.Forms.TreeNode("Skyscraper");
            System.Windows.Forms.TreeNode treeNode269 = new System.Windows.Forms.TreeNode("Theme Park");
            System.Windows.Forms.TreeNode treeNode270 = new System.Windows.Forms.TreeNode("Tower");
            System.Windows.Forms.TreeNode treeNode271 = new System.Windows.Forms.TreeNode("Villa");
            System.Windows.Forms.TreeNode treeNode272 = new System.Windows.Forms.TreeNode("Yacht");
            System.Windows.Forms.TreeNode treeNode273 = new System.Windows.Forms.TreeNode("Hostage");
            System.Windows.Forms.TreeNode treeNode274 = new System.Windows.Forms.TreeNode("Secure Area");
            System.Windows.Forms.TreeNode treeNode275 = new System.Windows.Forms.TreeNode("Bomb");
            System.Windows.Forms.TreeNode treeNode276 = new System.Windows.Forms.TreeNode("Warmup");
            System.Windows.Forms.TreeNode treeNode277 = new System.Windows.Forms.TreeNode("Golden Gun");
            System.Windows.Forms.TreeNode treeNode278 = new System.Windows.Forms.TreeNode("Bomb - No Prep Phase");
            System.Windows.Forms.TreeNode treeNode279 = new System.Windows.Forms.TreeNode("Multiplayer", new System.Windows.Forms.TreeNode[] {
            treeNode273,
            treeNode274,
            treeNode275,
            treeNode276,
            treeNode277,
            treeNode278});
            System.Windows.Forms.TreeNode treeNode280 = new System.Windows.Forms.TreeNode("Normal");
            System.Windows.Forms.TreeNode treeNode281 = new System.Windows.Forms.TreeNode("Hard");
            System.Windows.Forms.TreeNode treeNode282 = new System.Windows.Forms.TreeNode("Realistic");
            System.Windows.Forms.TreeNode treeNode283 = new System.Windows.Forms.TreeNode("Protect Hostage", new System.Windows.Forms.TreeNode[] {
            treeNode280,
            treeNode281,
            treeNode282});
            System.Windows.Forms.TreeNode treeNode284 = new System.Windows.Forms.TreeNode("Normal");
            System.Windows.Forms.TreeNode treeNode285 = new System.Windows.Forms.TreeNode("Hard");
            System.Windows.Forms.TreeNode treeNode286 = new System.Windows.Forms.TreeNode("Realistic");
            System.Windows.Forms.TreeNode treeNode287 = new System.Windows.Forms.TreeNode("Extract Hostage", new System.Windows.Forms.TreeNode[] {
            treeNode284,
            treeNode285,
            treeNode286});
            System.Windows.Forms.TreeNode treeNode288 = new System.Windows.Forms.TreeNode("Normal");
            System.Windows.Forms.TreeNode treeNode289 = new System.Windows.Forms.TreeNode("Hard");
            System.Windows.Forms.TreeNode treeNode290 = new System.Windows.Forms.TreeNode("Realistic");
            System.Windows.Forms.TreeNode treeNode291 = new System.Windows.Forms.TreeNode("Disarm Bomb", new System.Windows.Forms.TreeNode[] {
            treeNode288,
            treeNode289,
            treeNode290});
            System.Windows.Forms.TreeNode treeNode292 = new System.Windows.Forms.TreeNode("Normal");
            System.Windows.Forms.TreeNode treeNode293 = new System.Windows.Forms.TreeNode("Hard");
            System.Windows.Forms.TreeNode treeNode294 = new System.Windows.Forms.TreeNode("Realistic");
            System.Windows.Forms.TreeNode treeNode295 = new System.Windows.Forms.TreeNode("Elimination", new System.Windows.Forms.TreeNode[] {
            treeNode292,
            treeNode293,
            treeNode294});
            System.Windows.Forms.TreeNode treeNode296 = new System.Windows.Forms.TreeNode("Terrorist Hunt", new System.Windows.Forms.TreeNode[] {
            treeNode283,
            treeNode287,
            treeNode291,
            treeNode295});
            System.Windows.Forms.TreeNode treeNode297 = new System.Windows.Forms.TreeNode("Hostage");
            System.Windows.Forms.TreeNode treeNode298 = new System.Windows.Forms.TreeNode("Secure Area");
            System.Windows.Forms.TreeNode treeNode299 = new System.Windows.Forms.TreeNode("Bomb");
            System.Windows.Forms.TreeNode treeNode300 = new System.Windows.Forms.TreeNode("Casual", new System.Windows.Forms.TreeNode[] {
            treeNode297,
            treeNode298,
            treeNode299});
            System.Windows.Forms.TreeNode treeNode301 = new System.Windows.Forms.TreeNode("Hostage");
            System.Windows.Forms.TreeNode treeNode302 = new System.Windows.Forms.TreeNode("Secure Area");
            System.Windows.Forms.TreeNode treeNode303 = new System.Windows.Forms.TreeNode("Bomb");
            System.Windows.Forms.TreeNode treeNode304 = new System.Windows.Forms.TreeNode("Ranked", new System.Windows.Forms.TreeNode[] {
            treeNode301,
            treeNode302,
            treeNode303});
            System.Windows.Forms.TreeNode treeNode305 = new System.Windows.Forms.TreeNode("Match Making", new System.Windows.Forms.TreeNode[] {
            treeNode300,
            treeNode304});
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            treeNode245.Name = "NodeGoldenGunVE";
            treeNode245.Tag = "goldengun";
            treeNode245.Text = "Golden Gun";
            treeNode246.Name = "NodeGrandLarceny";
            treeNode246.Tag = "grandlarceny";
            treeNode246.Text = "Grand Larceny";
            treeNode247.Name = "NodeMute";
            treeNode247.Tag = "mute";
            treeNode247.Text = "M.U.T.E Protocol";
            treeNode248.Name = "NodeAttrition";
            treeNode248.Tag = "attrition";
            treeNode248.Text = "Attrition";
            treeNode249.Name = "NodeReverseHostage";
            treeNode249.Tag = "reversehostage";
            treeNode249.Text = "Reverse Hostage";
            treeNode250.Name = "NodeSugarFright";
            treeNode250.Tag = "sugarfright";
            treeNode250.Text = "Sugar Fright";
            this.treeViewEvents.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode245,
            treeNode246,
            treeNode247,
            treeNode248,
            treeNode249,
            treeNode250});
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
            treeNode251.Name = "NodeBank";
            treeNode251.Tag = "bank";
            treeNode251.Text = "Bank";
            treeNode252.Name = "NodeBartlettUniversity";
            treeNode252.Tag = "university";
            treeNode252.Text = "Bartlett University";
            treeNode253.Name = "NodeBorder";
            treeNode253.Tag = "border";
            treeNode253.Text = "Border";
            treeNode254.Name = "NodeChalet";
            treeNode254.Tag = "chalet";
            treeNode254.Text = "Chalet";
            treeNode255.Name = "NodeClubHouse";
            treeNode255.Tag = "club";
            treeNode255.Text = "Club House";
            treeNode256.Name = "NodeCoastline";
            treeNode256.Tag = "coastline";
            treeNode256.Text = "Coastline";
            treeNode257.Name = "NodeConsulate";
            treeNode257.Tag = "consulate";
            treeNode257.Text = "Consulate";
            treeNode258.Name = "NodeFavela";
            treeNode258.Tag = "favela";
            treeNode258.Text = "Favela";
            treeNode259.Name = "NodeFortress";
            treeNode259.Tag = "fortress";
            treeNode259.Text = "Fortress";
            treeNode260.Name = "NodeOldHereford";
            treeNode260.Tag = "oldhereford";
            treeNode260.Text = "Hereford (Old)";
            treeNode261.Name = "NodeHerefordRework";
            treeNode261.Tag = "hereford";
            treeNode261.Text = "Hereford (Rework)";
            treeNode262.Name = "NodeHouse";
            treeNode262.Tag = "house";
            treeNode262.Text = "House";
            treeNode263.Name = "NodeKanal";
            treeNode263.Tag = "kanal";
            treeNode263.Text = "Kanal";
            treeNode264.Name = "NodeOregon";
            treeNode264.Tag = "oregon";
            treeNode264.Text = "Oregon";
            treeNode265.Name = "NodeOutback";
            treeNode265.Tag = "outback";
            treeNode265.Text = "Outback";
            treeNode266.Name = "NodePresidentialPlane";
            treeNode266.Tag = "plane";
            treeNode266.Text = "Presidential Plane";
            treeNode267.Name = "NodeRussianKafe";
            treeNode267.Tag = "cafe";
            treeNode267.Text = "Russian Kafe";
            treeNode268.Name = "NodeSkyscraper";
            treeNode268.Tag = "skyscraper";
            treeNode268.Text = "Skyscraper";
            treeNode269.Name = "NodeThemePark";
            treeNode269.Tag = "theme";
            treeNode269.Text = "Theme Park";
            treeNode270.Name = "NodeTower";
            treeNode270.Tag = "tower";
            treeNode270.Text = "Tower";
            treeNode271.Name = "NodeVilla";
            treeNode271.Tag = "villa";
            treeNode271.Text = "Villa";
            treeNode272.Name = "NodeYacht";
            treeNode272.Tag = "yacht";
            treeNode272.Text = "Yacht";
            this.treeViewMap.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode251,
            treeNode252,
            treeNode253,
            treeNode254,
            treeNode255,
            treeNode256,
            treeNode257,
            treeNode258,
            treeNode259,
            treeNode260,
            treeNode261,
            treeNode262,
            treeNode263,
            treeNode264,
            treeNode265,
            treeNode266,
            treeNode267,
            treeNode268,
            treeNode269,
            treeNode270,
            treeNode271,
            treeNode272});
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
            treeNode273.Name = "NodeHostage";
            treeNode273.Tag = "hostage";
            treeNode273.Text = "Hostage";
            treeNode274.Name = "NodeSecureArea";
            treeNode274.Tag = "secure";
            treeNode274.Text = "Secure Area";
            treeNode275.Name = "NodeBomb";
            treeNode275.Tag = "bomb";
            treeNode275.Text = "Bomb";
            treeNode276.Name = "NodeWarmup";
            treeNode276.Tag = "warmup";
            treeNode276.Text = "Warmup";
            treeNode277.Name = "NodeGoldenGun";
            treeNode277.Tag = "goldengun";
            treeNode277.Text = "Golden Gun";
            treeNode278.Name = "NodeBombNoPrep";
            treeNode278.Tag = "bombnoprep";
            treeNode278.Text = "Bomb - No Prep Phase";
            treeNode279.Name = "NodeMultiplayer";
            treeNode279.Tag = "Multiplayer";
            treeNode279.Text = "Multiplayer";
            treeNode280.Name = "NodePHNormal";
            treeNode280.Tag = "normal";
            treeNode280.Text = "Normal";
            treeNode281.Name = "NodePHHard";
            treeNode281.Tag = "hard";
            treeNode281.Text = "Hard";
            treeNode282.Name = "NodePHRealistic";
            treeNode282.Tag = "realistic";
            treeNode282.Text = "Realistic";
            treeNode283.Name = "NodePH";
            treeNode283.Tag = "protect";
            treeNode283.Text = "Protect Hostage";
            treeNode284.Name = "NodeEHNormal";
            treeNode284.Tag = "normal";
            treeNode284.Text = "Normal";
            treeNode285.Name = "NodeEHHard";
            treeNode285.Tag = "hard";
            treeNode285.Text = "Hard";
            treeNode286.Name = "NodeEHRealistic";
            treeNode286.Tag = "realistic";
            treeNode286.Text = "Realistic";
            treeNode287.Name = "NodeEH";
            treeNode287.Tag = "extract";
            treeNode287.Text = "Extract Hostage";
            treeNode288.Name = "NodeDBNormal";
            treeNode288.Tag = "normal";
            treeNode288.Text = "Normal";
            treeNode289.Name = "NodeDBHard";
            treeNode289.Tag = "hard";
            treeNode289.Text = "Hard";
            treeNode290.Name = "NodeDBRealistic";
            treeNode290.Tag = "realistic";
            treeNode290.Text = "Realistic";
            treeNode291.Name = "NodeDB";
            treeNode291.Tag = "disarm";
            treeNode291.Text = "Disarm Bomb";
            treeNode292.Name = "NodeENormal";
            treeNode292.Tag = "normal";
            treeNode292.Text = "Normal";
            treeNode293.Name = "NodeEHard";
            treeNode293.Tag = "hard";
            treeNode293.Text = "Hard";
            treeNode294.Name = "NodeERealistic";
            treeNode294.Tag = "realistic";
            treeNode294.Text = "Realistic";
            treeNode295.Name = "NodeE";
            treeNode295.Tag = "elimination";
            treeNode295.Text = "Elimination";
            treeNode296.Name = "NodeThunt";
            treeNode296.Tag = "TerroristHunt";
            treeNode296.Text = "Terrorist Hunt";
            treeNode297.Name = "NodeMMCHostage";
            treeNode297.Tag = "hostage";
            treeNode297.Text = "Hostage";
            treeNode298.Name = "NodeMMCSecureArea";
            treeNode298.Tag = "secure";
            treeNode298.Text = "Secure Area";
            treeNode299.Name = "NodeMMCBomb";
            treeNode299.Tag = "bomb";
            treeNode299.Text = "Bomb";
            treeNode300.Name = "NodeCasual";
            treeNode300.Tag = "casual";
            treeNode300.Text = "Casual";
            treeNode301.Name = "NodeMMRHostage";
            treeNode301.Tag = "hostage";
            treeNode301.Text = "Hostage";
            treeNode302.Name = "NodeMMRSecureArea";
            treeNode302.Tag = "secure";
            treeNode302.Text = "Secure Area";
            treeNode303.Name = "NodeMMRBomb";
            treeNode303.Tag = "bomb";
            treeNode303.Text = "Bomb";
            treeNode304.Name = "NodeRanked";
            treeNode304.Tag = "ranked";
            treeNode304.Text = "Ranked";
            treeNode305.Name = "NodeMatchmaking";
            treeNode305.Tag = "Matchmaking";
            treeNode305.Text = "Match Making";
            this.treeViewGameMode.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode279,
            treeNode296,
            treeNode305});
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
            this.tabPage5.Controls.Add(this.checkBox1);
            this.tabPage5.Controls.Add(this.button1);
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
    }
}