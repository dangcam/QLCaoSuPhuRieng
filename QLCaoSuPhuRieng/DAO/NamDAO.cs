using QLCaoSuPhuRieng.VO;
using System.Data;
using System.Data.SqlClient;

namespace QLCaoSuPhuRieng.DAO
{
    class NamDAO
    {
        Connection db = null;
        public NamDAO()
        {
            db = new Connection();
        }
        public DataTable DSNam()
        {
            return db.ExcuteQuery("Select  * From NAM",
                CommandType.Text, null);
        }
        public bool ThemNam(ref string err, NamVO n)
        {
            return db.MyExecuteNonQuery("SpThemNam",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@NAM", n.NAM));
        }
        public bool XoaNam(ref string err, NamVO n)
        {
            return db.MyExecuteNonQuery("SpXoaNam",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@NAM", n.NAM));
        }
    }
}
