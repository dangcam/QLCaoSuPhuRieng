using QLCaoSuPhuRieng.VO;
using System.Data;
using System.Data.SqlClient;

namespace QLCaoSuPhuRieng.DAO
{
    class BaoPEDAO
    {
        Connection db = null;
        public BaoPEDAO()
        {
            db = new Connection();
        }
        public DataTable DSBaoPE()
        {
            return db.ExcuteQuery("Select  * From BAOPE",
                CommandType.Text, null);
        }
        public bool ThemBaoPE(ref string err, BaoPEVO pe)
        {
            return db.MyExecuteNonQuery("SpThemBaoPE",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@BAOPE", pe.BAOPE));
        }
        public bool XoaBaoPE(ref string err, BaoPEVO pe)
        {
            return db.MyExecuteNonQuery("SpXoaBaoPE",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@BAOPE",pe.BAOPE));
        }
    }
}
