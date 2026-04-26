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
    public partial class frmMHSV : MaterialForm
    {
        public frmMHSV()
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

            // =========================================================
            // 1. LIÊN KẾT: XEM LỊCH PHÒNG MÁY (cardSchedule)
            // =========================================================
            cardSchedule.Click += CardSchedule_Click;
            materialLabel1.Click += CardSchedule_Click; // Click vào chữ
            pictureBox2.Click += CardSchedule_Click;    // Click vào hình

            // =========================================================
            // 2. LIÊN KẾT: ĐĂNG KÝ SỬ DỤNG PHÒNG (cardRegister)
            // =========================================================
            cardRegister.Click += CardRegister_Click;
            materialLabel2.Click += CardRegister_Click;
            pictureBox3.Click += CardRegister_Click;

            // =========================================================
            // 3. LIÊN KẾT: BÁO CÁO LỖI THIẾT BỊ (cardReport)
            // =========================================================
            cardReport.Click += CardReport_Click;
            materialLabel3.Click += CardReport_Click;
            pictureBox4.Click += CardReport_Click;
        }

        // ======================= CÁC HÀM XỬ LÝ MỞ FORM =======================

        private void CardSchedule_Click(object sender, EventArgs e)
        {
            // Mở form Lịch phòng học
            frmMHLichPhong fLich = new frmMHLichPhong();
            fLich.Show();
        }

        private void CardRegister_Click(object sender, EventArgs e)
        {
            // Mở form Đăng ký phòng
            frmMHDKPhong fDangKy = new frmMHDKPhong();
            fDangKy.Show();
        }

        private void CardReport_Click(object sender, EventArgs e)
        {
            // Mở form Báo cáo
            frmMHBaoCao fBaoCao = new frmMHBaoCao();
            fBaoCao.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void frmMHSV_Load(object sender, EventArgs e)
        {
        }
    }
}