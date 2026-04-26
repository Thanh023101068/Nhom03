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

namespace ManHinhChinhQuanTri
{
    public partial class frmMHQT : MaterialForm
    {
        public frmMHQT()
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

        private void frmMHQT_Load(object sender, EventArgs e)
        {
            lblAdminInfo.Text = "Xin chào: Đặng Lý Quốc Thành (Quản trị viên)";

            cardUser.Click += (s, ev) => OpenForm(new frmPhanQuyen());
            cardRoom.Click += (s, ev) => OpenForm(new frmQTPhong());
            cardConfig.Click += (s, ev) => OpenForm(new frmQTConfig());
            cardData.Click += (s, ev) => OpenForm(new frmQTData());
            cardReport.Click += (s, ev) => OpenForm(new frmQTReport());

            btnLogOut.Click += (s, ev) => {
                if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    this.Close();
            };
        }

        private void OpenForm(Form childForm)
        {
            childForm.ShowDialog();
        }

    }
}
