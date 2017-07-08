using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCaoSuPhuRieng
{
    class ConnectionDB
    {
        public static SqlConnection getNetwork()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=" + AppConfig.ServerName + ";Network Library=DBMSSOCN;"
             + "Initial Catalog=" + AppConfig.Database + ";User ID="+AppConfig.Username+";Password="+AppConfig.Password+";";
            return conn;
        }
    }
}
