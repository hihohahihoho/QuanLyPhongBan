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
    public partial class frmPhongBan : Form
    {
        public static string ConnectionString = @"Data Source=LAPTOP-NG5OFKQK;Initial Catalog=QLPhongBan;Integrated Security=True";
        SqlConnection conn = new SqlConnection(ConnectionString);
        public frmPhongBan()
        {
            InitializeComponent();
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // This event handler is empty
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // This event handler is empty
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            // This event handler is empty
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("select * from tblPhongBan", conn);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvPhongBan.DataSource = dt;
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPB.Text))
            {
                MessageBox.Show("Không được để trống " + txtMaPB.Name, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenPB.Text))
            {
                MessageBox.Show("Không được để trống " + txtTenPB.Name, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMaTP.Text))
            {
                MessageBox.Show("Không được để trống " + txtMaTP.Name, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDiaDiem.Text))
            {
                MessageBox.Show("Không được để trống " + txtDiaDiem.Name, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime selectedDate = txtDate.Value;
            DateTime currentDate = DateTime.Now;

            if ((currentDate - selectedDate).Days == 0)
            {
                MessageBox.Show("Ngày được chọn phải cách ngày hiện tại ít nhất 1 ngày.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return;
            }
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("insert into tblPhongBan values (@Ma_PhongBan, @Ten_PhongBan, @Ma_TruongPhong, @Dia_Diem, @Ngay_NhanChuc)", conn);
                cmd.Parameters.AddWithValue("@Ma_PhongBan", txtMaPB.Text);
                cmd.Parameters.AddWithValue("@Ten_PhongBan", txtTenPB.Text);
                cmd.Parameters.AddWithValue("@Ma_TruongPhong", txtMaTP.Text);
                cmd.Parameters.AddWithValue("@Dia_Diem", txtDiaDiem.Text);
                cmd.Parameters.AddWithValue("@Ngay_NhanChuc", selectedDate.ToString("yyyy-MM-dd"));
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvPhongBan.DataSource = dt;
                MessageBox.Show("Thêm phòng ban thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPhongBan_Load(sender, e);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Thêm mã để xử lý thêm phòng ban ở đây
        }

        private void dgvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvPhongBan.CurrentRow.Index;
            txtMaPB.Text = dgvPhongBan.Rows[i].Cells[0].Value.ToString();
            txtTenPB.Text = dgvPhongBan.Rows[i].Cells[1].Value.ToString();
            txtMaTP.Text = dgvPhongBan.Rows[i].Cells[2].Value.ToString();
            txtDiaDiem.Text = dgvPhongBan.Rows[i].Cells[3].Value.ToString();
            txtDate.Text = dgvPhongBan.Rows[i].Cells[4].Value.ToString();
        }
        private void xoaTextBox()
        {
            txtMaPB.Clear();
            txtTenPB.Clear();
            txtMaTP.Clear();
            txtDiaDiem.Clear();
            txtDate.Value = DateTime.Now;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("delete from tblPhongBan where Ma_PhongBan = @Ma_PhongBan", conn);
                cmd.Parameters.AddWithValue("@Ma_PhongBan", txtMaPB.Text);
                cmd.ExecuteNonQuery();
                
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                frmPhongBan_Load(sender, e);
                xoaTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = txtDate.Value;
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("update tblPhongBan set Ma_PhongBan = @Ma_PhongBan, Ten_PhongBan= @Ten_PhongBan, Ma_TruongPhong= @Ma_TruongPhong, Dia_Diem=@Dia_Diem, Ngay_NhanChuc= @Ngay_NhanChuc where Ma_PhongBan = @Ma_PhongBan", conn);
                cmd.Parameters.AddWithValue("@Ma_PhongBan", txtMaPB.Text);
                cmd.Parameters.AddWithValue("@Ten_PhongBan", txtTenPB.Text);
                cmd.Parameters.AddWithValue("@Ma_TruongPhong", txtMaTP.Text);
                cmd.Parameters.AddWithValue("@Dia_Diem", txtDiaDiem.Text);
                cmd.Parameters.AddWithValue("@Ngay_NhanChuc", selectedDate.ToString("yyyy-MM-dd"));
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvPhongBan.DataSource = dt;
                MessageBox.Show("Sửa phòng ban thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPhongBan_Load(sender, e);
                if (conn.State == ConnectionState.Open)
                    conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSea_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                // Câu lệnh SQL tìm kiếm với điều kiện LIKE
                string query = "SELECT * FROM tblPhongBan WHERE Ma_PhongBan LIKE @Search OR Ten_PhongBan LIKE @Search";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Search", "%" + txtSea.Text + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvPhongBan.DataSource = dt;

                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

    }
}
