
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

namespace Quản_Lý_Khách_Sạn.FormsofDichVu
{
    public partial class FormQuanLyDichVu : Form
    {
        KetNoiCSDL CSDL = new KetNoiCSDL();
        SqlConnection conn = null;
        public FormQuanLyDichVu()
        {
            InitializeComponent();
            LoadData();
        }
        private void FormQuanLyDichVu_Load(object sender, EventArgs e)
        {
            LoadTheme1();
            LoadTheme2();
        }


        private void LoadTheme1()
        {
            foreach (Control btns in groupBox2.Controls)
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
            foreach (Control btns in groupBox3.Controls)
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

        private void LoadData()
        {
            conn = CSDL.Connect();
            SqlDataAdapter daTableName = new SqlDataAdapter("SELECT * FROM DichVu", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_themdichvu.DataSource = dtTableName;
            dataGridView_thongtindichvu.DataSource = dtTableName;
        }

        private void clearData()
        {
            tb_madv.Text = "";
            tb_tendv.Text = "";
            tb_giadv.Text = "";
            tb_manv.Text = "";
        }

        private void btn_themdichvu_Click(object sender, EventArgs e)
        {
            conn.Open();
            try { 
                SqlCommand cmd = new SqlCommand("INSERT INTO [DichVu]([maDV],[TenDV],[giaDV],[maNV],[Ngaybatdau])" + "VALUES(@madv,@tendv,@giadv,@manv,@ngaybatdau)");
                cmd.Parameters.AddWithValue("@madv", tb_madv.Text);
                cmd.Parameters.AddWithValue("@tendv", tb_tendv.Text);
                cmd.Parameters.AddWithValue("@giadv", tb_giadv.Text);
                cmd.Parameters.AddWithValue("@manv", tb_manv.Text);
                cmd.Parameters.AddWithValue("@ngaybatdau", DateTime.Now);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                LoadData();
                clearData();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được, Lỗi rồi !");
            }
            conn.Close();
        }

        private void btn_xoadichvu_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                int row = dataGridView_thongtindichvu.CurrentCell.RowIndex;
                string strMADV = dataGridView_thongtindichvu.Rows[row].Cells[0].Value.ToString();
                SqlCommand cmd = new SqlCommand("Delete from DichVu where maDV = '" + strMADV + "'");
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được, Lỗi rồi !");
            }
            conn.Close();
        }

        private void btn_suadichvu_Click(object sender, EventArgs e)
        {
            System.IFormatProvider cultureUS = new System.Globalization.CultureInfo("en-US");
            int r = dataGridView_thongtindichvu.CurrentCell.RowIndex;
            tb_madv.Text = dataGridView_thongtindichvu.Rows[r].Cells[0].Value.ToString();
            tb_tendv.Text = dataGridView_thongtindichvu.Rows[r].Cells[1].Value.ToString();
            tb_giadv.Text = Decimal.Parse(dataGridView_thongtindichvu.Rows[r].Cells[2].Value.ToString(), System.Globalization.NumberStyles.Number).ToString();
            tb_manv.Text = dataGridView_thongtindichvu.Rows[r].Cells[3].Value.ToString();
        }

        private void btn_luudichvu_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
            SqlCommand cmd = new SqlCommand("UPDATE DichVu SET [MaDV] = @madv,[TenDV] = @tendv,[giaDV] = @giadv where [MaDV] = @madv");
            cmd.Parameters.AddWithValue("@madv", tb_madv.Text);
            cmd.Parameters.AddWithValue("@tendv", tb_tendv.Text);
            decimal giadv= Decimal.Parse(tb_giadv.Text, System.Globalization.NumberStyles.Number);
            cmd.Parameters.AddWithValue("@giadv", giadv);
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

        public void TimKiemDVTheoTenVaMa()
        {
            conn = CSDL.Connect();
            SqlDataAdapter daTableName = new SqlDataAdapter("select * FROM DichVu where maDV like '%" + tb_timkiemdichvu.Text + "%' or TenDV like N'%" + tb_timkiemdichvu.Text + "%'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_thongtindichvu.DataSource = dtTableName;
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            LoadData();
            tb_timkiemdichvu.Text = "";
        }

        private void tb_timkiemdichvu_KeyDown(object sender, KeyEventArgs e)
        {
                TimKiemDVTheoTenVaMa();
        }

        
    }
}