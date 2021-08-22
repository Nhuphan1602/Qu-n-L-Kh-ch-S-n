using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quản_Lý_Khách_Sạn
{
    public partial class FormHomeGiamDoc : Form
    {
        //Fields
        KetNoiCSDL CSDL = new KetNoiCSDL();
        SqlConnection conn = null;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructor
        public FormHomeGiamDoc()
        {
            InitializeComponent();
            conn = CSDL.Connect();
            LoadData();
            if (dataGridView1.Rows != null && dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Enabled = true;
            }
            else
            {
                dataGridView1.Enabled = false;
            }
            Hien();
            random = new Random();
            btn_CloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods
        private Color SelectThemecolorHome()
        {
            int index = random.Next(ThemecolorHome.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemecolorHome.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemecolorHome.ColorList[index];

            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemecolorHome();
                    ThemecolorHome.PrimaryColor = ThemecolorHome.ChangeColorBrightness(color, 0);
                    panel_titlebar.BackColor = color;   
                    
                    btn_CloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
        }

        private void OpenChildForm(Form childForm,object btnSender)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_home.Text = childForm.Text;
        }
        
        private void Hien()
        {
            conn.Open();
            string sluser = "SELECT COUNT(username) FROM NhanVien";
            SqlCommand cmd = new SqlCommand(sluser, conn);
            String count1 = Convert.ToString(cmd.ExecuteScalar());
            btn_sluser.Text = btn_sluser.Text + count1;
            //
            string slnv = "SELECT COUNT(MaNV) FROM NhanVien";
            cmd = new SqlCommand(slnv, conn);
            String count2 = Convert.ToString(cmd.ExecuteScalar());
            btn_slnv.Text = btn_slnv.Text + count2;
            //
            string sldv = "SELECT COUNT(maDV) FROM DichVu";
            cmd = new SqlCommand(sldv, conn);
            String count3 = Convert.ToString(cmd.ExecuteScalar());
            btn_sldv.Text = btn_sldv.Text + count3;

            string slkh = "select distinct COUNT(maKH) FROM KhachHang";
            cmd = new SqlCommand(slkh, conn);
            String count4 = Convert.ToString(cmd.ExecuteScalar());
            btn_slkh.Text = btn_slkh.Text + count4;

            conn.Close();
        }
        private void btn_sluser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsofGiamDoc.FormQuanLyUser(), sender);
        }
        private void btn_slnv_Click(object sender, EventArgs e)
        {
            new FormsofGiamDoc.FormNhanSu().Show();
        }

        private void btn_sldv_Click(object sender, EventArgs e)
        {
            new FormsofGiamDoc.FormDichVu().Show();
        }

        private void btn_slkh_Click(object sender, EventArgs e)
        {
            new FormsofGiamDoc.FormDonTiep().Show();
        }

        private void btn_doanhthu_Click(object sender, EventArgs e)
        {
            new FormsofGiamDoc.FormKeToan().Show();
        }

        private void btn_bddoanhthu_Click(object sender, EventArgs e)
        {
            new FormsofGiamDoc.FormKinhDoanh().Show();
        }
        private void btn_giamdoc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Reset();
        }
        private void btn_qluser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsofGiamDoc.FormQuanLyUser(), sender);
        }

        private void btn_CloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lbl_home.Text = "HOME";
            panel_titlebar.BackColor = Color.FromArgb(51, 51, 76);
            currentButton = null;
            btn_CloseChildForm.Visible = false;
        }

        private void panel_titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
   
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormHomeGiamDoc_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadData()
        {
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select STT,NoiDung, convert(varchar(20), ThoiGianHop, 113) as ThoiGianHop from LichHop", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
            conn.Close();
        }
        private void TimKiemCuocHop()
        {
            try
            {
                conn.Open();
                SqlDataAdapter daTableName = new SqlDataAdapter("SELECT * FROM LichHop WHERE STT = '" + tb_timkiem.Text + "'", conn);
                DataTable dtTableName = new DataTable();
                daTableName.Fill(dtTableName);
                dataGridView1.DataSource = dtTableName;
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm kiếm được lỗi rồi!");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        private void clearData()
        {
            tb_stt.Text = "";
            tb_noidung.Text = "";
            dateTimePicker_lichhop.Value = DateTime.Now;
            tb_timkiem.Text = "";
        }
        
        private void Hien_ThongTinCuocHop()
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            tb_stt.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            tb_noidung.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            dateTimePicker_lichhop.Value = DateTime.ParseExact(dataGridView1.Rows[r].Cells[2].Value.ToString(), "dd MMM yyyy HH:mm:ss", null);
        }

        private void btn_sửa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE LichHop SET  NoiDung = @NoiDung, ThoiGianHop = @ThoiGianHop WHERE STT = @STT", conn);
                cmd.Parameters.AddWithValue("@STT", tb_stt.Text);
                cmd.Parameters.AddWithValue("@NoiDung", tb_noidung.Text);
                cmd.Parameters.AddWithValue("@ThoiGianHop", dateTimePicker_lichhop.Value);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Không sửa được, Lỗi rồi !");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            LoadData();
            clearData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM LichHop WHERE STT = @STT", conn);
                cmd.Parameters.AddWithValue("@STT", tb_stt.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Không xóa được, Lỗi rồi !");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            LoadData();
            clearData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO LichHop ([STT],[NoiDung],[ThoiGianHop]) VALUES (@STT, @NoiDung, @ThoiGianHop)", conn);
                cmd.Parameters.AddWithValue("@STT", tb_stt.Text);
                cmd.Parameters.AddWithValue("@NoiDung", tb_noidung.Text);
                cmd.Parameters.AddWithValue("@ThoiGianHop", dateTimePicker_lichhop.Value);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được, Lỗi rồi !");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            LoadData();
            clearData();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (tb_timkiem.Text != "")
            {
                TimKiemCuocHop();
                if (dataGridView1.Rows != null && dataGridView1.Rows.Count != 0)
                {
                    dataGridView1.Enabled = true;
                }
                else
                {
                    dataGridView1.Enabled = false;
                }
            }
            else if (tb_timkiem.Text == "")
            {
                LoadData();
                if (dataGridView1.Rows != null && dataGridView1.Rows.Count != 0)
                {
                    dataGridView1.Enabled = true;
                }
                else
                {
                    dataGridView1.Enabled = false;
                }
            }
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Hien_ThongTinCuocHop();
        }

        private void pn_dangxuat_Click(object sender, EventArgs e)
        {
            new Formmsg().Show();
        }
    }
}
