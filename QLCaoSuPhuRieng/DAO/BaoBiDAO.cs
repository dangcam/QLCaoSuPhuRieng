using QLCaoSuPhuRieng.VO;
using System.Data;
using System.Data.SqlClient;

namespace QLCaoSuPhuRieng.DAO
{
    class BaoBiDAO
    {
        Connection db = null;
        public BaoBiDAO()
        {
            db = new Connection();
        }
        public DataTable DSBaoBi()
        {
            return db.ExcuteQuery("Select  * From BAOBI",
                CommandType.Text, null);
        }
        public bool ThemBaoBi(ref string err, BaoBiVO bi)
        {
            return db.MyExecuteNonQuery("SpThemBaoBi",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@BAOBI", bi.BAOBI));
        }
        public bool XoaBaoBi(ref string err, BaoBiVO bi)
        {
            return db.MyExecuteNonQuery("SpXoaBaoBi",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@BAOBI", bi.BAOBI));
        }
    }
}
