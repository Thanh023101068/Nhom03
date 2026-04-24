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

namespace QLPM_PTH
{
    public partial class frmGiangVien : MaterialForm
    {
        public frmGiangVien()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo500,
                Primary.Indigo700,
                Primary.Indigo500,
                Accent.Blue700,
                TextShade.WHITE
            );
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            String role = "GV";
            String fullname = "Huỳnh Thị Nhật Hằng";
            String gv = "Giảng Viên";

            materialLabel1.Text = $"{role} | {fullname} | {gv}";
        }
    }
}
