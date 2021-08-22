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
    public partial class FormQuanLyPhong : Form
    {
            KetNoiCSDL CSDL = new KetNoiCSDL();
            SqlConnection conn = null;
            public FormQuanLyPhong()
            {
                InitializeComponent();
                LoadData();
            }

        private void FormQuanLyPhong_Load_1(object sender, EventArgs e)
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
                SqlDataAdapter daTableName = new SqlDataAdapter("SELECT * INTO #TempTable FROM Phong ALTER TABLE #TempTable DROP " +
                    "COLUMN maKH,NgayDangKi,NgayDen,NgayDi SELECT * FROM #TempTable DROP TABLE #TempTable", conn);
                DataTable dtTableName = new DataTable();
                daTableName.Fill(dtTableName);
                dataGridView_themphong.DataSource = dtTableName;
                dataGridView_thongtinphong.DataSource = dtTableName;
            }

            private void clearData()
            {
                tb_sophong.Text = "";
                comboBox_loaiphong.Text = "";
                tb_giaphong.Text = "";
            }

            private void btn_themphong_Click(object sender, EventArgs e)
            {
                conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [Phong]([SoPhong],[LoaiPhong],[GiaPhong],[TinhTrang])" + "VALUES(@sophong,@loaiphong,@giaphong,N'Trống')");

                cmd.Parameters.AddWithValue("@sophong", tb_sophong.Text);
                cmd.Parameters.AddWithValue("@loaiphong", comboBox_loaiphong.SelectedItem);
                cmd.Parameters.AddWithValue("@giaphong", tb_giaphong.Text);
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

            private void btn_xoaphong_Click(object sender, EventArgs e)
            {
                conn.Open();
                try
                {
                    int row = dataGridView_thongtinphong.CurrentCell.RowIndex;
                    string strSP = dataGridView_thongtinphong.Rows[row].Cells[0].Value.ToString();
                    SqlCommand cmd = new SqlCommand("Delete from Phong where SoPhong = '" + strSP + "'");
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

            private void btn_suaphong_Click(object sender, EventArgs e)
            {
                System.IFormatProvider cultureUS = new System.Globalization.CultureInfo("en-US");
                int r = dataGridView_thongtinphong.CurrentCell.RowIndex;
                tb_sophong.Text = dataGridView_thongtinphong.Rows[r].Cells[0].Value.ToString();
                comboBox_loaiphong.Text = dataGridView_thongtinphong.Rows[r].Cells[1].Value.ToString();
                tb_giaphong.Text = Decimal.Parse(dataGridView_thongtinphong.Rows[r].Cells[2].Value.ToString(), System.Globalization.NumberStyles.Number).ToString();
            }

            private void btn_luuphong_Click(object sender, EventArgs e)
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Phong SET [SoPhong] = @sophong,[LoaiPhong] = @loaiphong,[GiaPhong] = @giaphong where [SoPhong] = @sophong");
                    cmd.Parameters.AddWithValue("@sophong", tb_sophong.Text);
                    cmd.Parameters.AddWithValue("@loaiphong", comboBox_loaiphong.SelectedItem.ToString());
                    decimal giaphong = Decimal.Parse(tb_giaphong.Text, System.Globalization.NumberStyles.Number);
                    cmd.Parameters.AddWithValue("@giaphong", giaphong);
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
            public void TimKiemPhongTheoTenVaMa()
            {
                conn = CSDL.Connect();
                SqlDataAdapter daTableName = new SqlDataAdapter("select SoPhong,LoaiPhong,GiaPhong,TinhTrang FROM Phong where SoPhong like '%" + tb_timkiemphong.Text + "%' or LoaiPhong like N'%" + tb_timkiemphong.Text + "%'", conn);
                DataTable dtTableName = new DataTable();
                daTableName.Fill(dtTableName);
                dataGridView_thongtinphong.DataSource = dtTableName;
            }
             public void TimKiemPhongTheoBP()
            {
                conn = CSDL.Connect();
                SqlDataAdapter daTableName = new SqlDataAdapter("select SoPhong,LoaiPhong,GiaPhong,TinhTrang FROM Phong where LoaiPhong = N'" + comboBox_timkiemphong.SelectedItem.ToString() + "' ", conn);
                DataTable dtTableName = new DataTable();
                daTableName.Fill(dtTableName);
                dataGridView_thongtinphong.DataSource = dtTableName;
            }

            private void btn_lammoi_Click(object sender, EventArgs e)
            {
                LoadData();
                tb_timkiemphong.Text = "";
            }

            private void comboBox_timkiemphong_SelectedIndexChanged(object sender, EventArgs e)
            {
                TimKiemPhongTheoBP();
                tb_timkiemphong.Text = "";

        }

        private void tb_timkiemphong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemPhongTheoTenVaMa();
                comboBox_timkiemphong.Text = "";
                if (dataGridView_thongtinphong.Rows != null && dataGridView_thongtinphong.Rows.Count != 0)
                {
                    dataGridView_thongtinphong.Enabled = true;
                    dataGridView_themphong.Enabled = true;
                    btn_xoaphong.Enabled = true;
                }
                else
                {
                    dataGridView_thongtinphong.Enabled = false;
                    dataGridView_themphong.Enabled = false;
                    btn_xoaphong.Enabled = false;
                }
            }

        }

        
    }
    }
