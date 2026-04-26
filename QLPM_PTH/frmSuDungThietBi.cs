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
    public partial class frmSuDungThietBi : MaterialForm
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLPM;Integrated Security=True";
        public frmSuDungThietBi()
        {
            InitializeComponent();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {

        }
        private void LoadThietBi()
        {
            // Câu lệnh SQL lấy thông tin thiết bị từ bảng THIETBI
            string query = "SELECT MaTB, TenTB, MaPhong, TinhTrang FROM THIETBI";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Thực thi câu lệnh SQL và đổ dữ liệu vào DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // BẮT BUỘC PHẢI CÓ DÒNG NÀY ĐỂ CHẶN ĐẺ CỘT (Và phải nằm ở đây)
                    dgvThietBi.AutoGenerateColumns = false;

                    // Gán dữ liệu
                    dgvThietBi.DataSource = dt;

                    // Gán dữ liệu từ DataTable lên DataGridView
                    dgvThietBi.DataSource = dt;
                }
                catch (Exception ex)
                {
                    // Bắt lỗi nếu sai chuỗi kết nối hoặc lỗi SQL
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvThietBi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSuDungThietBi_Load(object sender, EventArgs e)
        {
            LoadThietBi();
          
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardSearch_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
