using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
//<<<<<<< HEAD
               
  //              );
//=======
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

        private void cardSchedule_Paint(object sender, PaintEventArgs e)
        {

        }
    

    private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void frmMHSV_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            LoadThongBao();
            
        }

      
        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cardSchedule_Click(object sender, EventArgs e)
        {
            frmMHLichPhong fLich = new frmMHLichPhong();
            fLich.Show();
        }
        void LoadThongBao()
        {
            string strConn= @"Data Source = ADMIN-PC\SQLEXPRESS; Initial Catalog = QLPM; Integrated Security = True";
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    
                    string sql ="SELECT MaPhong, CaHoc,maMH, TrangThaiDuyet FROM DANGKY_PHONG WHERE NgaySuDung ='5/2/2026'";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                   
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
            }
        }
   

    


    private void cardNotice_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}