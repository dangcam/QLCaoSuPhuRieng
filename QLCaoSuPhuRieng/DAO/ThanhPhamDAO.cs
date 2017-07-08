using QLCaoSuPhuRieng.VO;
using System.Data;
using System.Data.SqlClient;

namespace QLCaoSuPhuRieng.DAO
{
    class ThanhPhamDAO
    {
        Connection db = null;
        public ThanhPhamDAO()
        {
            db = new Connection();
        }
        public DataTable DSThanhPham()
        {
            return db.ExcuteQuery("Select  * From THANHPHAM",
                CommandType.Text, null);
        }
        public bool ThemThanhPham(ref string err, ThanhPhamVO tp)
        {
            return db.MyExecuteNonQuery("SpThemThanhPham",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@LOAIMU", tp.LOAIMU),
                new SqlParameter("@GHICHU",tp.GHICHU));
        }
        public bool SuaThanhPham(ref string err, ThanhPhamVO tp)
        {
            return db.MyExecuteNonQuery("SpSuaThanhPham",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@LOAIMU", tp.LOAIMU),
                new SqlParameter("@GHICHU", tp.GHICHU));
        }
        public bool XoaThanhPham(ref string err, ThanhPhamVO tp)
        {
            return db.MyExecuteNonQuery("SpXoaThanhPham",
                CommandType.StoredProcedure, ref err,
                   new SqlParameter("@LOAIMU", tp.LOAIMU));
        }
    }
}
