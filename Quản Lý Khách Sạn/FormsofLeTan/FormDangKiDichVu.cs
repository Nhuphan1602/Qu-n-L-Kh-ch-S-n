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
    public partial class FormDangKiDichVu : Form
    {
        //
        //
        //
        private void FormDichvu_Load(object sender, EventArgs e)
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
        //
        //
        //

        KetNoiCSDL CSDL = new KetNoiCSDL();
        SqlConnection conn = null;
        string maDV = null;

        public FormDangKiDichVu()
        {
            InitializeComponent();
            dateTimePicker_ngaydangki_DichVu.Value = DateTime.Now;
            timer1.Start();
            conn = CSDL.Connect();
            combobox_DichVu();
            Hien_GiaDV();
            CungCap_MaDV();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker_ngaydangki_DichVu.Value = DateTime.Now;
        }

        //
        //
        //
        // Chức năng tìm kiếm
        //
        //
        private void TimKiemKh_SoPhong()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select KhachHang.maKH,KhachHang.TenKH, Phong.SoPhong, Convert(varchar(20), KhachHang.NgaySinh, 113) as NgaySinh, KhachHang.GioiTinh, KhachHang.Sdt from KhachHang inner join Phong on KhachHang.maKH = Phong.maKH where SoPhong = '" + tb_timkiemKH_DichVu.Text + "'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiemkhachhang_DichVu.DataSource = dtTableName;
            conn.Close();
        }

        private void TimKiemKh_HoTen()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select KhachHang.maKH,KhachHang.TenKH, Phong.SoPhong, Convert(varchar(20), KhachHang.NgaySinh, 113) as NgaySinh, KhachHang.GioiTinh, KhachHang.Sdt from KhachHang inner join Phong on KhachHang.maKH = Phong.maKH where KhachHang.TenKH = N'" + tb_timkiemKH_DichVu.Text + "'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_timkiemkhachhang_DichVu.DataSource = dtTableName;
            conn.Close();
        }

        private void LoadData_KHDV_SoPhong()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select KhachHang.TenKH,KhachHangSuDungDichVu.SoPhong,DichVu.TenDV,KhachHangSuDungDichVu.SoLuong,Convert(varchar(20), KhachHangSuDungDichVu.NgayDangKi, 113) as NgayDangKi  from KhachHangSuDungDichVu  inner join KhachHang on KhachHang.maKH = KhachHangSuDungDichVu.maKH inner join DichVu on DichVu.maDV = KhachHangSuDungDichVu.maDV where KhachHangSuDungDichVu.SoPhong = '" + tb_timkiemKH_DichVu.Text + "'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_dangkidichvu_DichVu.DataSource = dtTableName;
            conn.Close();
        }

        private void LoadData_KHDV_HoTen()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select KhachHang.TenKH,KhachHangSuDungDichVu.SoPhong,DichVu.TenDV,KhachHangSuDungDichVu.SoLuong,Convert(varchar(20), KhachHangSuDungDichVu.NgayDangKi, 113) as NgayDangKi  from KhachHangSuDungDichVu  inner join KhachHang on KhachHang.maKH = KhachHangSuDungDichVu.maKH inner join DichVu on DichVu.maDV = KhachHangSuDungDichVu.maDV where  KhachHang.TenKH = N'" + tb_timkiemKH_DichVu.Text + "' order by KhachHangSuDungDichVu.SoPhong desc", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_dangkidichvu_DichVu.DataSource = dtTableName;
            conn.Close();
        }
        private void tb_timkiemKH_DichVu_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (comboBox_sophong_hoten.SelectedItem == "Họ Tên")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TimKiemKh_HoTen();
                    LoadData_KHDV_HoTen();
                    if (dataGridView_timkiemkhachhang_DichVu.Rows != null && dataGridView_timkiemkhachhang_DichVu.Rows.Count != 0)
                    {
                        dataGridView_timkiemkhachhang_DichVu.Enabled = true;
                    }
                    else
                    {
                        dataGridView_timkiemkhachhang_DichVu.Enabled = false;
                    }
                }
            }
            else if (comboBox_sophong_hoten.SelectedItem == "Số Phòng")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TimKiemKh_SoPhong();
                    LoadData_KHDV_SoPhong();
                    if (dataGridView_timkiemkhachhang_DichVu.Rows != null && dataGridView_timkiemkhachhang_DichVu.Rows.Count != 0)
                    {
                        dataGridView_timkiemkhachhang_DichVu.Enabled = true;
                    }
                    else
                    {
                        dataGridView_timkiemkhachhang_DichVu.Enabled = false;
                    }
                }
            }
        }

      

        //
        //
        // Chức năng nhập
        //
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
            comboBox_tendichvu_DichVu.DataSource = cbb_dichvu;
            conn.Close();
        }
        private void CungCap_MaDV()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select distinct maDV from DichVu where TenDv = N'" + comboBox_tendichvu_DichVu.SelectedValue + "'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            maDV = dtTableName.Rows[0].Field<string>("maDV");
            conn.Close();
        }
        private void Hien_GiaDV()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select distinct GiaDV from DichVu where TenDv = N'" + comboBox_tendichvu_DichVu.SelectedValue + "'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            decimal gia_dichvu = dtTableName.Rows[0].Field<decimal>("GiaDV");
            tb_giadichvu_DichVu.Text = Convert.ToInt32(gia_dichvu * 100000).ToString() + "VNĐ";
            conn.Close();
        }

    
        private void comboBox_tendichvu_DichVu_DropDownClosed_1(object sender, EventArgs e)
        {
            Hien_GiaDV();
            CungCap_MaDV();
        }
        private void dataGridView_timkiemkhachhang_DichVu_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void dataGridView_timkiemkhachhang_DichVu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                int r = dataGridView_timkiemkhachhang_DichVu.CurrentCell.RowIndex;
                tb_tenKH_DichVu.Text = dataGridView_timkiemkhachhang_DichVu.Rows[r].Cells[1].Value.ToString();
                tb_sophong_DichVu.Text = dataGridView_timkiemkhachhang_DichVu.Rows[r].Cells[2].Value.ToString();
                dataGridView_timkiemkhachhang_DichVu.Enabled = true;
        }

        private void DangKi_DichVu()
        {
            try
            {
                if (dataGridView_timkiemkhachhang_DichVu.Rows != null && dataGridView_timkiemkhachhang_DichVu.Rows.Count != 0)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into KhachHangSuDungDichVu (maKH,SoPhong,maDV,SoLuong,NgayDangKi) values (@makh,@sophong,@madv,@soluong,@ngaydangki)", conn);
                    cmd.Parameters.AddWithValue("@makh", dataGridView_timkiemkhachhang_DichVu.Rows[dataGridView_timkiemkhachhang_DichVu.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@sophong", tb_sophong_DichVu.Text);
                    cmd.Parameters.AddWithValue("@madv", maDV);
                    cmd.Parameters.AddWithValue("@soluong", tb_soluong_DichVu.Text);
                    cmd.Parameters.AddWithValue("@ngaydangki", dateTimePicker_ngaydangki_DichVu.Value);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin khách hàng!");
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xử lý đăng kí dịch vụ!");
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
            tb_timkiemKH_DichVu.Text = "";
            tb_tenKH_DichVu.Text = "";
            tb_sophong_DichVu.Text = "";
        }     
        private void btn_dangkidichvu_DichVu_Click_1(object sender, EventArgs e)
        {
            DangKi_DichVu();
            if (comboBox_sophong_hoten.SelectedItem == "Họ Tên")
            {
                LoadData_KHDV_HoTen();
            }
            else if (comboBox_sophong_hoten.SelectedItem == "Số Phòng")
            {
                LoadData_KHDV_SoPhong();
            }
        }

        private void btn_lammoi_DichVu_Click_1(object sender, EventArgs e)
        {
            ClearData();
            if (comboBox_sophong_hoten.SelectedItem == "Họ Tên")
            {
                TimKiemKh_HoTen();
            }
            else if (comboBox_sophong_hoten.SelectedItem == "Số Phòng")
            {
                TimKiemKh_SoPhong();
            }   
        }

        
        //
        //
        //
        //
        //
    }
}
