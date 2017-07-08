using QLCaoSuPhuRieng.VO;
using System.Data;
using System.Data.SqlClient;

namespace QLCaoSuPhuRieng.DAO
{
    class CaTruongDAO
    {
        Connection db = null;
        public CaTruongDAO()
        {
            db = new Connection();
        }
        public DataTable DSCaTruong()
        {
            return db.ExcuteQuery("Select  * From CATRUONG",
                CommandType.Text, null);
        }
        public bool ThemCaTruong(ref string err, CaTruongVO ct)
        {
            return db.MyExecuteNonQuery("SpThemCaTruong",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@CATRUONG", ct.CATRUONG));
        }
        public bool XoaCaTruong(ref string err, CaTruongVO ct)
        {
            return db.MyExecuteNonQuery("SpXoaCaTruong",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@CATRUONG", ct.CATRUONG));
        }
    }
}
