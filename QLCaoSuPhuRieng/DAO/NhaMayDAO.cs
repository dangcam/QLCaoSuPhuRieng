using QLCaoSuPhuRieng.VO;
using System.Data;
using System.Data.SqlClient;

namespace QLCaoSuPhuRieng.DAO
{
    class NhaMayDAO
    {
        Connection db = null;
        public NhaMayDAO()
        {
            db = new Connection();
        }
        public DataTable DSNhaMay()
        {
            return db.ExcuteQuery("Select  * From NHAMAY",
                CommandType.Text, null);
        }
        public bool ThemNhaMay(ref string err, NhaMayVO nm)
        {
            return db.MyExecuteNonQuery("SpThemNhaMay",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@NHAMAY", nm.NHAMAY));
        }
        public bool XoaNhaMay(ref string err, NhaMayVO nm)
        {
            return db.MyExecuteNonQuery("SpXoaNhaMay",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@NHAMAY", nm.NHAMAY));
        }
    }
}
