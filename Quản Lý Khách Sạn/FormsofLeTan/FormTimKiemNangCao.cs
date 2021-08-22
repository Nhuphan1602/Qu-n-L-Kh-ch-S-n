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
    public partial class FormTimKiemNangCao : Form
    {
        KetNoiCSDL CSDL = new KetNoiCSDL();
        SqlConnection conn = null;
        string maDV_ThayDoi = null;
        string maDV_HienTai = null;
        string str_gioitinh = null;
        DateTime ngaydangki = DateTime.Now;
        DateTime ngayden = DateTime.Now;
        DateTime ngaydi = DateTime.Now;
        DateTime ngayhientai = DateTime.Now;
        public FormTimKiemNangCao()
        {
            InitializeComponent();
            timer1.Start();
            dateTimePicker_ngaydangki_timkiemnangcaoPhong.Value = new DateTime(ngayhientai.Year, ngayhientai.Month, ngayhientai.Day, 12, 00, 00);
            dateTimePicker_ngaydi_timkiemnangcaoPhong.Value = new DateTime(ngayhientai.Year, ngayhientai.Month, ngayhientai.Day, 12, 00, 00);
            textBox1.Enabled = false;
            dateTimePicker_timkiem.Enabled = false;
            groupBox_timkiemnangcaoDV.Enabled = false;
            tb_tenKH_timkiemnangcaoKH.Enabled = false;
            dateTimePicker_ngaysinh_timkiemnangcaoKH.Enabled = false;
            radioButton_nam_timkiemnangcaoKH.Enabled = false;
            radioButton_nu_timkiemnangcaoKH.Enabled = false;
            tb_diachi_timkiemnangcaoKH.Enabled = false;
            tb_socmt_timkiemnangcaoKH.Enabled = false;
            tb_quoctich_timkiemnangcaoKH.Enabled = false;
            tb_sodt_timkiemnangcaoKH.Enabled = false;
            btn_luuthongtin_timkiemnangcaoKH.Enabled = false;
            btn_lammoi_timkiemnangcaoKH.Enabled = false;
            tb_maKH_timkiemnangcaoPhong.Enabled = false;
            tb_SoPhong_timkiemnangcaoPhong.Enabled = false;
            dateTimePicker_ngaydangki_timkiemnangcaoPhong.Enabled = false;
            dateTimePicker_ngayden_timkiemnangcaoPhong.Enabled = false;
            dateTimePicker_ngaydi_timkiemnangcaoPhong.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            btn_capnhat.Enabled = false;
            btn_xoadangkiphong.Enabled = false;
            conn = CSDL.Connect(); // Thiết Lập Kết Nối
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker_ngayden_timkiemnangcaoPhong.Value = DateTime.Now;
            dateTimePicker_ngaydangki_timkiemnangcaoDV.Value = DateTime.Now;
        }
        
        //
        //
        // Chức năng tìm kiếm + sửa khách hàng, phòng, dịch vụ theo họ tên, số phòng
        //
        //



        //
        // Tìm Kiếm
        //
        private void TimKiemKh_SoPhong()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select  KhachHang.maKH,KhachHang.TenKH, Convert(varchar(20), KhachHang.NgaySinh, 113) as NgaySinh, KhachHang.GioiTinh, KhachHang.DiaChi, KhachHang.SoCMT, KhachHang.QuocTich, KhachHang.Sdt from KhachHang inner join Phong on KhachHang.maKH = Phong.maKH where Phong.SoPhong = '" + textBox1.Text + "'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiemnangcaoKH.DataSource = dtTableName;
            conn.Close();
        }
        private void TimKiemKh_HoTen()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select  KhachHang.maKH,KhachHang.TenKH, Convert(varchar(20), KhachHang.NgaySinh, 113) as NgaySinh, KhachHang.GioiTinh, KhachHang.DiaChi, KhachHang.SoCMT, KhachHang.QuocTich, KhachHang.Sdt from KhachHang  where KhachHang.TenKH = N'" + textBox1.Text + "'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiemnangcaoKH.DataSource = dtTableName;
            conn.Close();
        }

        private void TimKiemPhong_HoTen()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select Phong.maKH, Phong.SoPhong ,  Phong.LoaiPhong, Convert(varchar(20),Phong.NgayDangKi,113) as NgayDangKi, Convert(varchar(20),Phong.NgayDen,113) as NgayDen,Convert(varchar(20),Phong.NgayDi,113) as NgayDi, Phong.TinhTrang from Phong inner join KhachHang on Phong.maKH = KhachHang.maKH where KhachHang.TenKH = N'" + textBox1.Text + "'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiemnangcaoPhong.DataSource = dtTableName;
            conn.Close();
        }
        private void TimKiemPhong_SoPhong()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select Phong.maKH, Phong.SoPhong ,  Phong.LoaiPhong, Convert(varchar(20),Phong.NgayDangKi,113) as NgayDangKi, Convert(varchar(20),Phong.NgayDen,113) as NgayDen , Convert(varchar(20),Phong.NgayDi,113) as NgayDi, Phong.TinhTrang from Phong where Phong.SoPhong = '" + textBox1.Text + "'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiemnangcaoPhong.DataSource = dtTableName;
            conn.Close();
        }

        private void TimKiemDichVu_HoTen()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select KhachHangSuDungDichVu.maKH,KhachHangSuDungDichVu.SoPhong, DichVu.TenDV, KhachHangSuDungDichVu.SoLuong , Convert(varchar(20),KhachHangSuDungDichVu.NgayDangKi,113) as NgayDangKi, KhachHangSuDungDichVu.YeuCau from KhachHangSuDungDichVu inner join KhachHang on KhachHangSuDungDichVu.maKH = KhachHang.maKH inner join DichVu on KhachHangSuDungDichVu.maDV = DichVu.maDV where KhachHang.TenKH = N'" + textBox1.Text + "' order by KhachHangSuDungDichVu.SoPhong desc", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiemnangcaoDV.DataSource = dtTableName;
            conn.Close();
        }
        private void TimKiemDichVu_SoPhong()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select KhachHangSuDungDichVu.maKH, KhachHangSuDungDichVu.SoPhong, DichVu.TenDV, KhachHangSuDungDichVu.SoLuong , Convert(varchar(20),KhachHangSuDungDichVu.NgayDangKi,113) as NgayDangKi, KhachHangSuDungDichVu.YeuCau from KhachHangSuDungDichVu inner join KhachHang on KhachHangSuDungDichVu.maKH = KhachHang.maKH inner join DichVu on KhachHangSuDungDichVu.maDV = DichVu.maDV where KhachHangSuDungDichVu.SoPhong = '" + textBox1.Text + "' order by KhachHangSuDungDichVu.SoPhong desc", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiemnangcaoDV.DataSource = dtTableName;
            conn.Close();
        }
        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (comboBox_timkiem.SelectedItem == "Họ Tên")
                {
                        TimKiemKh_HoTen();
                        TimKiemPhong_HoTen();
                        TimKiemDichVu_HoTen();    
                    if (dataGridView_timkiemnangcaoKH.Rows != null && dataGridView_timkiemnangcaoKH.Rows.Count != 0)
                    {
                        dataGridView_timkiemnangcaoKH.Enabled = true;
                        dataGridView_timkiemnangcaoDV.Enabled = true;
                        dataGridView_timkiemnangcaoPhong.Enabled = true;
                    }
                    else
                    {
                        dataGridView_timkiemnangcaoKH.Enabled = false;
                        dataGridView_timkiemnangcaoDV.Enabled = false;
                        dataGridView_timkiemnangcaoPhong.Enabled = false;
                    }
                }
                else if (comboBox_timkiem.SelectedItem == "Số Phòng")
                {
                        TimKiemKh_SoPhong();
                        TimKiemPhong_SoPhong();
                        TimKiemDichVu_SoPhong();
                    if (dataGridView_timkiemnangcaoKH.Rows != null && dataGridView_timkiemnangcaoKH.Rows.Count != 0)
                    {
                        dataGridView_timkiemnangcaoKH.Enabled = true;
                        dataGridView_timkiemnangcaoDV.Enabled = true;
                        dataGridView_timkiemnangcaoPhong.Enabled = true;
                    }
                    else
                    {
                        dataGridView_timkiemnangcaoKH.Enabled = false;
                        dataGridView_timkiemnangcaoDV.Enabled = false;
                        dataGridView_timkiemnangcaoPhong.Enabled = false;
                    }
                }
            }           
        }
          private void dateTimePicker_timkiem_KeyDown(object sender, KeyEventArgs e)
          {
            if (e.KeyCode == Keys.Enter)
            {
                if (comboBox_timkiem.SelectedItem == "Ngày Đăng Kí")
                {

                    ngaydangki = dateTimePicker_timkiem.Value;
                    TimKiemPhong_NgayDangKi();
                    TimKiemKH_NgayDangKi();
                    dataGridView_timkiemnangcaoDV.DataSource = null;
                    if (dataGridView_timkiemnangcaoKH.Rows != null && dataGridView_timkiemnangcaoKH.Rows.Count != 0)
                    {
                        dataGridView_timkiemnangcaoKH.Enabled = true;
                        dataGridView_timkiemnangcaoDV.Enabled = false;
                        dataGridView_timkiemnangcaoPhong.Enabled = true;
                    }
                    else
                    {
                        dataGridView_timkiemnangcaoKH.Enabled = false;
                        dataGridView_timkiemnangcaoDV.Enabled = false;
                        dataGridView_timkiemnangcaoPhong.Enabled = false;
                    }
                }
                else if (comboBox_timkiem.SelectedItem == "Ngày Đến")
                {
                    ngayden = dateTimePicker_timkiem.Value;
                    TimKiemPhong_NgayDen();
                    TimKiemKH_NgayDen();
                    dataGridView_timkiemnangcaoDV.DataSource = null;
                    if (dataGridView_timkiemnangcaoKH.Rows != null && dataGridView_timkiemnangcaoKH.Rows.Count != 0)
                    {
                        dataGridView_timkiemnangcaoKH.Enabled = true;
                        dataGridView_timkiemnangcaoDV.Enabled = false;
                        dataGridView_timkiemnangcaoPhong.Enabled = true;
                    }
                    else
                    {
                        dataGridView_timkiemnangcaoKH.Enabled = false;
                        dataGridView_timkiemnangcaoDV.Enabled = false;
                        dataGridView_timkiemnangcaoPhong.Enabled = false;
                    }
                }
                else if (comboBox_timkiem.SelectedItem == "Ngày Đi")
                {

                    ngaydi = dateTimePicker_timkiem.Value;
                    TimKiemPhong_NgayDi();
                    TimKiemKH_NgayDi();
                    dataGridView_timkiemnangcaoDV.DataSource = null;
                    if (dataGridView_timkiemnangcaoKH.Rows != null && dataGridView_timkiemnangcaoKH.Rows.Count != 0)
                    {
                        dataGridView_timkiemnangcaoKH.Enabled = true;
                        dataGridView_timkiemnangcaoDV.Enabled = false;
                        dataGridView_timkiemnangcaoPhong.Enabled = true;
                    }
                    else
                    {
                        dataGridView_timkiemnangcaoKH.Enabled = false;
                        dataGridView_timkiemnangcaoDV.Enabled = false;
                        dataGridView_timkiemnangcaoPhong.Enabled = false;
                    }
                }
            }
              
          }
        private void comboBox1_DropDownClosed_1(object sender, EventArgs e)
        {
            if (comboBox_timkiem.SelectedItem == "Họ Tên")
            {
                dateTimePicker_timkiem.Enabled = false;
                textBox1.Enabled = true;
                groupBox_timkiemnangcaoDV.Enabled = true;
                tb_tenKH_timkiemnangcaoKH.Enabled = true;
                dateTimePicker_ngaysinh_timkiemnangcaoKH.Enabled = true;
                radioButton_nam_timkiemnangcaoKH.Enabled = true;
                radioButton_nu_timkiemnangcaoKH.Enabled = true;
                tb_diachi_timkiemnangcaoKH.Enabled = true;
                tb_socmt_timkiemnangcaoKH.Enabled = true;
                tb_quoctich_timkiemnangcaoKH.Enabled = true;
                tb_sodt_timkiemnangcaoKH.Enabled = true;
                btn_luuthongtin_timkiemnangcaoKH.Enabled = true;
                btn_lammoi_timkiemnangcaoKH.Enabled = true;
                tb_maKH_timkiemnangcaoPhong.Enabled = true;
                tb_SoPhong_timkiemnangcaoPhong.Enabled = true;
                dateTimePicker_ngaydangki_timkiemnangcaoPhong.Enabled = true;
                dateTimePicker_ngayden_timkiemnangcaoPhong.Enabled = true;
                dateTimePicker_ngaydi_timkiemnangcaoPhong.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                btn_capnhat.Enabled = false;
                btn_xoadangkiphong.Enabled = false;
            }
            else if (comboBox_timkiem.SelectedItem == "Số Phòng")
            {
                dateTimePicker_timkiem.Enabled = false;
                textBox1.Enabled = true;
                groupBox_timkiemnangcaoDV.Enabled = true;
                tb_tenKH_timkiemnangcaoKH.Enabled = true;
                dateTimePicker_ngaysinh_timkiemnangcaoKH.Enabled = true;
                radioButton_nam_timkiemnangcaoKH.Enabled = true;
                radioButton_nu_timkiemnangcaoKH.Enabled = true;
                tb_diachi_timkiemnangcaoKH.Enabled = true;
                tb_socmt_timkiemnangcaoKH.Enabled = true;
                tb_quoctich_timkiemnangcaoKH.Enabled = true;
                tb_sodt_timkiemnangcaoKH.Enabled = true;
                btn_luuthongtin_timkiemnangcaoKH.Enabled = true;
                btn_lammoi_timkiemnangcaoKH.Enabled = true;
                tb_maKH_timkiemnangcaoPhong.Enabled = true;
                tb_SoPhong_timkiemnangcaoPhong.Enabled = true;
                dateTimePicker_ngaydangki_timkiemnangcaoPhong.Enabled = true;
                dateTimePicker_ngayden_timkiemnangcaoPhong.Enabled = true;
                dateTimePicker_ngaydi_timkiemnangcaoPhong.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                btn_capnhat.Enabled = false;
                btn_xoadangkiphong.Enabled = false;
            }
            else if (comboBox_timkiem.SelectedItem == "Ngày Đăng Kí")
            {
                dateTimePicker_timkiem.Value = new DateTime(ngayhientai.Year, ngayhientai.Month, ngayhientai.Day, 12, 00, 00);
                textBox1.Enabled = false;
                dateTimePicker_timkiem.Enabled = true;
                groupBox_timkiemnangcaoDV.Enabled = false;
                tb_tenKH_timkiemnangcaoKH.Enabled = false;
                dateTimePicker_ngaysinh_timkiemnangcaoKH.Enabled = false;
                radioButton_nam_timkiemnangcaoKH.Enabled = false;
                radioButton_nu_timkiemnangcaoKH.Enabled = false;
                tb_diachi_timkiemnangcaoKH.Enabled = false;
                tb_socmt_timkiemnangcaoKH.Enabled = false;
                tb_quoctich_timkiemnangcaoKH.Enabled = false;
                tb_sodt_timkiemnangcaoKH.Enabled = false;
                btn_luuthongtin_timkiemnangcaoKH.Enabled = false;
                btn_lammoi_timkiemnangcaoKH.Enabled = false;
                tb_maKH_timkiemnangcaoPhong.Enabled = false;
                tb_SoPhong_timkiemnangcaoPhong.Enabled = false;
                dateTimePicker_ngaydangki_timkiemnangcaoPhong.Enabled = false;
                dateTimePicker_ngayden_timkiemnangcaoPhong.Enabled = false;
                dateTimePicker_ngaydi_timkiemnangcaoPhong.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                btn_capnhat.Enabled = true;
                btn_xoadangkiphong.Enabled = true;
            }
            else if (comboBox_timkiem.SelectedItem == "Ngày Đến")
            {
                dateTimePicker_timkiem.Value = new DateTime(ngayhientai.Year, ngayhientai.Month, ngayhientai.Day, 00, 00, 00);
                textBox1.Enabled = false;
                dateTimePicker_timkiem.Enabled = true;
                groupBox_timkiemnangcaoDV.Enabled = false;
                tb_tenKH_timkiemnangcaoKH.Enabled = false;
                dateTimePicker_ngaysinh_timkiemnangcaoKH.Enabled = false;
                radioButton_nam_timkiemnangcaoKH.Enabled = false;
                radioButton_nu_timkiemnangcaoKH.Enabled = false;
                tb_diachi_timkiemnangcaoKH.Enabled = false;
                tb_socmt_timkiemnangcaoKH.Enabled = false;
                tb_quoctich_timkiemnangcaoKH.Enabled = false;
                tb_sodt_timkiemnangcaoKH.Enabled = false;
                btn_luuthongtin_timkiemnangcaoKH.Enabled = false;
                btn_lammoi_timkiemnangcaoKH.Enabled = false;
                tb_maKH_timkiemnangcaoPhong.Enabled = false;
                tb_SoPhong_timkiemnangcaoPhong.Enabled = false;
                dateTimePicker_ngaydangki_timkiemnangcaoPhong.Enabled = false;
                dateTimePicker_ngayden_timkiemnangcaoPhong.Enabled = false;
                dateTimePicker_ngaydi_timkiemnangcaoPhong.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                btn_capnhat.Enabled = false;
                btn_xoadangkiphong.Enabled = false;
            }
            else if (comboBox_timkiem.SelectedItem == "Ngày Đi")
            {
                dateTimePicker_timkiem.Value = new DateTime(ngayhientai.Year, ngayhientai.Month, ngayhientai.Day, 12, 00, 00);
                textBox1.Enabled = false;
                dateTimePicker_timkiem.Enabled = true;
                groupBox_timkiemnangcaoDV.Enabled = false;
                tb_tenKH_timkiemnangcaoKH.Enabled = false;
                dateTimePicker_ngaysinh_timkiemnangcaoKH.Enabled = false;
                radioButton_nam_timkiemnangcaoKH.Enabled = false;
                radioButton_nu_timkiemnangcaoKH.Enabled = false;
                tb_diachi_timkiemnangcaoKH.Enabled = false;
                tb_socmt_timkiemnangcaoKH.Enabled = false;
                tb_quoctich_timkiemnangcaoKH.Enabled = false;
                tb_sodt_timkiemnangcaoKH.Enabled = false;
                btn_luuthongtin_timkiemnangcaoKH.Enabled = false;
                btn_lammoi_timkiemnangcaoKH.Enabled = false;
                tb_maKH_timkiemnangcaoPhong.Enabled = false;
                tb_SoPhong_timkiemnangcaoPhong.Enabled = false;
                dateTimePicker_ngaydangki_timkiemnangcaoPhong.Enabled = false;
                dateTimePicker_ngayden_timkiemnangcaoPhong.Enabled = false;
                dateTimePicker_ngaydi_timkiemnangcaoPhong.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                btn_capnhat.Enabled = false;
                btn_xoadangkiphong.Enabled = false;
            }
        }
        //
        //
        //



        //
        // Sửa Khách Hàng (Họ tên, ngày sinh, giới tính, địa chỉ, số cmt, quốc tịch, sđt)
        //
        private void radioButton_nam_timkiemnangcaoKH_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton gioitinh = sender as RadioButton;
            if (gioitinh.Checked)
            {
                str_gioitinh = gioitinh.Text;
            }
        }
        private void checkGioiTinh()
        {
            int r = dataGridView_timkiemnangcaoKH.CurrentCell.RowIndex;
            if (dataGridView_timkiemnangcaoKH.Rows[r].Cells[3].Value.ToString() == "Nam")
            {
                radioButton_nam_timkiemnangcaoKH.Checked = true;       
            }
            else if (dataGridView_timkiemnangcaoKH.Rows[r].Cells[3].Value.ToString() == "Nữ")
            {
                radioButton_nu_timkiemnangcaoKH.Checked = true;
            }
        }
        private void SuaThongTinKH()
        {
                int r = dataGridView_timkiemnangcaoKH.CurrentCell.RowIndex;
                tb_tenKH_timkiemnangcaoKH.Text = dataGridView_timkiemnangcaoKH.Rows[r].Cells[1].Value.ToString();
                dateTimePicker_ngaysinh_timkiemnangcaoKH.Value = DateTime.ParseExact(dataGridView_timkiemnangcaoKH.Rows[r].Cells[2].Value.ToString(), "dd MMM yyyy", null);
                checkGioiTinh();
                tb_diachi_timkiemnangcaoKH.Text = dataGridView_timkiemnangcaoKH.Rows[r].Cells[4].Value.ToString();
                tb_socmt_timkiemnangcaoKH.Text = dataGridView_timkiemnangcaoKH.Rows[r].Cells[5].Value.ToString();
                tb_quoctich_timkiemnangcaoKH.Text = dataGridView_timkiemnangcaoKH.Rows[r].Cells[6].Value.ToString();
                tb_sodt_timkiemnangcaoKH.Text = dataGridView_timkiemnangcaoKH.Rows[r].Cells[7].Value.ToString();
        }
        private void LuuThongTinKH()
        {
            try
            {
                if (dataGridView_timkiemnangcaoKH.Rows != null && dataGridView_timkiemnangcaoKH.Rows.Count != 0)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update KhachHang set TenKH = @tenkh , NgaySinh = @ngaysinh , GioiTinh = @gioitinh , DiaChi= @diachi , SoCMT = @socmt , QuocTich = @quoctich , Sdt = @sdt where maKH = @makh;", conn);
                    int r = dataGridView_timkiemnangcaoKH.CurrentCell.RowIndex;
                    cmd.Parameters.AddWithValue("@tenkh", tb_tenKH_timkiemnangcaoKH.Text);
                    cmd.Parameters.AddWithValue("@ngaysinh", dateTimePicker_ngaysinh_timkiemnangcaoKH.Value);
                    cmd.Parameters.AddWithValue("@gioitinh", str_gioitinh);
                    cmd.Parameters.AddWithValue("@diachi", tb_diachi_timkiemnangcaoKH.Text);
                    cmd.Parameters.AddWithValue("@socmt", tb_socmt_timkiemnangcaoKH.Text);
                    cmd.Parameters.AddWithValue("@quoctich", tb_quoctich_timkiemnangcaoKH.Text);
                    cmd.Parameters.AddWithValue("@sdt", tb_sodt_timkiemnangcaoKH.Text);
                    cmd.Parameters.AddWithValue("@makh", dataGridView_timkiemnangcaoKH.Rows[r].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi sửa thông tin khách hàng!");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                } 
            }
            
        }
        private void dataGridView_timkiemnangcaoKH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox_timkiem.SelectedItem == "Họ Tên")
            {
                SuaThongTinKH();
            }
            else if (comboBox_timkiem.SelectedItem == "Số Phòng")
            {
                SuaThongTinKH();
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
         
        }
        private void btn_luuthongtin_timkiemnangcaoKH_Click(object sender, EventArgs e)
        {
            LuuThongTinKH();
            if (comboBox_timkiem.SelectedItem == "Họ Tên")
            {
                TimKiemKh_HoTen();
            }
            else if (comboBox_timkiem.SelectedItem == "Số Phòng")
            {
                TimKiemKh_SoPhong();
            }
        }
        private void ClearData_KH()
        {
            tb_tenKH_timkiemnangcaoKH.Text = "";
            dateTimePicker_ngaysinh_timkiemnangcaoKH.Value = DateTime.Now;
            radioButton_nam_timkiemnangcaoKH.Checked = false;
            radioButton_nu_timkiemnangcaoKH.Checked = false;
            tb_diachi_timkiemnangcaoKH.Text = "";
            tb_socmt_timkiemnangcaoKH.Text = "";
            tb_quoctich_timkiemnangcaoKH.Text = "";
            tb_sodt_timkiemnangcaoKH.Text = "";
        }
        private void btn_lammoi_timkiemnangcaoKH_Click(object sender, EventArgs e)
        {
            ClearData_KH();
        }
        //
        //
        //



        //
        // Sửa Phòng (Ngày đăng kí, Ngày đi, Ngày đến)
        //
        private void SuaThongTinPhong()
        {
            int r = dataGridView_timkiemnangcaoPhong.CurrentCell.RowIndex;
            tb_maKH_timkiemnangcaoPhong.Text = dataGridView_timkiemnangcaoPhong.Rows[r].Cells[0].Value.ToString();
            tb_SoPhong_timkiemnangcaoPhong.Text = dataGridView_timkiemnangcaoPhong.Rows[r].Cells[1].Value.ToString();
            dateTimePicker_ngaydangki_timkiemnangcaoPhong.Value = DateTime.ParseExact(dataGridView_timkiemnangcaoPhong.Rows[r].Cells[3].Value.ToString(), "dd MMM yyyy HH:mm:ss", null);
            dateTimePicker_ngayden_timkiemnangcaoPhong.Value = DateTime.ParseExact(dataGridView_timkiemnangcaoPhong.Rows[r].Cells[3].Value.ToString(), "dd MMM yyyy HH:mm:ss", null);
            dateTimePicker_ngaydi_timkiemnangcaoPhong.Value = DateTime.ParseExact(dataGridView_timkiemnangcaoPhong.Rows[r].Cells[5].Value.ToString(), "dd MMM yyyy HH:mm:ss", null);
        }
        private void LuuThongTinPhong()
        {
            if (tb_maKH_timkiemnangcaoPhong.Text != "" && tb_SoPhong_timkiemnangcaoPhong.Text != "")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update Phong set NgayDangKi=@ngaydangki, NgayDen=@ngayden, NgayDi=@ngaydi where maKH = @makh and SoPhong = @sophong ", conn);
                cmd.Parameters.AddWithValue("@ngaydangki", dateTimePicker_ngaydangki_timkiemnangcaoPhong.Value);
                cmd.Parameters.AddWithValue("@ngayden", dateTimePicker_ngayden_timkiemnangcaoPhong.Value);
                cmd.Parameters.AddWithValue("@ngaydi", dateTimePicker_ngaydi_timkiemnangcaoPhong.Value);
                cmd.Parameters.AddWithValue("@makh", tb_maKH_timkiemnangcaoPhong.Text);
                cmd.Parameters.AddWithValue("@sophong", tb_SoPhong_timkiemnangcaoPhong.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Lỗi sửa thông tin phòng");
            }     
        }
        private void dataGridView_timkiemnangcaoPhong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox_timkiem.SelectedItem == "Họ Tên")
            {
                SuaThongTinPhong();
            }
            else if (comboBox_timkiem.SelectedItem == "Số Phòng")
            {
                SuaThongTinPhong();
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
            int r = dataGridView_timkiemnangcaoPhong.CurrentCell.RowIndex;
            if (dataGridView_timkiemnangcaoPhong.Rows[r].Cells[6].Value.ToString() == "Hoạt Động")
            {
                dateTimePicker_ngaydangki_timkiemnangcaoPhong.Enabled = false;
                dateTimePicker_ngayden_timkiemnangcaoPhong.Enabled = false;
                dateTimePicker_ngaydi_timkiemnangcaoPhong.Enabled = true;
            }
            else if (dataGridView_timkiemnangcaoPhong.Rows[r].Cells[6].Value.ToString() == "Chờ Nhận")
            {
                dateTimePicker_ngaydi_timkiemnangcaoPhong.Enabled = false;
                dateTimePicker_ngaydangki_timkiemnangcaoPhong.Enabled = false;
                dateTimePicker_ngayden_timkiemnangcaoPhong.Enabled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LuuThongTinPhong();
            if (comboBox_timkiem.SelectedItem == "Họ Tên")
            {
                TimKiemPhong_HoTen();
            }
            else if (comboBox_timkiem.SelectedItem == "Số Phòng")
            {
                TimKiemPhong_SoPhong();
            }
        }
        private void ClearData_Phong()
        {
            tb_maKH_timkiemnangcaoPhong.Text = "";
            tb_SoPhong_timkiemnangcaoPhong.Text = "";
            dateTimePicker_ngaydangki_timkiemnangcaoPhong.Value = DateTime.Now;
            dateTimePicker_ngayden_timkiemnangcaoPhong.Value = DateTime.Now;
            dateTimePicker_ngaydi_timkiemnangcaoPhong.Value = DateTime.Now;
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            ClearData_Phong();
        }
        //
        //
        //



        //
        // Sửa Dịch Vụ (tên dịch vụ, ngày đăng kí, số lượng)
        //
        private void combobox_DichVu()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select distinct TenDV from DichVu", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            string[] DichVu = dtTableName.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            for (int i = 0; i < DichVu.Length; i++)
            {
                DichVu[i] = DichVu[i].Trim();
            }
            List<string> cbb_dichvu = new List<string>(DichVu);
            comboBox_tenDV_timkiemnangcaoDV.DataSource = cbb_dichvu;
            conn.Close();
        }
        private void CungCap_MaDV_ThayDoi()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select distinct maDV from DichVu where TenDv = N'" + comboBox_tenDV_timkiemnangcaoDV.SelectedValue + "'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            maDV_ThayDoi = dtTableName.Rows[0].Field<string>("maDV");
            conn.Close();
        }
        private void CungCap_MaDV_HienTai()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select distinct maDV from DichVu where TenDv = N'" + dataGridView_timkiemnangcaoDV.Rows[dataGridView_timkiemnangcaoDV.CurrentCell.RowIndex].Cells[2].Value.ToString() + "'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            maDV_HienTai = dtTableName.Rows[0].Field<string>("maDV");
            conn.Close();
        }
        private void Hien_GiaDV()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select distinct GiaDV from DichVu where TenDv = N'" + comboBox_tenDV_timkiemnangcaoDV.SelectedValue + "'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            decimal gia_dichvu = dtTableName.Rows[0].Field<decimal>("GiaDV");
            tb_giadichvu_timkiemnangcaoDV.Text = Convert.ToInt32(gia_dichvu * 100000).ToString() + "VNĐ";
            conn.Close();
        }       
        private void SuaThongTinDichVu()
        {
            int r = dataGridView_timkiemnangcaoDV.CurrentCell.RowIndex;
            tb_maKH_timkiemnangcaoDV.Text = dataGridView_timkiemnangcaoDV.Rows[r].Cells[0].Value.ToString();
            tb_sophong_timkiemnangcaoDV.Text = dataGridView_timkiemnangcaoDV.Rows[r].Cells[1].Value.ToString();
            comboBox_tenDV_timkiemnangcaoDV.SelectedItem = dataGridView_timkiemnangcaoDV.Rows[r].Cells[2].Value.ToString();
            dateTimePicker_ngaydangki_timkiemnangcaoDV.Value = DateTime.ParseExact(dataGridView_timkiemnangcaoDV.Rows[r].Cells[4].Value.ToString(), "dd MMM yyyy HH:mm:ss", null);
            tb_soluong_timkiemnangcaoDV.Text = dataGridView_timkiemnangcaoDV.Rows[r].Cells[3].Value.ToString();
        }

        private void LuuThongTinDichVu()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update KhachHangSuDungDichVu set maDV=@madv_new, SoLuong=@soluong, NgayDangKi=@ngaydangki where maKH=@makh and SoPhong=@sophong and maDV=@madv_old and YeuCau = N'Chưa Xử lý'", conn);
                cmd.Parameters.AddWithValue("@madv_new", maDV_ThayDoi);
                cmd.Parameters.AddWithValue("@soluong", tb_soluong_timkiemnangcaoDV.Text);
                cmd.Parameters.AddWithValue("@ngaydangki", dateTimePicker_ngaydangki_timkiemnangcaoDV.Value);
                cmd.Parameters.AddWithValue("@makh", tb_maKH_timkiemnangcaoDV.Text);
                cmd.Parameters.AddWithValue("@sophong", tb_sophong_timkiemnangcaoDV.Text);
                cmd.Parameters.AddWithValue("@madv_old", maDV_HienTai);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi sửa dịch vụ!");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            
        }
        private void comboBox_tenDV_timkiemnangcaoDV_DropDownClosed(object sender, EventArgs e)
        {
            Hien_GiaDV();
            CungCap_MaDV_ThayDoi();
        }
        private void dataGridView_timkiemnangcaoDV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox_timkiem.SelectedItem == "Họ Tên")
            {
                SuaThongTinDichVu();
            }
            else if (comboBox_timkiem.SelectedItem == "Số Phòng")
            {
                SuaThongTinDichVu();
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
            combobox_DichVu();
            Hien_GiaDV();
            CungCap_MaDV_ThayDoi();
            CungCap_MaDV_HienTai();
        }
        private void btn_luuDV_timkiemnangcaoDV_Click(object sender, EventArgs e)
        {
            LuuThongTinDichVu();
            if (comboBox_timkiem.SelectedItem == "Họ Tên")
            {
                TimKiemDichVu_HoTen();
            }
            else if (comboBox_timkiem.SelectedItem == "Số Phòng")
            {
                TimKiemDichVu_SoPhong();
            }
        }
        private void ClearData_DV()
        {
            tb_maKH_timkiemnangcaoDV.Text = "";
            tb_sophong_timkiemnangcaoDV.Text = "";
            comboBox_tenDV_timkiemnangcaoDV.SelectedItem = "";
            dateTimePicker_ngaydangki_timkiemnangcaoDV.Value = DateTime.Now;
            tb_soluong_timkiemnangcaoDV.Text = "";
        }
        private void btn_lammoi_timkiemnangcaoDV_Click_1(object sender, EventArgs e)
        {
            ClearData_DV();
        }
        private void XoaThongTin_KH_DV()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from KhachHangSuDungDichVu where maKH=@makh and SoPhong=@sophong and maDV=@madv_old", conn);
                cmd.Parameters.AddWithValue("@makh", tb_maKH_timkiemnangcaoDV.Text);
                cmd.Parameters.AddWithValue("@sophong", tb_sophong_timkiemnangcaoDV.Text);
                cmd.Parameters.AddWithValue("@madv_old", maDV_HienTai);
                cmd.ExecuteNonQuery();
                conn.Close();
                ClearData_DV();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xóa dịch vụ!");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            
        }
        private void btn_xoaDV_timkiemnangcaoDV_Click(object sender, EventArgs e)
        {
            XoaThongTin_KH_DV();
            if (comboBox_timkiem.SelectedItem == "Họ Tên")
            {
                TimKiemDichVu_HoTen();
            }
            else if (comboBox_timkiem.SelectedItem == "Số Phòng")
            {
                TimKiemDichVu_SoPhong();
            }
        }
        //
        //
        //



        //
        //
        //
        //
        //




        //
        //
        // Chức năng tìm kiếm khách hàng, phòng theo ngày đăng kí, ngày dến, ngày đi + xóa khách hàng nhận phòng trễ
        //
        //


        private void TimKiemPhong_NgayDangKi()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select maKH,SoPhong,LoaiPhong,convert(varchar(20),NgayDangKi,113) as NgayDangKi,convert(varchar(20),NgayDen,113) as NgayDen,convert(varchar(20),NgayDi,113) as NgayDi,TinhTrang from Phong where NgayDangKi = '" + ngaydangki + "' and TinhTrang in (N'Chờ Nhận',N'Nhận Phòng Trễ')", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiemnangcaoPhong.DataSource = dtTableName;
            conn.Close();
        }
        private void TimKiemKH_NgayDangKi()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select KhachHang.maKH,KhachHang.TenKH, Convert(varchar(20), KhachHang.NgaySinh, 113) as NgaySinh, KhachHang.GioiTinh, KhachHang.DiaChi, KhachHang.SoCMT, KhachHang.QuocTich, KhachHang.Sdt from KhachHang where Exists (select * from Phong where Phong.NgayDangKi = '" + ngaydangki + "' and Phong.TinhTrang in (N'Chờ Nhận',N'Nhận Phòng Trễ') and Phong.maKH = KhachHang.maKH)", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiemnangcaoKH.DataSource = dtTableName;
            conn.Close();
        }
        private void TimKiemPhong_NgayDen()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select maKH,SoPhong,LoaiPhong,TinhTrang,convert(varchar(20),NgayDangKi,113) as NgayDangKi,convert(varchar(20),NgayDen,113) as NgayDen,convert(varchar(20),NgayDi,113) as NgayDi from Phong where NgayDen >= '" + ngayden.ToString("yyyy-MM-dd") + " 00:00:00.000' AND NgayDen <= '" + ngayden.ToString("yyyy-MM-dd") + " 23:59:59.000'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiemnangcaoPhong.DataSource = dtTableName;
            conn.Close();
        }
        private void TimKiemKH_NgayDen()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select KhachHang.maKH,KhachHang.TenKH, Convert(varchar(20), KhachHang.NgaySinh, 113) as NgaySinh, KhachHang.GioiTinh, KhachHang.DiaChi, KhachHang.SoCMT, KhachHang.QuocTich, KhachHang.Sdt from KhachHang where Exists (select * from Phong where Phong.NgayDen >= '" + ngayden.ToString("yyyy-MM-dd") + " 00:00:00.000' AND Phong.NgayDen <= '" + ngayden.ToString("yyyy-MM-dd") + " 23:59:59.000' and Phong.maKH = KhachHang.maKH)", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiemnangcaoKH.DataSource = dtTableName;
            conn.Close();
        }
        private void TimKiemPhong_NgayDi()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select maKH,SoPhong,LoaiPhong,TinhTrang,convert(varchar(20),NgayDangKi,113) as NgayDangKi,convert(varchar(20),NgayDen,113) as NgayDen,convert(varchar(20),NgayDi,113) as NgayDi from Phong where NgayDi = '" + ngaydi + "'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiemnangcaoPhong.DataSource = dtTableName;
            conn.Close();
        }
        private void TimKiemKH_NgayDi()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select KhachHang.maKH,KhachHang.TenKH, Convert(varchar(20), KhachHang.NgaySinh, 113) as NgaySinh, KhachHang.GioiTinh, KhachHang.DiaChi, KhachHang.SoCMT, KhachHang.QuocTich, KhachHang.Sdt from KhachHang where Exists (select * from Phong where Phong.NgayDi = '" + ngaydi + "' and Phong.maKH = KhachHang.maKH)", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiemnangcaoKH.DataSource = dtTableName;
            conn.Close();
        }


        private void CapNhat()
        {

            DateTime ngaydangki = new DateTime();
            TimeSpan tp = new TimeSpan();
            for (int i = 0; i < dataGridView_timkiemnangcaoPhong.RowCount; i++)
            {
                ngaydangki = DateTime.ParseExact(dataGridView_timkiemnangcaoPhong.Rows[i].Cells[3].Value.ToString(), "dd MMM yyyy HH:mm:ss", null);
                tp = ngaydangki - DateTime.Now;
                if (tp.TotalHours < 0)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update Phong set TinhTrang = N'Nhận Phòng Trễ' where maKH = @makh and SoPhong = @sophong", conn);
                    cmd.Parameters.AddWithValue("@makh", dataGridView_timkiemnangcaoPhong.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@sophong", dataGridView_timkiemnangcaoPhong.Rows[i].Cells[1].Value.ToString());
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

            }
        }
        private void XoaKhachNhanPhongTre()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Phong set TinhTrang = N'Trống' ,maKH = null, NgayDangKi = null, NgayDen = null, NgayDi = null where TinhTrang = N'Nhận Phòng Trễ' and NgayDangKi = @ngaydangki", conn);
            cmd.Parameters.AddWithValue("@ngaydangki", ngaydangki);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            CapNhat();
            TimKiemPhong_NgayDangKi();
        }
        private void btn_xoadangkiphong_Click(object sender, EventArgs e)
        {
            XoaKhachNhanPhongTre();
            TimKiemPhong_NgayDangKi();
            TimKiemKH_NgayDangKi();
            if (dataGridView_timkiemnangcaoKH.Rows != null && dataGridView_timkiemnangcaoKH.Rows.Count != 0)
            {
                dataGridView_timkiemnangcaoKH.Enabled = true;
                dataGridView_timkiemnangcaoDV.Enabled = false;
                dataGridView_timkiemnangcaoPhong.Enabled = true;
            }
            else
            {
                dataGridView_timkiemnangcaoKH.Enabled = false;
                dataGridView_timkiemnangcaoDV.Enabled = false;
                dataGridView_timkiemnangcaoPhong.Enabled = false;
            }
        }

        private void FormTimKiemNangCao_Load(object sender, EventArgs e)
        {
            LoadTheme1();
            LoadTheme2();
            LoadTheme3();
        }

        private void LoadTheme1()
        {
            foreach (Control btns in groupBox_timkiemnangcaoKH.Controls)
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
            foreach (Control btns in groupBox_timkiemnangcaoDV.Controls)
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

        private void LoadTheme3()
        {
            foreach (Control btns in groupBox_timkiemnangcaoPhong.Controls)
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
        //
        //
        //
        //
    }
}
