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
using System.Data.SqlClient;

namespace MHSV
{
    public partial class frmMHDKPhong : MaterialForm
    {
        // Chuỗi kết nối đến CSDL QLPM (Thay dấu chấm "." bằng tên Server máy bạn nếu cần)
        string strCon = @"Data Source=Admin\SQLEXPRESS;Initial Catalog=QLPM;Integrated Security=True";
        public frmMHDKPhong()
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

        private void frmMHDKPhong_Load(object sender, EventArgs e)
        {
            // Gọi hàm load dữ liệu phòng máy khi form vừa mở lên
            LoadDSPhong();
        }
        // Hàm lấy danh sách phòng máy từ SQL đổ vào cboPhong
        private void LoadDSPhong()
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                try
                {
                    string sql = "SELECT MaPhong, TenPhong FROM PHONGMAY";
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboPhong.DataSource = dt;
                    cboPhong.DisplayMember = "TenPhong"; // Hiện tên phòng
                    cboPhong.ValueMember = "MaPhong";    // Nhưng ngầm hiểu là mã phòng
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách phòng: " + ex.Message);
                }
            }
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                try
                {
                    con.Open();
                    // Câu lệnh thêm vào CSDL. 
                    // Lưu ý: MaSV mình đang để cứng là 023101068 (Mã của bạn Đặng Lý Quốc Thành)
                    string sql = @"INSERT INTO DANGKY_PHONG (PHO_MaPhong, NgayDK, Ca, MucDich, MaSV, TrangThai) 
                                   VALUES (@MaPhong, @Ngay, @Ca, @MucDich, @MaSV, N'Chờ duyệt')";

                    SqlCommand cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@MaPhong", cboPhong.SelectedValue);
                    cmd.Parameters.AddWithValue("@Ngay", dtpNgayMuon.Value);
                    cmd.Parameters.AddWithValue("@Ca", cboCa.Text);
                    cmd.Parameters.AddWithValue("@MucDich", txtMucDich.Text);
                    cmd.Parameters.AddWithValue("@MaSV", "023101068");

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký phòng thành công! Yêu cầu đang chờ duyệt.", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đăng ký: " + ex.Message);
                }
            }
        }

        private void frmMHDKPhong_Load_1(object sender, EventArgs e)
        {

        }

        
    }
}
