using QLCaoSuPhuRieng.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCaoSuPhuRieng.DAO
{
    class BanhDAO
    {
        Connection db = null;
        public BanhDAO()
        {
            db = new Connection();
        }
        public DataTable DSBanh()
        {
            return db.ExcuteQuery("Select  * From BANH",
                CommandType.Text, null);
        }
        public bool ThemBanh(ref string err, BanhVO ba)
        {
            return db.MyExecuteNonQuery("SpThemBanh",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Banh", ba.BANH));
        }
        public bool XoaBanh(ref string err, BanhVO ba)
        {
            return db.MyExecuteNonQuery("SpXoaBanh",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Banh", ba.BANH));
        }
    }
}
