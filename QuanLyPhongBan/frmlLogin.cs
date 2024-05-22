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


namespace QuanLyPhongBan
{
    public partial class frmlLogin : Form
    {
        public static string ConnectionString = @"Data Source=LAPTOP-NG5OFKQK;Initial Catalog=QLPhongBan;Integrated Security=True";
        public frmlLogin()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTK.Text))
            {
                MessageBox.Show("Chưa nhập thông tin TK", "Thông báo");
                txtTK.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMK.Text))
            {
                MessageBox.Show("Chưa nhập thông tin MK", "Thông báo");
                txtMK.Focus();
                return;
            }

            string TenTKhoan = txtTK.Text.Trim();
            string MatKhau = txtMK.Text.Trim();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM tblTaiKhoan WHERE Ten_TKhoan = @TenTKhoan AND Mat_Khau = @MatKhau";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenTKhoan", TenTKhoan);
                        cmd.Parameters.AddWithValue("@MatKhau", MatKhau);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataSet ds = new DataSet();
                            da.Fill(ds);

                            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                frmMain frmMain1 = new frmMain();
                                frmMain1.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Thông tin đăng nhập không chính xác", "Thông báo");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo");
            }

        }
    }
}
