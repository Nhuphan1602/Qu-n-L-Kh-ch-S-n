using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Quản_Lý_Khách_Sạn
{
    class TaiKhoan
    {
        KetNoiCSDL CSDL = new KetNoiCSDL();
        SqlConnection conn = null;
        
        private void ThietLapKetNoi()
        {
            conn = CSDL.Connect();
        }
        //
        //Bộ Phận Nhân Sự
        //
        public string[] bpns_username()
        {
            ThietLapKetNoi();
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select username from NhanVien where maBP = 'NS'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            string[] username = dtTableName.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            for (int i = 0; i < username.Length; i++)
            {
                username[i] = username[i].Trim();

            }
            return username;
            conn.Close();
        }

        public string[] bpns_password()
        {
            ThietLapKetNoi();
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select password from NhanVien where maBP = 'NS'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            string[] password = dtTableName.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            for (int i = 0; i < password.Length; i++)
            {
                password[i] = password[i].Trim();

            }
            return password;
            conn.Close();
        }
        //
        //Bộ Phận Dịch Vụ
        //
        public string[] bpdv_username()
        {
            ThietLapKetNoi();
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select username from NhanVien where maBP = 'DV'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            string[] username = dtTableName.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            for (int i = 0; i < username.Length; i++)
            {
                username[i] = username[i].Trim();

            }
            return username;
            conn.Close();
        }

        public string[] bpdv_password()
        {
            ThietLapKetNoi();
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select password from NhanVien where maBP = 'DV'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            string[] password = dtTableName.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            for (int i = 0; i < password.Length; i++)
            {
                password[i] = password[i].Trim();

            }
            return password;
            conn.Close();
        }
        //
        //Bộ Phận Kinh Doanh
        //
        public string[] bpkd_username()
        {
            ThietLapKetNoi();
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select username from NhanVien where maBP = 'KD'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            string[] username = dtTableName.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            for (int i = 0; i < username.Length; i++)
            {
                username[i] = username[i].Trim();

            }
            return username;
            conn.Close();
        }

        public string[] bpkd_password()
        {
            ThietLapKetNoi();
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select password from NhanVien where maBP = 'KD'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            string[] password = dtTableName.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            for (int i = 0; i < password.Length; i++)
            {
                password[i] = password[i].Trim();

            }
            return password;
            conn.Close();
        }
        //
        //Bộ Phận Kế Toán
        //
        public string[] bpkt_username()
        {
            ThietLapKetNoi();
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select username from NhanVien where maBP = 'KT'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            string[] username = dtTableName.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            for (int i = 0; i < username.Length; i++)
            {
                username[i] = username[i].Trim();

            }
            return username;
            conn.Close();
        }

        public string[] bpkt_password()
        {
            ThietLapKetNoi();
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select password from NhanVien where maBP = 'KT'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            string[] password = dtTableName.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            for (int i = 0; i < password.Length; i++)
            {
                password[i] = password[i].Trim();

            }
            return password;
            conn.Close();
        }
        //
        //Bộ Phận Đón Tiếp
        //
        public string[] bpdt_username()
        {
            ThietLapKetNoi();
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select username from NhanVien where maBP = 'DT'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            string[] username = dtTableName.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            for (int i = 0; i < username.Length; i++)
            {
                username[i] = username[i].Trim();

            }
            return username;
            conn.Close();
        }
       
        public string[] bpdt_password()
        {
            ThietLapKetNoi();
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select password from NhanVien where maBP = 'DT'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            string[] password = dtTableName.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            for (int i = 0; i < password.Length; i++)
            {
                password[i] = password[i].Trim();

            }
            return password;
            conn.Close();
        }
        //
        //Giám Đốc
        //
        public string[] gd_username()
        {
            ThietLapKetNoi();
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select username from NhanVien where maBP = 'GD'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            string[] username = dtTableName.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            for (int i = 0; i < username.Length; i++)
            {
                username[i] = username[i].Trim();

            }
            return username;
            conn.Close();
        }

        public string[] gd_password()
        {
            ThietLapKetNoi();
            conn.Open();
            SqlDataAdapter daTableName = new SqlDataAdapter("select password from NhanVien where maBP = 'GD'", conn);
            DataTable dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            string[] password = dtTableName.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            for (int i = 0; i < password.Length; i++)
            {
                password[i] = password[i].Trim();

            }
            return password;
            conn.Close();
        }

    }
}
