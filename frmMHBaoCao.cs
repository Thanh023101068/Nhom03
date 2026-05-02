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

            LoadDSPhong();

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
                    // Câu lệnh Insert đã được cập nhật chuẩn với CSDL mới
                    string sql = @"INSERT INTO BAOCAO_SUCO 
                           (MaBC, tenDNNguoiBao, MaTB, MaPhong, MoTa, NgayBao, TrangThai) 
                           VALUES 
                           ((SELECT ISNULL(MAX(MaBC), 0) + 1 FROM BAOCAO_SUCO), 
                            @TenDN, @MaTB, @MaPhong, @MoTa, GETDATE(), N'Chưa xử lý')";

                    SqlCommand cmd = new SqlCommand(sql, con);

                    // Truyền các tham số
                    cmd.Parameters.AddWithValue("@MaTB", cboMay.Text);
                    cmd.Parameters.AddWithValue("@MoTa", txtMoTa.Text);

                    // Lấy mã phòng từ combobox cboPhong
                    cmd.Parameters.AddWithValue("@MaPhong", cboPhong.SelectedValue);

                    // Dùng tên đăng nhập có sẵn trong CSDL thay vì MaSV
                    cmd.Parameters.AddWithValue("@TenDN", "sv_023101082");

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

        private void cboMay_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cấm chạy nếu form đang load mà chưa có giá trị thực sự
            if (cboPhong.SelectedValue == null || cboPhong.SelectedValue is DataRowView)
                return;

            using (SqlConnection con = new SqlConnection(strCon))
            {
                try
                {
                    // Câu lệnh tìm các thiết bị (máy tính) thuộc cái mã phòng vừa chọn
                    string sql = "SELECT maTB, tenTB FROM THIETBI WHERE maPhong = @MaPhong";
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);

                    // Lấy mã phòng đang được chọn ở cboPhong truyền vào câu SQL
                    da.SelectCommand.Parameters.AddWithValue("@MaPhong", cboPhong.SelectedValue.ToString());

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboMay.DataSource = dt;
                    // Hiển thị mã máy (VD: PC_A101_01) để nhìn cho chuẩn
                    cboMay.DisplayMember = "maTB";
                    cboMay.ValueMember = "maTB";
                }
                catch (Exception ex)
                {
                    // Bỏ qua nếu lỗi vặt lúc khởi tạo
                }
            }
        }
    }
}
