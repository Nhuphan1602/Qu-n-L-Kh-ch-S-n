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
    public partial class FormThanhToan : Form
    {
        KetNoiCSDL CSDL = new KetNoiCSDL();
        SqlConnection conn = null;
        public FormThanhToan()
        {
            InitializeComponent();
            conn = CSDL.Connect();
        }
        private void TimKiem_Phong_DichVu_HoTen()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select Phong.maKH, Phong.SoPhong, Phong.LoaiPhong as LoaiPhong_maDv, convert(varchar(20),Phong.NgayDangKi,113) as NgayDangKi, convert(varchar(20),Phong.NgayDen,113) as NgayDen, convert(varchar(20),Phong.NgayDi,113) as NgayDi from Phong inner join KhachHang on Phong.maKH = KhachHang.maKH where TenKH = N'" + tb_timkiem_ThanhToan.Text + "' and Phong.TinhTrang = N'Hoạt Động' union all (select KhachHangSuDungDichVu.maKH, KhachHangSuDungDichVu.SoPhong, KhachHangSuDungDichVu.maDV, DichVu.TenDV, convert(varchar(20),KhachHangSuDungDichVu.SoLuong), convert(varchar(20),KhachHangSuDungDichVu.NgayDangKi,113) as NgayDangKi from KhachHangSuDungDichVu inner join DichVu on KhachHangSuDungDichVu.maDV = DichVu.maDV inner join KhachHang on KhachHangSuDungDichVu.maKH = KhachHang.maKH where KhachHang.TenKH = N'" + tb_timkiem_ThanhToan.Text + "' and KhachHangSuDungDichVu.YeuCau = N'Đã Xử Lý')", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiem_ThanhToan.DataSource = dtTableName;
            conn.Close();
        }
        private void TimKiem_Phong_DichVu_SoPhong()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select Phong.maKH, Phong.SoPhong, Phong.LoaiPhong as LoaiPhong_maDv, convert(varchar(20),Phong.NgayDangKi,113) as NgayDangKi, convert(varchar(20),Phong.NgayDen,113) as NgayDen, convert(varchar(20),Phong.NgayDi,113) as NgayDi from Phong  where SoPhong = '" + tb_timkiem_ThanhToan.Text + "' and Phong.TinhTrang = N'Hoạt Động' union all (select KhachHangSuDungDichVu.maKH, KhachHangSuDungDichVu.SoPhong, KhachHangSuDungDichVu.maDV, DichVu.TenDV, convert(varchar(20),KhachHangSuDungDichVu.SoLuong), convert(varchar(20),KhachHangSuDungDichVu.NgayDangKi,113) as NgayDangKi from KhachHangSuDungDichVu inner join DichVu on KhachHangSuDungDichVu.maDV = DichVu.maDV inner join Phong on KhachHangSuDungDichVu.SoPhong = Phong.SoPhong where Phong.SoPhong = '" + tb_timkiem_ThanhToan.Text + "' and KhachHangSuDungDichVu.YeuCau = N'Đã Xử Lý');", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiem_ThanhToan.DataSource = dtTableName;
            conn.Close();
        }

        private void HienThongTinKH_HoTen()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select * from KhachHang where TenKH = N'"+ tb_timkiem_ThanhToan.Text +"'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            tb_maKH_ThanhToan.Text = dtTableName.Rows[0].Field<string>("maKH");
            tb_tenKH_ThanhToan.Text = dtTableName.Rows[0].Field<string>("TenKH");
            tb_sodt_ThanhToan.Text = dtTableName.Rows[0].Field<string>("sdt");
            tb_quoctich_ThanhToan.Text = dtTableName.Rows[0].Field<string>("QuocTich");
            tb_diachi_ThanhToan.Text = dtTableName.Rows[0].Field<string>("DiaChi");
            dateTimePicker_ngaysinh_ThanhToan.Value = dtTableName.Rows[0].Field<DateTime>("NgaySinh");
            tb_gioitinh_ThanhToan.Text = dtTableName.Rows[0].Field<string>("GioiTinh");
            tb_socmt_ThanhToan.Text = dtTableName.Rows[0].Field<string>("SoCMT");
            conn.Close();
        }
        private void HienThongTinKH_SoPhong()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select * from KhachHang inner join Phong on KhachHang.maKh = Phong.maKH where Phong.SoPhong = '" + tb_timkiem_ThanhToan.Text + "'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            tb_maKH_ThanhToan.Text = dtTableName.Rows[0].Field<string>("maKH");
            tb_tenKH_ThanhToan.Text = dtTableName.Rows[0].Field<string>("TenKH");
            tb_sodt_ThanhToan.Text = dtTableName.Rows[0].Field<string>("sdt");
            tb_quoctich_ThanhToan.Text = dtTableName.Rows[0].Field<string>("QuocTich");
            tb_diachi_ThanhToan.Text = dtTableName.Rows[0].Field<string>("DiaChi");
            dateTimePicker_ngaysinh_ThanhToan.Value = dtTableName.Rows[0].Field<DateTime>("NgaySinh");
            tb_gioitinh_ThanhToan.Text = dtTableName.Rows[0].Field<string>("GioiTinh");
            tb_socmt_ThanhToan.Text = dtTableName.Rows[0].Field<string>("SoCMT");
            conn.Close();
        }
        private void Clear_HienThongTinKH_SoPhong()
        {
            tb_maKH_ThanhToan.Text = "";
            tb_tenKH_ThanhToan.Text = "";
            tb_sodt_ThanhToan.Text = "";
            tb_quoctich_ThanhToan.Text = "";
            tb_diachi_ThanhToan.Text = "";
            dateTimePicker_ngaysinh_ThanhToan.Value = DateTime.Now;
            tb_gioitinh_ThanhToan.Text = "";
            tb_socmt_ThanhToan.Text = "";
        }
        private void tb_timkiem_ThanhToan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comboBox_timkiem_ThanhToan.SelectedItem == "Họ Tên")
                {
                    TimKiem_Phong_DichVu_HoTen();
                    if (dataGridView_timkiem_ThanhToan.Rows != null && dataGridView_timkiem_ThanhToan.Rows.Count != 0)
                    {
                        HienThongTinKH_HoTen();
                    }
                    else
                    {
                        Clear_HienThongTinKH_SoPhong();
                    }
                    HienHoaDon();
                }
                else if (comboBox_timkiem_ThanhToan.SelectedItem == "Số Phòng")
                {
                    TimKiem_Phong_DichVu_SoPhong();
                    if (dataGridView_timkiem_ThanhToan.Rows != null && dataGridView_timkiem_ThanhToan.Rows.Count != 0)
                    {
                        HienThongTinKH_SoPhong();
                    }
                    else
                    {
                        Clear_HienThongTinKH_SoPhong();
                    }
                    HienHoaDon();
                }
            }
        }

        private int TaoMaHD()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select top 1 maHD from HoaDon order by maHD desc", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            string[] maHD_array = dtTableName.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            int maHD = 0;
            if (maHD_array.Length < 1)
            {
                maHD = 1;
            }
            else 
            {
                maHD = Int32.Parse(maHD_array[0]) + 1;
            }
            conn.Close();
            return maHD;
        }

        private string TaoMaNV()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select maNV from NhanVien where ChucVu = N'Lễ tân' and maBP = 'DT'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            string maNV = dtTableName.Rows[0].Field<string>("maNV");
            conn.Close();
            return maNV;
        }
        private string[] TaoChiTietHoaDon()
        {
            string SoPhong = null;
            string LoaiPhong_maDV = null;
            string[] ChiTietHoaDon = new string[dataGridView_timkiem_ThanhToan.RowCount];
            for (int i = 0; i < dataGridView_timkiem_ThanhToan.RowCount; i++)
            {
                SoPhong = dataGridView_timkiem_ThanhToan.Rows[i].Cells[1].Value.ToString();
                LoaiPhong_maDV = dataGridView_timkiem_ThanhToan.Rows[i].Cells[2].Value.ToString();
                if (SoPhong != "" && LoaiPhong_maDV == "Đơn"|| LoaiPhong_maDV == "Đôi")
                {
                    ChiTietHoaDon[i] = "Hóa Đơn Phòng";
                }
                else
                {
                    ChiTietHoaDon[i] = "Hóa Đơn Dịch Vụ";
                }
            }
            return ChiTietHoaDon;
        }

       
        private decimal[] TinhThanhTien()
        {
          
            decimal[] ThanhTien = new decimal[dataGridView_timkiem_ThanhToan.RowCount];
            
            
            for (int i = 0; i < dataGridView_timkiem_ThanhToan.RowCount; i++)
            {
                string SoPhong = dataGridView_timkiem_ThanhToan.Rows[i].Cells[1].Value.ToString();
                string LoaiPhong_maDV = dataGridView_timkiem_ThanhToan.Rows[i].Cells[2].Value.ToString();
                if (SoPhong != "" && LoaiPhong_maDV == "Đơn" || LoaiPhong_maDV == "Đôi")
                {
                    DateTime NgayTraPhong = DateTime.Now;
                    DateTime NgayDangKi = DateTime.ParseExact(dataGridView_timkiem_ThanhToan.Rows[i].Cells[3].Value.ToString(), "dd MMM yyyy HH:mm:ss", null);
                    DateTime NgayDi = DateTime.ParseExact(dataGridView_timkiem_ThanhToan.Rows[i].Cells[5].Value.ToString(), "dd MMM yyyy HH:mm:ss", null);
                    TimeSpan KhoangThoiGianThuePhongThucTe = NgayTraPhong - NgayDangKi; 
                    TimeSpan KhoangThoiGianThuePhongConLai = NgayDi - NgayTraPhong;
                    TimeSpan KhoangThoiGianThuePhongLyThuyet = NgayDi - NgayDangKi;
                    double x = KhoangThoiGianThuePhongThucTe.TotalHours;
                    double y = KhoangThoiGianThuePhongConLai.TotalHours;
                    double z = KhoangThoiGianThuePhongLyThuyet.TotalHours;
                    if (x < z && x > (x + (y % 24) - 24) && x <= (x + (y % 24)))
                    {
                        double SoNgayThue = (x + (y % 24)) / 24;
                        conn.Open();
                        SqlDataAdapter daTableName = new SqlDataAdapter("select distinct GiaPhong from Phong where LoaiPhong = N'"+ dataGridView_timkiem_ThanhToan.Rows[i].Cells[2].Value.ToString() +"'", conn);
                        DataTable dtTableName = new DataTable();
                        daTableName.Fill(dtTableName);
                        decimal GiaPhong = dtTableName.Rows[0].Field<decimal>("GiaPhong");
                        conn.Close();
                        ThanhTien[i] = (decimal)SoNgayThue * GiaPhong;
                    }   
                    else if (x > z)
                    {
                        conn.Open();
                        SqlDataAdapter daTableName = new SqlDataAdapter("select distinct GiaPhong from Phong where LoaiPhong = N'" + dataGridView_timkiem_ThanhToan.Rows[i].Cells[2].Value.ToString() + "'", conn);
                        DataTable dtTableName = new DataTable();
                        daTableName.Fill(dtTableName);
                        decimal GiaPhong = dtTableName.Rows[0].Field<decimal>("GiaPhong");
                        conn.Close();
                        if (x <= z+3)
                        {
                            ThanhTien[i] = GiaPhong * (30 / 100 + 1);
                        }
                        else if (x > z+3 && x <= z+6)
                        {
                            ThanhTien[i] = GiaPhong * (50 / 100 + 1);
                        }
                        else if (x < z + 6)
                        {
                            ThanhTien[i] = GiaPhong * 2;
                        }
                    }
                }
                else
                {
                    conn.Open();
                    SqlDataAdapter daTableName = new SqlDataAdapter("select distinct GiaDV from DichVu where maDV = '" + dataGridView_timkiem_ThanhToan.Rows[i].Cells[2].Value.ToString() + "'", conn);
                    DataTable dtTableName = new DataTable();
                    daTableName.Fill(dtTableName);
                    decimal GiaDV = dtTableName.Rows[0].Field<decimal>("GiaDV");
                    conn.Close();
                    decimal SL = decimal.Parse(dataGridView_timkiem_ThanhToan.Rows[i].Cells[4].Value.ToString(), System.Globalization.NumberStyles.Number);
                    ThanhTien[i] = GiaDV*SL;
                }
            }
            return ThanhTien;
        }
        private void TaoHoaDonAll()
        {
            if (dataGridView_timkiem_ThanhToan.Rows != null && dataGridView_timkiem_ThanhToan.Rows.Count != 0)
            {

                int maHD = TaoMaHD();
                string maNV = TaoMaNV();
                decimal[] ThanhTien = TinhThanhTien();
                string[] ChiTietHoaDon = TaoChiTietHoaDon();
                for (int i = 0; i < dataGridView_timkiem_ThanhToan.RowCount; i++)
                {
                    string SoPhong = dataGridView_timkiem_ThanhToan.Rows[i].Cells[1].Value.ToString();
                    string LoaiPhong_maDV = dataGridView_timkiem_ThanhToan.Rows[i].Cells[2].Value.ToString();
                    if (SoPhong != "" && LoaiPhong_maDV == "Đơn" || LoaiPhong_maDV == "Đôi")
                    {
                        maHD = TaoMaHD();
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("insert into HoaDon (maHD, ChiTietHoaDon, ThanhTien, maNV, NgayLap, maDV, SoPhong, maKH, PhuongThucThanhToan) values (@mahd, @chitiethoadon, @thanhtien, @manv, @ngaylap, NULL, @sophong, @makh, @phuongthucthanhtoan)", conn);
                        cmd.Parameters.AddWithValue("@mahd", maHD);
                        cmd.Parameters.AddWithValue("@chitiethoadon", ChiTietHoaDon[i]);
                        cmd.Parameters.AddWithValue("@ThanhTien", ThanhTien[i]);
                        cmd.Parameters.AddWithValue("@maNV", maNV);
                        cmd.Parameters.AddWithValue("@NgayLap", DateTime.Now);

                        cmd.Parameters.AddWithValue("@SoPhong", dataGridView_timkiem_ThanhToan.Rows[i].Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@maKH", dataGridView_timkiem_ThanhToan.Rows[i].Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@PhuongThucThanhToan", comboBox_phuongthucTT_ThanhToan.SelectedItem);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    else
                    {
                        maHD = TaoMaHD();
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("insert into HoaDon (maHD, ChiTietHoaDon, ThanhTien, maNV, NgayLap, maDV, SoPhong, maKH, PhuongThucThanhToan) values (@mahd, @chitiethoadon, @thanhtien, @manv, @ngaylap, @madv, @sophong, @makh, @phuongthucthanhtoan)", conn);
                        cmd.Parameters.AddWithValue("@mahd", maHD);
                        cmd.Parameters.AddWithValue("@chitiethoadon", ChiTietHoaDon[i]);
                        cmd.Parameters.AddWithValue("@ThanhTien", ThanhTien[i]);
                        cmd.Parameters.AddWithValue("@maNV", maNV);
                        cmd.Parameters.AddWithValue("@NgayLap", DateTime.Now);
                        cmd.Parameters.AddWithValue("@maDV", dataGridView_timkiem_ThanhToan.Rows[i].Cells[2].Value.ToString());
                        cmd.Parameters.AddWithValue("@SoPhong", dataGridView_timkiem_ThanhToan.Rows[i].Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@maKH", dataGridView_timkiem_ThanhToan.Rows[i].Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@PhuongThucThanhToan", comboBox_phuongthucTT_ThanhToan.SelectedItem);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
        }
        private void TaoHoaDon1()
        {
            if (dataGridView_timkiem_ThanhToan.Rows != null && dataGridView_timkiem_ThanhToan.Rows.Count != 0)
            {
                int maHD = TaoMaHD();
                string maNV = TaoMaNV();
                decimal[] ThanhTien = TinhThanhTien();
                string[] ChiTietHoaDon = TaoChiTietHoaDon();
                int r = dataGridView_timkiem_ThanhToan.CurrentCell.RowIndex;
                string SoPhong = dataGridView_timkiem_ThanhToan.Rows[r].Cells[1].Value.ToString();
                string LoaiPhong_maDV = dataGridView_timkiem_ThanhToan.Rows[r].Cells[2].Value.ToString();
                if (SoPhong != "" && LoaiPhong_maDV == "Đơn" || LoaiPhong_maDV == "Đôi")
                {
                    maHD = TaoMaHD();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into HoaDon (maHD, ChiTietHoaDon, ThanhTien, maNV, NgayLap, maDV, SoPhong, maKH, PhuongThucThanhToan) values (@mahd, @chitiethoadon, @thanhtien, @manv, @ngaylap, NULL, @sophong, @makh, @phuongthucthanhtoan)", conn);
                    cmd.Parameters.AddWithValue("@mahd", maHD);
                    cmd.Parameters.AddWithValue("@chitiethoadon", ChiTietHoaDon[r]);
                    cmd.Parameters.AddWithValue("@ThanhTien", ThanhTien[r]);
                    cmd.Parameters.AddWithValue("@maNV", maNV);
                    cmd.Parameters.AddWithValue("@NgayLap", DateTime.Now);
                    cmd.Parameters.AddWithValue("@SoPhong", dataGridView_timkiem_ThanhToan.Rows[r].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@maKH", dataGridView_timkiem_ThanhToan.Rows[r].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@PhuongThucThanhToan", comboBox_phuongthucTT_ThanhToan.SelectedItem);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    maHD = TaoMaHD();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into HoaDon (maHD, ChiTietHoaDon, ThanhTien, maNV, NgayLap, maDV, SoPhong, maKH, PhuongThucThanhToan) values (@mahd, @chitiethoadon, @thanhtien, @manv, @ngaylap, @madv, @sophong, @makh, @phuongthucthanhtoan)", conn);
                    cmd.Parameters.AddWithValue("@mahd", maHD);
                    cmd.Parameters.AddWithValue("@chitiethoadon", ChiTietHoaDon[r]);
                    cmd.Parameters.AddWithValue("@ThanhTien", ThanhTien[r]);
                    cmd.Parameters.AddWithValue("@maNV", maNV);
                    cmd.Parameters.AddWithValue("@NgayLap", DateTime.Now);
                    cmd.Parameters.AddWithValue("@maDV", dataGridView_timkiem_ThanhToan.Rows[r].Cells[2].Value.ToString());
                    cmd.Parameters.AddWithValue("@SoPhong", dataGridView_timkiem_ThanhToan.Rows[r].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@maKH", dataGridView_timkiem_ThanhToan.Rows[r].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@PhuongThucThanhToan", comboBox_phuongthucTT_ThanhToan.SelectedItem);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
            
        }
        private void XoaThongTinSuDung_KH1()
        {
            if (dataGridView_timkiem_ThanhToan.Rows != null && dataGridView_timkiem_ThanhToan.Rows.Count != 0)
            {
                int r = dataGridView_timkiem_ThanhToan.CurrentCell.RowIndex;
                string SoPhong = dataGridView_timkiem_ThanhToan.Rows[r].Cells[1].Value.ToString();
                string LoaiPhong_maDV = dataGridView_timkiem_ThanhToan.Rows[r].Cells[2].Value.ToString();
                if (SoPhong != "" && LoaiPhong_maDV == "Đơn" || LoaiPhong_maDV == "Đôi")
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update Phong set maKH = null, NgayDangKi = null, NgayDen = null, NgayDi = null where  maKH = @makh and SoPhong = @sophong", conn);
                    cmd.Parameters.AddWithValue("@makh", dataGridView_timkiem_ThanhToan.Rows[r].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@sophong", dataGridView_timkiem_ThanhToan.Rows[r].Cells[1].Value.ToString());
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from KhachHangSuDungDichVu where maKH = @makh and SoPhong = @sophong and maDV = @madv", conn);
                    cmd.Parameters.AddWithValue("@makh", dataGridView_timkiem_ThanhToan.Rows[r].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@sophong", dataGridView_timkiem_ThanhToan.Rows[r].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@madv", dataGridView_timkiem_ThanhToan.Rows[r].Cells[2].Value.ToString());
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            else
            {
                
            }
                    
        }

        private void XoaThongTinSuDung_KHall()
        {
           
            for (int i = 0; i < dataGridView_timkiem_ThanhToan.RowCount; i++)
            {
                string SoPhong = dataGridView_timkiem_ThanhToan.Rows[i].Cells[1].Value.ToString();
                string LoaiPhong_maDV = dataGridView_timkiem_ThanhToan.Rows[i].Cells[2].Value.ToString();
                if (SoPhong != "" && LoaiPhong_maDV == "Đơn" || LoaiPhong_maDV == "Đôi")
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update Phong set maKH = null, NgayDangKi = null, NgayDen = null, NgayDi = null where  maKH = @makh and SoPhong = @sophong", conn);
                    cmd.Parameters.AddWithValue("@makh", dataGridView_timkiem_ThanhToan.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@sophong", dataGridView_timkiem_ThanhToan.Rows[i].Cells[1].Value.ToString());
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from KhachHangSuDungDichVu where maKH = @makh and SoPhong = @sophong and maDV = @madv", conn);
                    cmd.Parameters.AddWithValue("@makh", dataGridView_timkiem_ThanhToan.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@sophong", dataGridView_timkiem_ThanhToan.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@madv", dataGridView_timkiem_ThanhToan.Rows[i].Cells[2].Value.ToString());
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        private void ThanhToan1()
        {
            if (dataGridView_xuathoadon_ThanhToan.Rows != null && dataGridView_xuathoadon_ThanhToan.Rows.Count != 0)
            {
                int r = dataGridView_xuathoadon_ThanhToan.CurrentCell.RowIndex;
                conn.Open();
                SqlCommand cmd = new SqlCommand("update HoaDon set NgayTT = @ngayTT where maHD = @mahd", conn);
                cmd.Parameters.AddWithValue("@ngayTT", DateTime.Now);
                cmd.Parameters.AddWithValue("@mahd", dataGridView_xuathoadon_ThanhToan.Rows[r].Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Thanh toán lỗi!");
            }    
        }
        private void ThanhToanAll()
        {
            if (dataGridView_xuathoadon_ThanhToan.Rows != null && dataGridView_xuathoadon_ThanhToan.Rows.Count != 0)
            {
                for (int i = 0; i < dataGridView_xuathoadon_ThanhToan.RowCount; i++)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update HoaDon set NgayTT = @ngayTT where maHD = @mahd", conn);
                    cmd.Parameters.AddWithValue("@ngayTT", DateTime.Now);
                    cmd.Parameters.AddWithValue("@mahd", dataGridView_xuathoadon_ThanhToan.Rows[i].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }


            }
            else
            {
                MessageBox.Show("Thanh toán lỗi!");
            }
        }
            
        private void HienHoaDon()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select * from HoaDon where maKH = '"+ tb_maKH_ThanhToan.Text + "' and NgayTT is null ", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_xuathoadon_ThanhToan.DataSource = dtTableName;
            conn.Close();
        }
       
        private void btn_xuatHDall_ThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                TaoHoaDonAll();
                XoaThongTinSuDung_KHall();
            }
            catch (Exception)
            {

                MessageBox.Show("Vui lòng nhập phương thức thanh toán!");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }         
            HienHoaDon();
            if (comboBox_timkiem_ThanhToan.SelectedItem == "Họ Tên")
            {
                TimKiem_Phong_DichVu_HoTen();
            }
            else if (comboBox_timkiem_ThanhToan.SelectedItem == "Số Phòng")
            {
                TimKiem_Phong_DichVu_SoPhong();
            }
        }

        private void btn_xuatHD1_ThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                TaoHoaDon1();
                XoaThongTinSuDung_KH1();
            }
            catch (Exception)
            {

                MessageBox.Show("Vui lòng nhập phương thức thanh toán!");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            HienHoaDon();
            if (comboBox_timkiem_ThanhToan.SelectedItem == "Họ Tên")
            {
                TimKiem_Phong_DichVu_HoTen();
            }
            else if (comboBox_timkiem_ThanhToan.SelectedItem == "Số Phòng")
            {
                TimKiem_Phong_DichVu_SoPhong();
            }
        }

        private void btn_thanhtoan_ThanhToanall_Click(object sender, EventArgs e)
        {
            ThanhToanAll();
            HienHoaDon();
        }

        private void btn_thanhtoan1_ThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan1();
            HienHoaDon();
        }

        private void btn_lammoi_ThanhToan_Click(object sender, EventArgs e)
        {
            Clear_HienThongTinKH_SoPhong();
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            LoadTheme1();
            LoadTheme2();
        }

        private void LoadTheme1()
        {
            foreach (Control btns in groupBox_thanhtoan.Controls)
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
            foreach (Control btns in groupBox_timkiem_ThanhToan.Controls)
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
