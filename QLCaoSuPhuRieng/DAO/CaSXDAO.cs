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
    class CaSXDAO
    {
        Connection db = null;
        public CaSXDAO()
        {
            db = new Connection();
        }
        public DataTable DSCaSX()
        {
            return db.ExcuteQuery("Select  * From CASX",
                CommandType.Text, null);
        }
        public bool ThemCaSX(ref string err, CaSXVO ca)
        {
            return db.MyExecuteNonQuery("SpThemCaSX",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@CASX", ca.CASX));
        }
        public bool XoaCaSX(ref string err, CaSXVO ca)
        {
            return db.MyExecuteNonQuery("SpXoaCaSX",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@CASX", ca.CASX));
        }
    }
}
