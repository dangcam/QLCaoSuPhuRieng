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
    class NguonNhapDAO
    {
        Connection db = null;
        public NguonNhapDAO()
        {
            db = new Connection();
        }
        public DataTable DSNguon()
        {
            return db.ExcuteQuery("Select  * From NGUON",
                CommandType.Text, null);
        }
        public bool ThemNguon(ref string err, NguonNhapVO nn)
        {
            return db.MyExecuteNonQuery("SpThemNguon",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@NGUON", nn.NGUON));
        }
        public bool XoaNguon(ref string err, NguonNhapVO nn)
        {
            return db.MyExecuteNonQuery("SpXoaNguon",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@NGUON", nn.NGUON));
        }
    }
}
