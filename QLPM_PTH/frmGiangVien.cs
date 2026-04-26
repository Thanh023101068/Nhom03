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

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
            frmLichPhongHoc frmLich = new frmLichPhongHoc();
            frmLich.Show();

        }

        private void materialCard2_Click(object sender, EventArgs e)
        {
            frmLichPhongHoc frmLich = new frmLichPhongHoc();
            frmLich.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmLichPhongHoc frmLich = new frmLichPhongHoc();
            frmLich.Show();
        }

        private void materialCard3_Click(object sender, EventArgs e)
        {
            frmQLYC frmYc = new frmQLYC();
            frmYc.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmQLYC frmYc = new frmQLYC();
            frmYc.Show();
        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {
            frmQLYC frmYc = new frmQLYC();
            frmYc.Show();
        }

        private void materialCard4_Click(object sender, EventArgs e)
        {
            frmSuDungThietBi frmSd = new frmSuDungThietBi();
            frmSd.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmSuDungThietBi frmSd = new frmSuDungThietBi();
            frmSd.Show();
        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {
            frmSuDungThietBi frmSd = new frmSuDungThietBi();
            frmSd.Show();
        }
    }
}
