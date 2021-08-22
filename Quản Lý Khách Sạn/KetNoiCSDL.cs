using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Quản_Lý_Khách_Sạn
{
    class KetNoiCSDL
    {
        public SqlConnection Connect()
        {
            string strConnectionString = @"Data Source=MSI\TAMNHU;Initial Catalog=qlks;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConnectionString);
            return conn;
        }
    }
}
