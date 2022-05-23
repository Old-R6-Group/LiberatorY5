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

        private static string[] GameData = { "Normal Mode","Legacy Mode","Situation Mode","Sugar Fright Mode","Golden Gun Mode"};
        private static string[] GameData_Normal = { "Master Weapons", "Master Gadgets", "GadgetProps", "Operators", "Hostages", "InstanceOf Weapons", "InstanceOf Shield Gadgets", "Charms", "Weapon Skins", "Weapon Attachment Sets", "Weapon Attachment Skins" };
        private static string[] GameData_Legacy = { "Weapons", "Gadgets", "Operators" };
        private static string[] GameData_Situation = { "Operators", "InstanceOf Weapons" };
        private static string[] GameData_Telly = { "Gadgets", "Operators", "InstanceOf Weapons" };
        private static string[] GameData_Golden = { "Weapons", "Gadgets", "Operators" };

        public static string[] NormalMode_MasterWeapons = { "More", "Weapon", "Coming" };
        public static string[] NormalMode_InstanceOfShieldGadgets = { "CCE Shield", "Extendable Shield" };

        private void BundleDataViewer_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                labelData.Text = e.Node.Name;
                string Parent = e.Node.Parent.Name.Replace(" ", "");
                string Child = e.Node.Name.Replace(" ", "");
                string thingy = Parent + "_" + Child;
                //logs.WriteLog(thingy);
                string[] vals = (string[])this.GetType().GetField(thingy,
                    BindingFlags.Instance | BindingFlags.Static |
                    BindingFlags.Public | BindingFlags.NonPublic).GetValue(this);
                LastPlace = Parent;
                LoadArray(vals);
            }
            else
            {
                if (e.Node.Name == "Back")
                {
                    LoadGameDatas(); // TMP Solution
                    labelData.Text = "Game Datas";
                }
            }

        }
    }
}
