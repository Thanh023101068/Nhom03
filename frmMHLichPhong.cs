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

namespace MHSV
{
    public partial class frmMHLichPhong : MaterialForm
    {
        public frmMHLichPhong()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                Primary.Indigo500,
                Primary.Indigo700,
                Primary.Indigo500,
                Accent.Blue700,
                TextShade.WHITE
            );
        }

        private void frmMHLichPhong_Load(object sender, EventArgs e)
        {

        }

    }
}
