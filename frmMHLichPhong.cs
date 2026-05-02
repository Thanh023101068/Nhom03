using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MHSV
{
    public partial class frmMHLichPhong : MaterialForm
    {
        public frmMHLichPhong()
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
        private void LoadDataToListView(DateTime ngay)
        {
            lstLich.Items.Clear();
            string connString = @"Data Source = ADMIN-PC\SQLEXPRESS; Initial Catalog = QLPM; Integrated Security = True";
            string sql = "SELECT MaPhong, CaHoc,maMH, TrangThaiDuyet FROM DANGKY_PHONG WHERE NgaySuDung =ngaySuDung ";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Ngay", ngay.ToString("yyyy-MM-dd"));

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Ngày " + ngay.ToShortDateString() + " không có dữ liệu!");
                    }
                    else
                    {

                        while (reader.Read())
                        {

                            ListViewItem item = new ListViewItem(reader["MaPhong"].ToString());

                            item.SubItems.Add(reader["CaHoc"].ToString());
                            item.SubItems.Add(reader["MaMH"].ToString());
                            item.SubItems.Add(reader["TrangThaiDuyet"].ToString());


                            lstLich.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }


            



        private void cboCaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





        private void frmMHLichPhong_Load(object sender, EventArgs e)
        {
            

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMHLichPhong_Load_1(object sender, EventArgs e)
        {

            string sqlcnn = "SELECT DISTINCT CaHoc FROM DANGKY_PHONG"; 
            using (SqlConnection cnn = new SqlConnection(@"Data Source = ADMIN-PC\SQLEXPRESS; Initial Catalog = QLPM; Integrated Security = True"))

            {
                try
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(sqlcnn, cnn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cboCaHoc.Items.Clear();
                    while (reader.Read())
                    {
                        cboCaHoc.Items.Add(reader["CaHoc"].ToString());
                    }

                    if (cboCaHoc.Items.Count > 0) cboCaHoc.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load ca học: " + ex.Message);
                }

                lstLich.View = View.Details;

                lstLich.Items.Clear();


                string sql = "SELECT MaPhong, CaHoc, MaMH, TrangThaiDuyet FROM DANGKY_PHONG";

                using (SqlConnection conn = new SqlConnection(@"Data Source = ADMIN-PC\SQLEXPRESS; Initial Catalog = QLPM; Integrated Security = True"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["MaPhong"].ToString());
                        item.SubItems.Add(reader["CaHoc"].ToString());
                        item.SubItems.Add(reader["MaMH"].ToString());
                        item.SubItems.Add(reader["TrangThaiDuyet"].ToString());
                        lstLich.Items.Add(item);
                    }


                }

            }
        }




            private void picAvatar_Click(object sender, EventArgs e)
        {

        }

        private void lstLich_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
            private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source = ADMIN-PC\SQLEXPRESS; Initial Catalog = QLPM; Integrated Security = True";
            string sql = "SELECT pm.TenPhong, dk.caHoc, dk.maMH, dk.trangThaiDuyet FROM DANGKY_PHONG dk, PHONGMAY pm Where  dk.MaPhong = pm.MaPhong  AND dk.ngaySuDung = ngaySuDung AND dk.caHoc = caHoc";
            using (SqlConnection conn = new SqlConnection(connString
                ))
    {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);

               
                    cmd.Parameters.AddWithValue("@ngay", dtpNgay.Value.Date);
                    cmd.Parameters.AddWithValue("@ca", cboCaHoc.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    lstLich.Items.Clear(); 

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                          
                            ListViewItem item = new ListViewItem(row["TenPhong"].ToString());

                         
                            item.SubItems.Add(row["CaHoc"].ToString());
                            item.SubItems.Add(row["TenDN"].ToString());
                            item.SubItems.Add(row["trangThaiDuyet"].ToString());

                            lstLich.Items.Add(item);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu nào cho ca học này!", "Thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
        }

        private void lblChonNgay_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            

        }
    }
}
