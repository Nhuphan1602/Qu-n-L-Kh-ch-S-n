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
using Microsoft.Reporting.WinForms;

namespace Quản_Lý_Khách_Sạn.Report
{
    public partial class FormInHoaDon : Form
    {
        KetNoiCSDL CSDL = new KetNoiCSDL();
        SqlConnection conn = null;
        public FormInHoaDon()
        {
            InitializeComponent();
        }



        private void FormInHoaDon_Load(object sender, EventArgs e)
        {
            LoadTheme();
            this.reportViewer1.RefreshReport();
            dateTimePicker_NgayTT.Value = DateTime.Now;
        }
        private void LoadTheme()
        {
            foreach (Control btns in Controls)
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

        private void btn_inhd_Click(object sender, EventArgs e)
        {
            conn = CSDL.Connect();
            SqlDataAdapter daTableName = new SqlDataAdapter("select k.maKH,k.TenKH,ChiTietHoaDon,SoPhong,maDV,CONVERT(date,NgayTT,103) as NgayTT,ThanhTien,maNV,PhuongThucThanhToan  from HoaDon inner join KhachHang k on k.maKH = HoaDon.maKH where HoaDon.NgayTT is not null and HoaDon.maKH = '" + tb_makh.Text + "' and CONVERT(date,NgayTT,103) = '" + dateTimePicker_NgayTT.Value + "' ", conn);
            DataSet1 ds = new DataSet1();
            daTableName.Fill(ds,"DataTable_HoaDon");
            ReportDataSource datasource = new ReportDataSource("DataSet_Report", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
            dateTimePicker_NgayTT.Value = DateTime.Now;
            tb_makh.Text = "";
        }

        private void tb_makh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_inhd_Click(null, null);
            }
        }
    }
}
