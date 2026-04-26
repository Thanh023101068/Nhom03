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
using System.Data.SqlClient; // Khai báo thư viện SQL

namespace MHSV
{
    public partial class frmMHBaoCao : MaterialForm
    {
        // Chuỗi kết nối CSDL
        string strCon = @"Data Source=Admin\SQLEXPRESS;Initial Catalog=QLPM;Integrated Security=True";
        public frmMHBaoCao()
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

        private void frmMHBaoCao_Load(object sender, EventArgs e)
        {
            // Tải danh sách phòng lên cboPhong
            LoadDSPhong();
        }
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
                    cboPhong.DisplayMember = "TenPhong";
                    cboPhong.ValueMember = "MaPhong";
                }
                catch (Exception ex)
                {
                    // Bỏ qua lỗi nếu CSDL chưa có dữ liệu
                }
            }
        }
        private void btnGui_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMoTa.Text))
            {
                MessageBox.Show("Vui lòng nhập mô tả lỗi!", "Cảnh báo");
                return;
            }

            using (SqlConnection con = new SqlConnection(strCon))
            {
                try
                {
                    con.Open();
                    // Câu lệnh Insert vào bảng Báo cáo
                    string sql = @"INSERT INTO BAOCAO_SUCO (MaTB, NoiDung, NgayBC, MaSV, TrangThai) 
                                   VALUES (@MaTB, @NoiDung, GETDATE(), @MaSV, N'Mới tiếp nhận')";

                    SqlCommand cmd = new SqlCommand(sql, con);

                    // Lấy text của cboMay (VD: TB01_PM01)
                    cmd.Parameters.AddWithValue("@MaTB", cboMay.Text);
                    cmd.Parameters.AddWithValue("@NoiDung", txtMoTa.Text);
                    cmd.Parameters.AddWithValue("@MaSV", "023101068"); // Mã SV mẫu

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Gửi báo cáo sự cố thành công!", "Thông báo");

                    // Xóa trắng ô mô tả sau khi gửi xong
                    txtMoTa.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi");
                }
            }
        }

        private void frmMHBaoCao_Load_1(object sender, EventArgs e)
        {

        }        
    }
}
