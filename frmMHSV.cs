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
               
                );

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void frmMHSV_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            LoadThongBao();
            
        }

        private void cardSchedule_Paint(object sender, PaintEventArgs e)
        {
           

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
