using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
//using System.Data.SqlClient;

namespace Penjualan_App.MyClass
{
    public class Koneksi
    {
        public MySqlConnection GetKoneksi()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "SERVER=localhost; UID=root; PWd= ; DATABASE=db_penjualan;";
            return conn;
        }

    }

}
