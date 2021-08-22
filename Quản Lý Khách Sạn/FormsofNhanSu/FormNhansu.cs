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

namespace Quản_Lý_Khách_Sạn.FormsofNhanSu
{
    public partial class FormNhansu : Form
    {
        KetNoiCSDL CSDL = new KetNoiCSDL();
        SqlConnection conn = null;
        string str_gioitinh = null;
        public FormNhansu()
        {
            InitializeComponent();
            LoadData();
            conn.Open();
            string lastID = GetLastID("NhanVien", "maNV");
            tb_manv_NhanSu.Text = NextID(lastID, "NV");
            conn.Close();
        }

        private void FormNhansu_Load(object sender, EventArgs e)
        {
            LoadTheme1();
            LoadTheme2();
        }

        private void LoadTheme1()
        {
            foreach (Control btns in groupBox_thongtinNV.Controls)
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

        private void LoadData()
        {
            conn = CSDL.Connect();
            SqlDataAdapter daTableName = new SqlDataAdapter("SELECT maNV,TenNV,maBP, GioLamViec,NgaySinh,GioiTinh,DiaChi,SoCMT,QuocTich,Sdt,ChucVu,Luong FROM NhanVien", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_themthongtinnhanvien_NhanSu.DataSource = dtTableName;
            dataGridView_thongtinnhanvien_NhanSu.DataSource = dtTableName;
        }

        public string GetLastID(string nameTable, string nameSelectColumn)
        {
            string sql = "SELECT TOP 1 " + nameSelectColumn + " FROM " + nameTable + " ORDER BY " + nameSelectColumn + " DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            return (string)cmd.ExecuteScalar();
        }

        public string NextID(string lastID, string prefixID)
        {
            if (lastID == "")
            {
                return prefixID + "001";  
            }
            int nextID = int.Parse(lastID.Remove(0, prefixID.Length)) + 1;
            int lengthNumerID = lastID.Length - prefixID.Length;
            string zeroNumber = "";
            for (int i = 1; i <= lengthNumerID; i++)
            {
                if (nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= lengthNumerID - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return prefixID + zeroNumber + nextID.ToString();
                }
            }
            return prefixID + nextID;

        }
        private void clearData()
        {
            tb_manv_NhanSu.Text = "";
            tb_hoten_NhanSu.Text = "";
            comboBox_maBP_NhanSu.Text = "";
            tb_giolv_NhanSu.Text = "";
            radioButton_nam_NhanSu.Checked = false;
            radioButton_nu_NhanSu.Checked = false;
            tb_diachi_NhanSu.Text = "";
            tb_soCMT_NhanSu.Text = "";
            tb_quoctich_NhanSu.Text = "";
            tb_sodt_NhanSu.Text = "";
            tb_chucvu_NhanSu.Text = "";
            tb_luong_NhanSu.Text = "";
            conn.Open();
            string lastID = GetLastID("NhanVien", "maNV");
            tb_manv_NhanSu.Text = NextID(lastID, "NV");
            conn.Close();
        }

        private void radioButton_nam_NhanSu_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton gioitinh = sender as RadioButton;
            if (gioitinh.Checked)
            {
                str_gioitinh = gioitinh.Text;
            }
        }
        private void radioButton_nu_NhanSu_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton gioitinh = sender as RadioButton;
            if (gioitinh.Checked)
            {
                str_gioitinh = gioitinh.Text;   
            }
        }
        private void btn_themthongtinnhanvien_NhanSu_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [NhanVien]([maNV],[TenNV],[maBP],[GioLamViec],[username],[password],[NgaySinh],[GioiTinh],[DiaChi],[SoCMT]" +
                 ",[QuocTich],[Sdt],[ChucVu],[Luong])" + "VALUES(@manv,@hoten,@mabp,@giolv,' ',' ',@ngaysinh,@gioitinh,@diachi," +
                 "@socmt,@quoctich,@dienthoai,@chucvu,@luong)");

