using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Memory;

namespace LiberatorY5
{
    public partial class SL : MaterialForm
    {
        static private Mem mem;
        static readonly string r6processname = "RainbowSix.exe";
        static readonly string r6mem = "RainbowSix.exe+";
        string LastPlace = "GameData";
        string CurrentPlace = "GameData";
        string ModeName, ChooosedName, OffsetList = "";
        string[] AddedToOffset = { };
        public string codeFile = Application.StartupPath + @"\inventory.ini";
        public SL(Mem m)
        {
            mem = m;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void SL_Load(object sender, EventArgs e)
        {
            LoadGameDatas();
        }

        #region LoadThings
        private void LoadGameDatas()
        { 
            BundleDataViewer.Nodes.Clear();
            for (int index = 0; index < GameData.Length; index++)
            {
                var item = GameData[index];
                BundleDataViewer.Nodes.Add(item, item);
            }
            for (int index = 0; index < GameData_Normal.Length; index++)
            {
                var item = GameData_Normal[index];
                BundleDataViewer.Nodes[0].Nodes.Add(item, item);
            }
            for (int index = 0; index < GameData_Legacy.Length; index++)
            {
                var item = GameData_Legacy[index];
                BundleDataViewer.Nodes[1].Nodes.Add(item, item);
            }
            for (int index = 0; index < GameData_Situation.Length; index++)
            {
                var item = GameData_Situation[index];
                BundleDataViewer.Nodes[2].Nodes.Add(item, item);
            }
            for (int index = 0; index < GameData_Telly.Length; index++)
            {
                var item = GameData_Telly[index];
                BundleDataViewer.Nodes[3].Nodes.Add(item, item);
            }
            for (int index = 0; index < GameData_Golden.Length; index++)
            {
                var item = GameData_Golden[index];
                BundleDataViewer.Nodes[4].Nodes.Add(item, item);
            }
        }
        private void LoadArray(string[] array)
        {
            BundleDataViewer.Nodes.Clear();
            for (int index = 0; index < array.Length; index++)
            {
                var item = array[index];
                BundleDataViewer.Nodes.Add(item, item);
            }
            BundleDataViewer.Nodes.Add("Back", "Back");
        }
        private void LoadArrayIn(string[] array,int idx)
        {
            for (int index = 0; index < array.Length; index++)
            {
                var item = array[index];
                BundleDataViewer.Nodes[idx].Nodes.Add(item, item);
            }
        }
        #endregion
        #region DataList

        //GameData stuff
        private static string[] GameData = { "Normal Mode", "Legacy Mode", "Sugar Fright Mode", "Situation Mode", "Golden Gun Mode" };
        private static string[] GameData_Normal = { "Weapons", "Gadgets", "GadgetProps", "Operators", "Hostages", "InstanceOf Weapons", "InstanceOf Shield Gadgets", "Charms", "Weapon Skins", "Weapon Attachment Sets", "Weapon Attachment Skins" };
        private static string[] GameData_Legacy = { "Weapons", "Gadgets", "Operators" };
        private static string[] GameData_Telly = { "Gadgets", "Operators", "InstanceOf Weapons" };
        private static string[] GameData_Situation = { "Operators", "InstanceOf Weapons" };
        private static string[] GameData_Golden = { "Weapons", "Gadgets", "Operators" };

        //NormalMode
        public static string[] NormalMode_Weapons = { "More", "Weapon", "Coming" };
        public static string[] NormalMode_Gadgets = { "one", "two", "three" };
        public static string[] NormalMode_GadgetProps = { "one", "two", "three" };
        public static string[] NormalMode_Operators = { "one", "two", "three" };
        public static string[] NormalMode_Hostages = { "one", "two", "three" };
        public static string[] NormalMode_InstanceOfWeapons = { "one", "two", "three" };
        public static string[] NormalMode_InstanceOfShieldGadgets = { "CCE Shield", "Extendable Shield" };
        public static string[] NormalMode_Charms = { "one", "two", "three" };
        public static string[] NormalMode_WeaponSkins = { "one", "two", "three" };
        public static string[] NormalMode_WeaponAttachmentSets = { "one", "two", "three" };
        public static string[] NormalMode_WeaponAttachmentSkins = { "one", "two", "three" };

        //LegacyMode
        public static string[] LegacyMode_Weapons = { "MP7", "G36C", "416-C" };
        public static string[] LegacyMode_Gadgets = { "Mounted LMG", "Sheet Charge", "Frag" };
        public static string[] LegacyMode_Operators = { "Bandit", "Fuze", "Glaz", "IQ", "Jager", "Montagne", "Kapkan", "Thacher", "Mute", "Pulse", "Recruit (Def)", "Recruit (Atk)", "Ash", "Twitch", "Thermite", "Tachanka", "Smoke", "Rook", "Sledge", "Blitz", "Castle", "Doc" };

        //Telly
        public static string[] TellyMode_Gadgets = { "one", "two", "three" };
        public static string[] TellyMode_Operators = { "one", "two", "three" };
        public static string[] TellyMode_InstanceOfWeapons = { "one", "two", "three" };

        //Situation
        public static string[] SituationMode_Operators = { "FBI-SWAT", "HIGHVALUETARGET_ATK", "CQCBASICS_ATK", "SUBURBANEXTRACTION_ATK" };
        public static string[] SituationMode_InstanceOfWeapons = { "F2", "P9", "P226 MK 25", "57 USG", "R4-C" };

        //Telly
        public static string[] GoldenMode_Weapons = { "one", "two", "three" };
        public static string[] GoldenMode_Gadgets = { "one", "two", "three" };
        public static string[] GoldenMode_Operators = { "one", "two", "three" };

        //Data
        public static string[] GadgetData = { "Forge ID", "Points to List Number", "Psudo Number List" };
        public static string[] WeaponData = { "Forge ID", "Points to List Number", "Psudo Number List", "Attachments", "Selected Weapon Stuffs", "Weapon Parameters", "Weapon Magazines", "Weapon Skins", "Weapon Attachment Skins" };
        public static string[] OperatorData = { "Forge ID", "Headgears", "Uniforms", "Primary Gun List", "Secondary Gun List", "Terciary Gun", "Primary Gadget (List?)", "Secondary Gadget (List?)", "Drone/Barricade Gadget [Only one]", "Rappel Gadget", "Knife Model", "Elite Stuff", "Character Parameters", "Hacked Phone Prop", "Selected Stuffs" };

        //Selected Stuff
        public static string[] SelectedWeaponStuffs = { "Scope", "Barrel", "Grip", "UnderBarrel", "Weapon Parameter", "Weapon Skin", "Attachment Skin" };
        public static string[] SelectedStuffs = { "Primary Weapon", "Secondary Weapon", "Primary Gadget", "Secondary Gadget", "Unifrom", "HeadGear", "InstanceOf Weapon" };

        //Others
        public static string[] Attachments = { "Scopes", "Barrels", "Grips", "UnderBarrels" };
        public static string[] MakeOther = { "Attachments" };
        public static string[] EnabledStuff = { "SelectedWeaponStuffs", "SelectedStuffs","Attachments", "GadgetData","WeaponData","OperatorData" };
        #endregion
        private void BundleDataViewer_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                labelData.Text = e.Node.Name;
                string Parent = e.Node.Parent.Name.Replace(" ", "");
                switch (Parent)
                {
                    case "SugarFrightMode":
                        Parent = "TellyMode";
                        break;
                    case "GoldenGunMode":
                        Parent = "GoldenMode";
                        break;
                    default:
                        break;
                }
                string Child = e.Node.Name.Replace(" ", "");
                string thingy = Parent + "_" + Child;
                ModeName = Parent;
                ChooosedName = Child;
                //logs.WriteLog(thingy);
                string[] vals = (string[])this.GetType().GetField(thingy,
                    BindingFlags.Instance | BindingFlags.Static |
                    BindingFlags.Public | BindingFlags.NonPublic).GetValue(this);

                CurrentPlace = thingy;
                LoadArray(vals);
            }
            else
            {
                if (e.Node.Name == "Back")
                {
                    LoadGameDatas(); // TMP Solution
                    labelData.Text = "Game Datas";
                }
                else
                {
                    logs.WriteLog(e.Node.Name);
                    string nodeclean = e.Node.Name.Replace(" ", "");
                    string current_last, full;
                    if (CurrentPlace.Contains("_"))
                    {
                        current_last = CurrentPlace.Split('_')[1];
                    }
                    else
                    {
                        current_last = nodeclean;
                    }

                    switch (current_last)
                    {
                        case "InstanceOfShieldGadgets":
                            full = "GadgetData";
                            break;
                        case "GadgetProps":
                            full = "GadgetData";
                            break;
                        case "Hostages":
                            full = "OperatorData";
                            break;
                        case "InstanceOfWeapons":
                            full = "WeaponData";
                            break;
                        case "Gadgets":
                            full = "GadgetData";
                            break;
                        case "Weapons":
                            full = "WeaponData";
                            break;
                        case "Operators":
                            full = "OperatorData";
                            break;
                        default:
                            full = current_last;
                            break;
                    }
                    if (EnabledStuff.Contains(full))
                    {
                        logs.SpecificLog(full,"xd");
                        labelData.Text = nodeclean;
                        string[] vals = (string[])this.GetType().GetField(full,
                        BindingFlags.Instance | BindingFlags.Static |
                        BindingFlags.Public | BindingFlags.NonPublic).GetValue(this);
                        LastPlace = CurrentPlace;
                        CurrentPlace = nodeclean;
                        LoadArray(vals);
                    }

                }
            }

        }

        private void ReadThis_Click(object sender, EventArgs e)
        {
            int indx = BundleDataViewer.SelectedNode.Index;
            string GetThis = BundleDataViewer.SelectedNode.Name.Replace(" ", "");
            var CodeToGet = ModeName + "_" + ChooosedName;
            logs.WriteLog(CodeToGet + " " + GetThis);
            if (LastPlace == CurrentPlace)
            { 
                //Todo
            }
            if (!AddedToOffset.Contains(GetThis))
            {
                OffsetList = OffsetList + "," + IndexToHex(indx);
                AddedToOffset.Append(GetThis);
            }
            logs.WriteLog(OffsetList);
            string backmything = mem.LoadCode(CodeToGet, codeFile);
            long readaddr =  mem.ReadLong(backmything + OffsetList);
            richTextBox1.Text = string.Format("{0:X}", readaddr);
        }
        private string IndexToHex(int indx)
        {
            if (indx == 0)
                return "0x0";
            else
            {
                int hex = indx * 8;
                return string.Format("0x{0:X}", hex);
            }
        }
    }
}
