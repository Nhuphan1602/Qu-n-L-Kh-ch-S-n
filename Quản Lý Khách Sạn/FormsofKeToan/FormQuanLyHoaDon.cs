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

namespace Quản_Lý_Khách_Sạn.FormsofKeToan
{
    public partial class FormQuanLyHoaDon : Form
    {
        KetNoiCSDL CSDL = new KetNoiCSDL();
        SqlConnection conn = null;
        public FormQuanLyHoaDon()
        {
            InitializeComponent();
            LoadData_HoaDon();
            LoadData_LuongNhanVien();
        }
        private void LoadData_HoaDon()
        {
            conn = CSDL.Connect();
            SqlDataAdapter daTableName = new SqlDataAdapter("select maKH,CONVERT(date,NgayTT,103) as NgayTT,Sum(ThanhTien) As TongSoTien From HoaDon where NgayTT is not null GROUP BY maKH,CONVERT(date,NgayTT,103) ORDER BY maKH ASC", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_tonghophd.DataSource = dtTableName;
        }

        private void LoadData_LuongNhanVien()
        {
            conn = CSDL.Connect();
            SqlDataAdapter daTableName = new SqlDataAdapter("select maNV,TenNV,maBP,NgaySinh,ChucVu,Luong As LuongCoBan,GioLamViec,Luong * GioLamViec As LuongThang From NhanVien", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_luongnv.DataSource = dtTableName;
        }

        public void TimKiemHDTheoMa()
        {
            conn = CSDL.Connect();
            SqlDataAdapter daTableName = new SqlDataAdapter("select maKH,NgayTT,Sum(ThanhTien) As TongSoTien From HoaDon  GROUP BY maKH,NgayTT having maKH like '%" + tb_timhdtheotenvama.Text + "%' ORDER BY maKH ASC ", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_tonghophd.DataSource = dtTableName;
        }

        public void TimKiemNVTheoTenVaMa()
        {
            conn = CSDL.Connect();
            SqlDataAdapter daTableName = new SqlDataAdapter("select * FROM nhanvien where maNV like '%" + tb_timkiemnvtheoten.Text + "%' or TenNV like N'%" + tb_timkiemnvtheoten.Text + "%'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_luongnv.DataSource = dtTableName;
        }
        public void TimKiemNVTheoBP()
        {
            conn = CSDL.Connect();
            SqlDataAdapter daTableName = new SqlDataAdapter("select * FROM nhanvien where maBP = '" + comboBox_maBP_KeToan_timkiemthongtinnhanvien.SelectedItem.ToString() + "' ", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView_luongnv.DataSource = dtTableName;
        }

        private void comboBox_maBP_KeToan_timkiemthongtinnhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiemNVTheoBP();
            tb_timkiemnvtheoten.Text = "";
        }

        private void btn_lammoinv_Click(object sender, EventArgs e)
        {
            LoadData_LuongNhanVien();
        }

        private void btn_lammoi_hd_Click(object sender, EventArgs e)
        {
            LoadData_HoaDon();
        }

        private void tb_timkiemnvtheoten_KeyDown(object sender, KeyEventArgs e)
        {
            TimKiemNVTheoTenVaMa();
            comboBox_maBP_KeToan_timkiemthongtinnhanvien.Text = "";
        }

        private void tb_timhdtheotenvama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemHDTheoMa();
            }
        }

        private void tb_timkiemnvtheotenvama_Load(object sender, EventArgs e)
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
    }
}
