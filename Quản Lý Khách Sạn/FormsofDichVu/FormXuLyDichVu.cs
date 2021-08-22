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
    public partial class FormXuLyDichVu : Form
    {
        KetNoiCSDL CSDL = new KetNoiCSDL();
        SqlConnection conn = new SqlConnection();
        public FormXuLyDichVu()
        {
            conn = CSDL.Connect();
            InitializeComponent();
            Load_KH_SuDung_DV();
            if (dataGridView_KH_SuDung_DV.Rows != null && dataGridView_KH_SuDung_DV.Rows.Count != 0)
            {
                dataGridView_KH_SuDung_DV.Enabled = true;
                btn_XuLyDV_DichVu.Enabled = true;
            }
            else
            {
                dataGridView_KH_SuDung_DV.Enabled = false;
                btn_XuLyDV_DichVu.Enabled = false;
            }
        }
        private void TimKiem_HoTen()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select KhachHangSuDungDichVu.maKH,KhachHangSuDungDichVu.SoPhong,KhachHangSuDungDichVu.maDV,KhachHangSuDungDichVu.SoLuong,convert(varchar(20),KhachHangSuDungDichVu.NgayDangKi,113),KhachHangSuDungDichVu.YeuCau from KhachHangSuDungDichVu inner join KhachHang on KhachHang.maKH = KhachHangSuDungDichVu.maKH where KhachHang.TenKH = N'"+ tb_timkiem_DichVu.Text +"'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiem_DichVu.DataSource = dtTableName;
            dataGridView_KH_SuDung_DV.DataSource = dtTableName;
            conn.Close();
        }
        private void TimKiem_SoPhong()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select KhachHangSuDungDichVu.maKH,KhachHangSuDungDichVu.SoPhong,KhachHangSuDungDichVu.maDV,KhachHangSuDungDichVu.SoLuong,convert(varchar(20),KhachHangSuDungDichVu.NgayDangKi,113),KhachHangSuDungDichVu.YeuCau from KhachHangSuDungDichVu  where KhachHangSuDungDichVu.SoPhong = '" + tb_timkiem_DichVu.Text + "'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiem_DichVu.DataSource = dtTableName;
            dataGridView_KH_SuDung_DV.DataSource = dtTableName;
            conn.Close();
        }
        private void TimKiem_MaDichVu()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select KhachHangSuDungDichVu.maKH,KhachHangSuDungDichVu.SoPhong,KhachHangSuDungDichVu.maDV,KhachHangSuDungDichVu.SoLuong,convert(varchar(20),KhachHangSuDungDichVu.NgayDangKi,113),KhachHangSuDungDichVu.YeuCau from KhachHangSuDungDichVu  where KhachHangSuDungDichVu.maDV = '" + tb_timkiem_DichVu.Text + "'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiem_DichVu.DataSource = dtTableName;
            dataGridView_KH_SuDung_DV.DataSource = dtTableName;
            conn.Close();
        }
        private void tb_timkiem_DichVu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comboBox_TimKiem.SelectedItem == "Họ Tên")
                {
                    TimKiem_HoTen();
                    if (dataGridView_timkiem_DichVu.Rows != null && dataGridView_timkiem_DichVu.Rows.Count != 0)
                    {
                        dataGridView_timkiem_DichVu.Enabled = true;
                        dataGridView_KH_SuDung_DV.Enabled = true;
                        btn_XuLyDV_DichVu.Enabled = true;
                    }
                    else
                    {
                        dataGridView_timkiem_DichVu.Enabled = false;
                        dataGridView_KH_SuDung_DV.Enabled = false;
                        btn_XuLyDV_DichVu.Enabled = false;
                    }
                }
                else if (comboBox_TimKiem.SelectedItem == "Số Phòng")
                {
                    TimKiem_SoPhong();
                    if (dataGridView_timkiem_DichVu.Rows != null && dataGridView_timkiem_DichVu.Rows.Count != 0)
                    {
                        dataGridView_timkiem_DichVu.Enabled = true;
                        dataGridView_KH_SuDung_DV.Enabled = true;
                        btn_XuLyDV_DichVu.Enabled = true;
                    }
                    else
                    {
                        dataGridView_timkiem_DichVu.Enabled = false;
                        dataGridView_KH_SuDung_DV.Enabled = false;
                        btn_XuLyDV_DichVu.Enabled = false;
                    }
                }
                else if (comboBox_TimKiem.SelectedItem == "Mã Dịch Vụ")
                {
                    TimKiem_MaDichVu();
                    if (dataGridView_timkiem_DichVu.Rows != null && dataGridView_timkiem_DichVu.Rows.Count != 0)
                    {
                        dataGridView_timkiem_DichVu.Enabled = true;
                        dataGridView_KH_SuDung_DV.Enabled = true;
                        btn_XuLyDV_DichVu.Enabled = true;
                    }
                    else
                    {
                        dataGridView_timkiem_DichVu.Enabled = false;
                        dataGridView_KH_SuDung_DV.Enabled = false;
                        btn_XuLyDV_DichVu.Enabled = false;
                    }
                }
            }
        }
        private void Load_KH_SuDung_DV()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select KhachHangSuDungDichVu.maKH,KhachHangSuDungDichVu.SoPhong,KhachHangSuDungDichVu.maDV,KhachHangSuDungDichVu.SoLuong,convert(varchar(20),KhachHangSuDungDichVu.NgayDangKi,113),KhachHangSuDungDichVu.YeuCau from KhachHangSuDungDichVu", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_KH_SuDung_DV.DataSource = dtTableName;
            conn.Close();
        }
        private void HienLenTextBox_ThongTin_KH_SuDung_DV()
        {
            conn.Open();
            int r = dataGridView_KH_SuDung_DV.CurrentCell.RowIndex;
            SqlDataAdapter daTableName = new SqlDataAdapter("select KhachHang.TenKH from KhachHang inner join KhachHangSuDungDichVu on KhachHang.maKH = KhachHangSuDungDichVu.maKH where KhachHangSuDungDichVu.maKH = '" + dataGridView_KH_SuDung_DV.Rows[r].Cells[0].Value.ToString() +"'",conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            tb_tenKH_DichVu.Text = dtTableName.Rows[0].Field<string>("TenKH");
            tb_sophong_DichVu.Text = dataGridView_KH_SuDung_DV.Rows[r].Cells[1].Value.ToString();
            SqlDataAdapter daTableName1 = new SqlDataAdapter("select DichVu.TenDV from DichVu inner join KhachHangSuDungDichVu on DichVu.maDV = KhachHangSuDungDichVu.maDV where KhachHangSuDungDichVu.maDV = '" + dataGridView_KH_SuDung_DV.Rows[r].Cells[2].Value.ToString() + "'", conn);
            DataTable dtTableName1 = new DataTable();
            daTableName1.Fill(dtTableName1);
            tb_tenDV_DichVu.Text = dtTableName1.Rows[0].Field<string>("TenDV");
            tb_soluong_DichVu.Text = dataGridView_KH_SuDung_DV.Rows[r].Cells[3].Value.ToString();
            dateTimePicker_ngaydangki_DichVu.Value = DateTime.ParseExact(dataGridView_KH_SuDung_DV.Rows[r].Cells[4].Value.ToString(),"dd MMM yyyy HH:mm:ss",null);
            SqlDataAdapter daTableName2 = new SqlDataAdapter("select DichVu.giaDV from DichVu inner join KhachHangSuDungDichVu on DichVu.maDV = KhachHangSuDungDichVu.maDV where KhachHangSuDungDichVu.maDV = '" + dataGridView_KH_SuDung_DV.Rows[r].Cells[2].Value.ToString() + "'", conn);
            DataTable dtTableName2 = new DataTable();
            daTableName2.Fill(dtTableName2);
            decimal GiaDichVu = dtTableName2.Rows[0].Field<decimal>("giaDv");
            decimal SL = decimal.Parse(dataGridView_KH_SuDung_DV.Rows[r].Cells[3].Value.ToString());
            decimal ThanhTien = GiaDichVu * SL * 100000;
            tb_thanhtien_DichVu.Text = ThanhTien.ToString() + "VNĐ";
            conn.Close();
        }

        private void XuLyYeuCauKH()
        {
            try
            {
                conn.Open();
                int r = dataGridView_KH_SuDung_DV.CurrentCell.RowIndex;
                SqlCommand cmd = new SqlCommand("update KhachHangSuDungDichVu set KhachHangSuDungDichVu.YeuCau = N'Đã Xử Lý' where maKH = '" + dataGridView_KH_SuDung_DV.Rows[r].Cells[0].Value.ToString() + "'and SoPhong = '" + dataGridView_KH_SuDung_DV.Rows[r].Cells[1].Value.ToString() + "' and maDV = '" + dataGridView_KH_SuDung_DV.Rows[r].Cells[2].Value.ToString() + "' and YeuCau = N'Chưa Xử Lý'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không thực hiện được!");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        private void ClearData()
        {
            tb_tenKH_DichVu.Text = "";
            tb_sophong_DichVu.Text = "";
            tb_tenDV_DichVu.Text = "";
            tb_soluong_DichVu.Text = "";
            dateTimePicker_ngaydangki_DichVu.Value = DateTime.Now;
            tb_thanhtien_DichVu.Text = "";
        }

        private void dataGridView_KH_SuDung_DV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HienLenTextBox_ThongTin_KH_SuDung_DV();
        }

        private void btn_dangkidichvu_DichVu_Click(object sender, EventArgs e)
        {
            XuLyYeuCauKH();
            Load_KH_SuDung_DV();
        }

        private void btn_lammoi_DichVu_Click(object sender, EventArgs e)
        {
            ClearData();
            Load_KH_SuDung_DV();
            if (dataGridView_KH_SuDung_DV.Rows != null && dataGridView_KH_SuDung_DV.Rows.Count != 0)
            {
                dataGridView_KH_SuDung_DV.Enabled = true;
                btn_XuLyDV_DichVu.Enabled = true;
            }
            else
            {
                dataGridView_KH_SuDung_DV.Enabled = false;
                btn_XuLyDV_DichVu.Enabled = false;
            }
            dataGridView_timkiem_DichVu.DataSource = null;
        }

        private void FormXuLyDichVu_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in groupBox_dangkidichvu_DichVu.Controls)
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
