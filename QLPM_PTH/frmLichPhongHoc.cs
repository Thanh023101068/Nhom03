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
    public partial class frmLichPhongHoc : MaterialForm
    {
        public frmLichPhongHoc()
        {
            InitializeComponent();
            
        }
        string strCon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLPM;Integrated Security=True";
        SqlConnection sqlCon = null;

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmQLYC frmYc = new frmQLYC();
            frmYc.Show();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBaoLoi_Click(object sender, EventArgs e)
        {
            string strCon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLPM;Integrated Security=True";

            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                try
                {
                    sqlCon.Open(); // Thử mở cổng kết nối
                    MessageBox.Show("Kết nối thành công! Bạn đã chạm được vào database SQLPM.");
                }
                catch (Exception ex)
                {
                    // Nếu có lỗi (sai tên server, sai tên DB...), nó sẽ hiện ở đây
                    MessageBox.Show("Thất bại rồi! Lỗi cụ thể là: " + ex.Message);
                }
            }
        }

        private void frmLichPhongHoc_Load(object sender, EventArgs e)
        {

        }
    }
}
