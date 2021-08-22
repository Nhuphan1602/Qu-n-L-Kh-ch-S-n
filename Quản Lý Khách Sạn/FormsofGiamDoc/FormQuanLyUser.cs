using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quản_Lý_Khách_Sạn.FormsofGiamDoc
{
    public partial class FormQuanLyUser : Form
    {
        KetNoiCSDL CSDL = new KetNoiCSDL();
        SqlConnection conn = null;
        public FormQuanLyUser()
        {
            InitializeComponent();
            LoadData();

        }
        private void LoadData()
        {
            conn = CSDL.Connect();
            SqlDataAdapter daTableName = new SqlDataAdapter("SELECT maNV,TenNV,maBP,ChucVu,trim(username) as Username,trim(password) as Password,NgaySinh,GioLamViec,Luong FROM NhanVien", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_quanlynv.DataSource = dtTableName;
            dataGridView_quanlynv.DataSource = dtTableName;
        }
        private void clearData()
        {
            tb_manv.Text = "";
            tb_tennv.Text = "";
            tb_username.Text = "";
            tb_password.Text = "";
        }

        private void btn_luutaikhoan_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET [Username] = @username,[Password] = @password where [MaNV] = @manv");
                cmd.Parameters.AddWithValue("@manv", tb_manv.Text);
                cmd.Parameters.AddWithValue("@username", tb_username.Text);
                cmd.Parameters.AddWithValue("@password", tb_password.Text);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                LoadData();
                clearData();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lưu được, Lỗi rồi !");
            }
            conn.Close();
        }

        private void btn_chonnv_Click(object sender, EventArgs e)
        {
            System.IFormatProvider cultureUS = new System.Globalization.CultureInfo("en-US");
            int r = dataGridView_quanlynv.CurrentCell.RowIndex;
            tb_manv.Text = dataGridView_quanlynv.Rows[r].Cells[0].Value.ToString();
            tb_tennv.Text = dataGridView_quanlynv.Rows[r].Cells[1].Value.ToString();
            tb_username.Text = dataGridView_quanlynv.Rows[r].Cells[4].Value.ToString();
            tb_password.Text = dataGridView_quanlynv.Rows[r].Cells[5].Value.ToString();

        }

        public void TimKiemNVTheoTenVaMa()
        {
            conn = CSDL.Connect();
            SqlDataAdapter daTableName = new SqlDataAdapter("select maNV,TenNV,maBP,ChucVu,trim(username),trim(password),NgaySinh,GioLamViec,Luong FROM nhanvien where maNV like '%" + tb_timkiemnv.Text + "%' or TenNV like N'%" + tb_timkiemnv.Text + "%'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_quanlynv.DataSource = dtTableName;
        }
        public void TimKiemNVTheoTK()
        {
            conn = CSDL.Connect();
            if(comboBox_timnv.SelectedItem.ToString() == "Có tài khoản")
            { 
                SqlDataAdapter daTableName = new SqlDataAdapter("select maNV,TenNV,maBP,ChucVu,trim(username) as Username,trim(password) as Password,NgaySinh,GioLamViec,Luong FROM nhanvien where trim(username) != '' and trim(password) != '' ", conn);
                DataTable dtTableName = new DataTable();
                daTableName.Fill(dtTableName);
                dataGridView_quanlynv.DataSource = dtTableName;
            }
            else
            {
                SqlDataAdapter daTableName = new SqlDataAdapter("select maNV,TenNV,maBP,ChucVu,trim(username) as Username,trim(password) as Password,NgaySinh,GioLamViec,Luong FROM nhanvien where trim(username) = '' and trim(password) = ''  ", conn);
                DataTable dtTableName = new DataTable();
                daTableName.Fill(dtTableName);
                dataGridView_quanlynv.DataSource = dtTableName;
            }    

        }

        private void comboBox_timnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiemNVTheoTK();
            tb_timkiemnv.Text = "";
        }

        private void tb_timkiemnv_KeyDown(object sender, KeyEventArgs e)
        {
            TimKiemNVTheoTenVaMa();
            comboBox_timnv.Text = "";
        }

        private void btn_lammoinv_Click(object sender, EventArgs e)
        {
            LoadData();
            comboBox_timnv.Text = "";
            tb_timkiemnv.Text = "";
        }

        private void FormQuanLyUser_Load(object sender, EventArgs e)
        {
            LoadTheme1();
            LoadTheme2();
        }
        private void LoadTheme1()
        {
            foreach (Control btns in groupBox1.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemecolorHome.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Color.Black;
                }
            }
        }

        private void LoadTheme2()
        {
            foreach (Control btns in groupBox_timkiemthongtinnhanvien.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemecolorHome.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Color.Black;
                }
            }
        }
    }
}
