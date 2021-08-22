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


namespace Quản_Lý_Khách_Sạn
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "" || tb_password.Text == "")
            {
                MessageBox.Show("Xin mời nhập đầy đủ tài khoản và mật khẩu, hãy thử lại");
            }
            else
            
            {
                TaiKhoan taikhoan = new TaiKhoan();
                string[] bpns_username = taikhoan.bpns_username();
                string[] bpns_password = taikhoan.bpns_password();

                string[] bpkd_username = taikhoan.bpkd_username();
                string[] bpkd_password = taikhoan.bpkd_password();


                string[] bpkt_username = taikhoan.bpkt_username();
                string[] bpkt_password = taikhoan.bpkt_password();


                string[] bpdv_username = taikhoan.bpdv_username();
                string[] bpdv_password = taikhoan.bpdv_password();


                string[] bpdt_username = taikhoan.bpdt_username();
                string[] bpdt_password = taikhoan.bpdt_password();

                string[] gd_username = taikhoan.gd_username();
                string[] gd_password = taikhoan.gd_password();

                if (bpns_username.Contains(tb_username.Text) && bpns_password.Contains(tb_password.Text) && Array.IndexOf(bpns_username, tb_username.Text) == Array.IndexOf(bpns_password, tb_password.Text))
                {
                    new FormHomeNhanSu().Show();
                    this.Hide();
                }
                else if (bpkd_username.Contains(tb_username.Text) && bpkd_password.Contains(tb_password.Text) && Array.IndexOf(bpkd_username, tb_username.Text) == Array.IndexOf(bpkd_password, tb_password.Text))
                {
                    new FormHomeKinhDoanh().Show();
                    this.Hide();
                }
                else if (bpkt_username.Contains(tb_username.Text) && bpkt_password.Contains(tb_password.Text) && Array.IndexOf(bpkt_username, tb_username.Text) == Array.IndexOf(bpkt_password, tb_password.Text))
                {
                    new FormHomeKeToan().Show();
                    this.Hide();
                }
                else if (bpdv_username.Contains(tb_username.Text) && bpdv_password.Contains(tb_password.Text) && Array.IndexOf(bpdv_username, tb_username.Text) == Array.IndexOf(bpdv_password, tb_password.Text))
                {
                    new FormHomeDichVu().Show();
                    this.Hide();
                }
                else if (bpdt_username.Contains(tb_username.Text) && bpdt_password.Contains(tb_password.Text) && Array.IndexOf(bpdt_username, tb_username.Text) == Array.IndexOf(bpdt_password, tb_password.Text))
                {
                    new FormHomeDonTiep().Show();
                    this.Hide();
                }
                else if (gd_username.Contains(tb_username.Text) && gd_password.Contains(tb_password.Text) && Array.IndexOf(gd_username, tb_username.Text) == Array.IndexOf(gd_password, tb_password.Text))
                {
                    new FormHomeGiamDoc().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu của bạn đã sai, hãy thử lại");
                }

            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(null, null);
            }
        }

        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(null, null);
            }
        }
    }
}
