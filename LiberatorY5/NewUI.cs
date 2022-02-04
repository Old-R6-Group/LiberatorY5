using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace LiberatorY5
{
    public partial class NewUI : MaterialForm
    {
        public NewUI()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            /*
            materialSkinManager.ROBOTO_MEDIUM_10 = new Font("Ubisoft Sans", 10);
            materialSkinManager.ROBOTO_MEDIUM_11 = new Font("Ubisoft Sans", 11);
            materialSkinManager.ROBOTO_MEDIUM_12 = new Font("Ubisoft Sans", 12);
            materialSkinManager.ROBOTO_REGULAR_11 = new Font("Ubisoft Sans", 11);
            */
        }

        private void NewUI_Load(object sender, EventArgs e)
        {
        }
    }
}
