using MaterialSkin;
using MaterialSkin.Controls;
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

namespace QLPM_PTH
{
    public partial class frmQLYC : MaterialForm
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLPM;Integrated Security=True";
        public frmQLYC()
        {
            InitializeComponent();
        }
        private void LoadTest()
        {
           
            string query = "SELECT MaDK, MucDich, MaPhong, NgaySuDung, TrangThaiDuyet FROM DANGKY_PHONG";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    
                    conn.Open();

                   
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    
                    dgvYeuCau.DataSource = dt;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTaoDatPhong_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
     
        private void tableLayoutPanelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmQLYC_Load(object sender, EventArgs e)
        {
            LoadTest();
        }

        private void cardSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvYeuCau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
