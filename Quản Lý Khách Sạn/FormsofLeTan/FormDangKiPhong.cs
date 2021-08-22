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

namespace Quản_Lý_Khách_Sạn.FormsofLeTan
{
    public partial class FormDangKiPhong : Form
    {
        KetNoiCSDL CSDL = new KetNoiCSDL();
        SqlConnection conn = null;
        string str_gioitinh = null;
        public FormDangKiPhong()
        {
            InitializeComponent();
            conn = CSDL.Connect();
            timer1.Start();
            dateTimePicker_ngaydangki_LeTan.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 00, 00);
            dateTimePicker_ngaydi_LeTan.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 00, 00);
            Load_DataGridView_themthongtinKH();
            UpDate_TinhTrangPhong();
            HienMaKH();
            combobox_LoaiPhong();
            Hien_GiaPhong_TheoLoaiPhong();
            combobox_SoPhong();            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker_ngayden_LeTan.Value = DateTime.Now;
        }

        private void FormLetan_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
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


        //
        // Chức năng tìm kiếm
        //
        private void TimKiemKh_SoPhong()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select KhachHang.maKH,KhachHang.TenKH, Phong.SoPhong, Convert(varchar(20), KhachHang.NgaySinh, 113) as NgaySinh, KhachHang.GioiTinh, KhachHang.Sdt from KhachHang inner join Phong on KhachHang.maKH = Phong.maKH where SoPhong = '" + tb_timkiemKH_Phong.Text + "'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiemthongtinKH_LeTan.DataSource = dtTableName;
            conn.Close();
        }

        private void TimKiemKh_HoTen()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select KhachHang.maKH,KhachHang.TenKH,  Convert(varchar(20), KhachHang.NgaySinh, 113) as NgaySinh, KhachHang.GioiTinh, KhachHang.Sdt from KhachHang  where KhachHang.TenKH = N'" + tb_timkiemKH_Phong.Text + "'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiemthongtinKH_LeTan.DataSource = dtTableName;
            conn.Close();
        }
        private void TimKiemKh_sdt()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select KhachHang.maKH,KhachHang.TenKH,  Convert(varchar(20), KhachHang.NgaySinh, 113) as NgaySinh, KhachHang.GioiTinh, KhachHang.Sdt from KhachHang  where KhachHang.sdt = '" + tb_timkiemKH_Phong.Text + "'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiemthongtinKH_LeTan.DataSource = dtTableName;
            conn.Close();
        }
        private void tb_timkiemKH_Phong_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (comboBox_sophong_hoten.SelectedItem == "Họ Tên")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TimKiemKh_HoTen();
                    if (dataGridView_timkiemthongtinKH_LeTan.Rows != null && dataGridView_timkiemthongtinKH_LeTan.Rows.Count != 0)
                    { 
                        dataGridView_timkiemthongtinKH_LeTan.Enabled = true;
                    }
                    else
                    {
                        dataGridView_timkiemthongtinKH_LeTan.Enabled = false;       
                    }    
                }
            }
            else if (comboBox_sophong_hoten.SelectedItem == "Số Phòng")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TimKiemKh_SoPhong();
                    if (dataGridView_timkiemthongtinKH_LeTan.Rows != null && dataGridView_timkiemthongtinKH_LeTan.Rows.Count != 0)
                    {
                        dataGridView_timkiemthongtinKH_LeTan.Enabled = true;               
                    }
                    else
                    {
                        dataGridView_timkiemthongtinKH_LeTan.Enabled = false;
                    }
                }
            }
            else if (comboBox_sophong_hoten.SelectedItem == "Số Điện Thoại")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TimKiemKh_sdt();
                    if (dataGridView_timkiemthongtinKH_LeTan.Rows != null && dataGridView_timkiemthongtinKH_LeTan.Rows.Count != 0)
                    {
                        dataGridView_timkiemthongtinKH_LeTan.Enabled = true; 
                    }
                    else
                    {
                        dataGridView_timkiemthongtinKH_LeTan.Enabled = false;
                    }
                }
            }
        }
        private void dataGridView_timkiemthongtinKH_LeTan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {      
            int r = dataGridView_timkiemthongtinKH_LeTan.CurrentCell.RowIndex;
            tb_makh_LeTan.Text = dataGridView_timkiemthongtinKH_LeTan.Rows[r].Cells[0].Value.ToString();         
        }
        //
        //
        //



        private void HienMaKH()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select top 1 MaKH from KhachHang order by maKH desc", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            string[] array_makh = dtTableName.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            string makh = null;
            char[] ab = new char[0];
            char[] a = new char[0];
            char[] b = new char[0];

            if (array_makh.Length < 1)
            {
                makh = "KH000001";
            }
            else
            {
                makh = array_makh[0].Trim();
                ab = makh.ToCharArray();
                a = makh.Substring(0, Array.LastIndexOf(ab, '0', 6) + 1).ToCharArray();
                b = makh.Substring(Array.LastIndexOf(ab, '0', 6) + 1).ToCharArray();
                string new_b = (Int16.Parse(new string(b)) + 1).ToString();
                makh = (new string(a)) + new_b;
            }
            if (makh.Length == 8)
            {
                tb_makh_LeTan.Text = makh;
            }
            else
            {
                char[] c = makh.ToCharArray();
                int d = Array.LastIndexOf(ab, '0',6);
                for (int i = d; i < 8; i++)
                {
                    c[i] = c[i + 1];
                }
                char[] e = new char[8];
                for (int i = 0; i < 8; i++)
                {
                    e[i] = c[i];
                }
                makh = (new string(e));
                tb_makh_LeTan.Text = makh;
            }
            conn.Close();
        }
        private void UpDate_TinhTrangPhong()
        {
            conn.Open();
            try
            {
                SqlCommand cmd2 = new SqlCommand("update Phong set TinhTrang = N'Trống' where  Phong.maKH is null", conn);
                SqlCommand cmd3 = new SqlCommand("update Phong set TinhTrang = N'Hoạt Động' where Phong.maKH is not null and Phong.NgayDen is not null;", conn);
                SqlCommand cmd4 = new SqlCommand("update Phong set TinhTrang = N'Chờ Nhận' where Phong.maKH is not null and Phong.NgayDangKi is not null and Phong.NgayDen is null;", conn);
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error UpDate_TinhTrangPhong");
            }
            finally
            {
                if (conn != null)
                { conn.Close(); }    
                    
            }
            conn.Close();
        }
        private void combobox_LoaiPhong()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select distinct LoaiPhong from Phong", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            string[] LoaiPhong = dtTableName.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            for (int i = 0; i < LoaiPhong.Length; i++)
            {
                LoaiPhong[i] = LoaiPhong[i].Trim();

            }
            List<string> cbb_LoaiPhong = new List<string>(LoaiPhong);
            comboBox_loaiphong_LeTan.DataSource = cbb_LoaiPhong;
            conn.Close();
        }
        private void combobox_SoPhong()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select SoPhong from Phong where LoaiPhong = " + "N'" + comboBox_loaiphong_LeTan.SelectedValue + "'" + " and TinhTrang = N'Trống'", conn); ;
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            string[] SoPhong = dtTableName.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            for (int i = 0; i < SoPhong.Length; i++)
            {
                SoPhong[i] = SoPhong[i].Trim();

            }
            List<string> cbb_SoPhong = new List<string>(SoPhong);
            comboBox_sophong_LeTan.DataSource = cbb_SoPhong;

            if (SoPhong.Length < 1)
            {
                comboBox_sophong_LeTan.Text = "--Hết Phòng--";

            }
            conn.Close();

        }
        private void Hien_GiaPhong_TheoLoaiPhong()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select distinct GiaPhong from Phong where LoaiPhong = " + "N'" + comboBox_loaiphong_LeTan.SelectedValue + "'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            decimal GiaPhong = dtTableName.Rows[0].Field<decimal>("GiaPhong");
            tb_giaphong_LeTan.Text = GiaPhong.ToString();
            conn.Close();
        }


        private void Load_DataGridView_themthongtinKH()
        {
                conn.Open();
                SqlDataAdapter daTableName = new SqlDataAdapter("select KhachHang.maKH, KhachHang.TenKH, KhachHang.GioiTinh, Phong.SoPhong, Phong.LoaiPhong, Convert(varchar(20), NgayDangKi, 113) as NgayDangKi, Convert(varchar(20), NgayDen, 113) as NgayDen, Convert(varchar(20), NgayDi, 113) as NgayDi from KhachHang inner join Phong on KhachHang.maKH = Phong.maKH", conn);
                DataTable dtTableName = new DataTable();
                daTableName.Fill(dtTableName);
                dataGridView_themthongtinKH_LeTan.DataSource = dtTableName;
                conn.Close(); 
        }
        private void clearThongTinKhachHang()
        {
            tb_makh_LeTan.Text = "";
            tb_tenKH_LeTan.Text = "";
            radioButton_nam_leTan.Checked = false;
            radioButton_nu_LeTan.Checked = false;
            tb_diachi_LeTan.Text = "";
            tb_socmt_LeTan.Text = "";
            tb_quoctich_LeTan.Text = "";
            tb_sodt.Text = "";
        }

        private void Them_KH()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into KHACHHANG ([maKH],[TenKH],[NgaySinh],[GioiTinh],[DiaChi],[SoCMT],[QuocTich],[Sdt]) values (@makh,@tenkh,@ngaysinh,@gioitinh,@diachi,@socmt,@quoctich,@sdt)", conn);
                cmd.Parameters.AddWithValue("@makh", tb_makh_LeTan.Text);
                cmd.Parameters.AddWithValue("@tenkh", tb_tenKH_LeTan.Text);
                DateTime date = dateTimePicker_ngaysinh_LeTan.Value;
                cmd.Parameters.AddWithValue("@ngaysinh", date);
                cmd.Parameters.AddWithValue("@gioitinh", str_gioitinh);
                cmd.Parameters.AddWithValue("@diachi", tb_diachi_LeTan.Text);
                cmd.Parameters.AddWithValue("@socmt", tb_socmt_LeTan.Text);
                cmd.Parameters.AddWithValue("@quoctich", tb_quoctich_LeTan.Text);
                cmd.Parameters.AddWithValue("@sdt", tb_sodt.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập thông tin khách hàng!");
            }
            finally
            {
                if (conn != null)
                { conn.Close(); }
            }

        }

        private void Thue_Phong()
        {
            try
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("update Phong set maKH = @makh , NgayDangKi = @ngaydangki, NgayDen = @ngayden, NgayDi = @ngaydi where SoPhong = @sophong;", conn);
                cmd1.Parameters.AddWithValue("@sophong", comboBox_sophong_LeTan.SelectedValue);
                cmd1.Parameters.AddWithValue("@makh", tb_makh_LeTan.Text);
                DateTime ngaydangki = dateTimePicker_ngaydangki_LeTan.Value;
                DateTime ngayden = dateTimePicker_ngayden_LeTan.Value;
                DateTime ngaydi = dateTimePicker_ngaydi_LeTan.Value;
                cmd1.Parameters.AddWithValue("@ngaydangki", ngaydangki);
                cmd1.Parameters.AddWithValue("@ngayden", ngayden);
                cmd1.Parameters.AddWithValue("@ngaydi", ngaydi);
                cmd1.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa nhập thông tin khách hàng!");
            }
            finally
            {
                if (conn != null)
                { conn.Close(); }
            }

        }
        private void Dat_Phong()
        {
            try
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("update Phong set maKH = @makh , NgayDangKi = @ngaydangki, NgayDen = null, NgayDi = @ngaydi where SoPhong = @sophong;", conn);
                cmd1.Parameters.AddWithValue("@sophong", comboBox_sophong_LeTan.SelectedValue);
                cmd1.Parameters.AddWithValue("@makh", tb_makh_LeTan.Text);
                DateTime ngaydangki = dateTimePicker_ngaydangki_LeTan.Value;
                DateTime ngaydi = dateTimePicker_ngaydi_LeTan.Value;
                cmd1.Parameters.AddWithValue("@ngaydangki", ngaydangki);
                cmd1.Parameters.AddWithValue("@ngaydi", ngaydi);
                cmd1.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa nhập thông tin khách hàng!");
            }
            finally
            {
                if (conn != null)
                { conn.Close(); }
            }

        }
        private void radioButton_nam_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton gioitinh = sender as RadioButton;
            if (gioitinh.Checked)
            {
                str_gioitinh = gioitinh.Text;
            }
        }
        private void comboBox_loaiphong_LeTan_DropDownClosed(object sender, EventArgs e)
        {
            Hien_GiaPhong_TheoLoaiPhong();
            combobox_SoPhong();
        }
        private void btn_themthongtinKH_LeTan_Click(object sender, EventArgs e)
        {
            Them_KH();
        }
        private void btn_thuephong_LeTan_Click(object sender, EventArgs e)
        {
            Thue_Phong();
            Load_DataGridView_themthongtinKH();
            UpDate_TinhTrangPhong();
            combobox_SoPhong();
        }  
        private void btn_datphong_LeTan_Click(object sender, EventArgs e)
        {
            Dat_Phong();
            Load_DataGridView_themthongtinKH();
            UpDate_TinhTrangPhong();
            combobox_SoPhong();
        }
        private void btn_lammoi_LeTan_Click(object sender, EventArgs e)
        {
            clearThongTinKhachHang();
            HienMaKH();
        }
    }
} 