                cmd.Parameters.AddWithValue("@manv", tb_manv_NhanSu.Text);
                cmd.Parameters.AddWithValue("@hoten", tb_hoten_NhanSu.Text);
                cmd.Parameters.AddWithValue("@mabp", comboBox_maBP_NhanSu.SelectedItem);
                cmd.Parameters.AddWithValue("@giolv", tb_giolv_NhanSu.Text);
                DateTime date = dateTimePicker_ngaysinh_NhanSu.Value;
                cmd.Parameters.AddWithValue("@ngaysinh", date);
                cmd.Parameters.AddWithValue("@gioitinh", str_gioitinh);
                cmd.Parameters.AddWithValue("@diachi", tb_diachi_NhanSu.Text);
                cmd.Parameters.AddWithValue("@socmt", tb_soCMT_NhanSu.Text);
                cmd.Parameters.AddWithValue("@quoctich", tb_quoctich_NhanSu.Text);
                cmd.Parameters.AddWithValue("@dienthoai", tb_sodt_NhanSu.Text);
                cmd.Parameters.AddWithValue("@chucvu", tb_chucvu_NhanSu.Text);
                cmd.Parameters.AddWithValue("@luong", tb_luong_NhanSu.Text);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                LoadData();
                tb_timNV.Text = "";
                comboBox_maBP_NhanSu_timkiemthongtinnhanvien.Text = "";
                clearData();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được, Lỗi rồi !");
            }
            conn.Close();
        }

        private void btn_xoathongtinnhanvien_NhanSu_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                int row = dataGridView_thongtinnhanvien_NhanSu.CurrentCell.RowIndex;
                string strMANV = dataGridView_thongtinnhanvien_NhanSu.Rows[row].Cells[0].Value.ToString();
                string strMaBP = dataGridView_thongtinnhanvien_NhanSu.Rows[row].Cells[2].Value.ToString();
                if(strMaBP == "GD")
                {
                    MessageBox.Show("Bạn không có thẩm quyền để làm việc này");
                }else
                {
                    SqlCommand cmd = new SqlCommand("Delete from NhanVien where maNV = '" + strMANV + "'");
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    LoadData();
                    tb_timNV.Text = "";
                    comboBox_maBP_NhanSu_timkiemthongtinnhanvien.Text = "";
                }    
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được, Lỗi rồi !");
            }
                conn.Close(); 
        }

        private void btn_suathongtinnhanvien_NhanSu_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridView_thongtinnhanvien_NhanSu.CurrentCell.RowIndex;
                tb_manv_NhanSu.Text = dataGridView_thongtinnhanvien_NhanSu.Rows[r].Cells[0].Value.ToString();
                tb_hoten_NhanSu.Text = dataGridView_thongtinnhanvien_NhanSu.Rows[r].Cells[1].Value.ToString();
                comboBox_maBP_NhanSu.Text = dataGridView_thongtinnhanvien_NhanSu.Rows[r].Cells[2].Value.ToString();
                tb_giolv_NhanSu.Text = Decimal.Parse(dataGridView_thongtinnhanvien_NhanSu.Rows[r].Cells[3].Value.ToString(), System.Globalization.NumberStyles.Number).ToString();
                dateTimePicker_ngaysinh_NhanSu.Text = dataGridView_thongtinnhanvien_NhanSu.Rows[r].Cells[4].Value.ToString();
                string gt = dataGridView_thongtinnhanvien_NhanSu.Rows[r].Cells[5].Value.ToString();
                if (gt == "Nam")
                {
                    radioButton_nam_NhanSu.Checked = true;
                }else if (gt == "Nữ")
                {
                    radioButton_nam_NhanSu.Checked = true;
                }
                tb_diachi_NhanSu.Text = dataGridView_thongtinnhanvien_NhanSu.Rows[r].Cells[6].Value.ToString();
                tb_soCMT_NhanSu.Text = dataGridView_thongtinnhanvien_NhanSu.Rows[r].Cells[7].Value.ToString();
                tb_quoctich_NhanSu.Text = dataGridView_thongtinnhanvien_NhanSu.Rows[r].Cells[8].Value.ToString();
                tb_sodt_NhanSu.Text = dataGridView_thongtinnhanvien_NhanSu.Rows[r].Cells[9].Value.ToString();
                tb_chucvu_NhanSu.Text = dataGridView_thongtinnhanvien_NhanSu.Rows[r].Cells[10].Value.ToString();
                tb_luong_NhanSu.Text = Decimal.Parse(dataGridView_thongtinnhanvien_NhanSu.Rows[r].Cells[11].Value.ToString(), System.Globalization.NumberStyles.Number).ToString();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không sửa được, Lỗi rồi !");
            }
        }

        private void btn_luuthongtinnhanvien_NhanSu_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET [MaNV] = @manv,[TenNV] = @hoten,[maBP] = @mabp," +
                "[GioLamViec] = @giolv,[NgaySinh] = @ngaysinh,[GioiTinh] = @gioitinh,[DiaChi] = @diachi,[SoCMT] = @socmt,[QuocTich] = @quoctich," +
                "[Sdt] = @dienthoai,[ChucVu] = @chucvu,[Luong] = @luong  where [MaNV] = @manv");
            cmd.Parameters.AddWithValue("@manv", tb_manv_NhanSu.Text);
            cmd.Parameters.AddWithValue("@hoten", tb_hoten_NhanSu.Text);
            cmd.Parameters.AddWithValue("@mabp", comboBox_maBP_NhanSu.SelectedItem.ToString());
            decimal glv = Decimal.Parse(tb_giolv_NhanSu.Text, System.Globalization.NumberStyles.Number);
            cmd.Parameters.AddWithValue("@giolv", glv);
            DateTime date = dateTimePicker_ngaysinh_NhanSu.Value;
            cmd.Parameters.AddWithValue("@ngaysinh", date);
            cmd.Parameters.AddWithValue("@diachi", tb_diachi_NhanSu.Text);
            cmd.Parameters.AddWithValue("@chucvu", tb_chucvu_NhanSu.Text);
            cmd.Parameters.AddWithValue("@socmt", tb_soCMT_NhanSu.Text);
            cmd.Parameters.AddWithValue("@dienthoai", tb_sodt_NhanSu.Text);
            decimal luong = Decimal.Parse(tb_luong_NhanSu.Text, System.Globalization.NumberStyles.Number);
            cmd.Parameters.AddWithValue("@luong", luong);
            cmd.Parameters.AddWithValue("@gioitinh", str_gioitinh);
            cmd.Parameters.AddWithValue("@quoctich", tb_quoctich_NhanSu.Text);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            LoadData();
            tb_timNV.Text = "";
            comboBox_maBP_NhanSu_timkiemthongtinnhanvien.Text = "";
            clearData();
            conn.Close();
        }
        public void TimKiemNVTheoTenVaMa()
        {
            conn = CSDL.Connect();
            SqlDataAdapter daTableName = new SqlDataAdapter("select * FROM nhanvien where maNV like '%" + tb_timNV.Text + "%' or TenNV like N'%" + tb_timNV.Text + "%'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_thongtinnhanvien_NhanSu.DataSource = dtTableName;
        }
        public void TimKiemNVTheoBP()
        {
            conn = CSDL.Connect();
            SqlDataAdapter daTableName = new SqlDataAdapter("select * FROM nhanvien where maBP = '" + comboBox_maBP_NhanSu_timkiemthongtinnhanvien.SelectedItem.ToString() + "' ", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_thongtinnhanvien_NhanSu.DataSource = dtTableName;
        }

        private void comboBox_maBP_NhanSu_timkiemthongtinnhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiemNVTheoBP();
            tb_timNV.Text = "";
        }

        private void btn_lammoi_NhanSu_Click(object sender, EventArgs e)
        {
            LoadData();
            tb_timNV.Text = "";
            comboBox_maBP_NhanSu_timkiemthongtinnhanvien.Text = "";
        }

        private void tb_timNV_KeyDown(object sender, KeyEventArgs e)
        {
            comboBox_maBP_NhanSu_timkiemthongtinnhanvien.Text = "";
            TimKiemNVTheoTenVaMa();
        }
    }
}
