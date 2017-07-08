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
    class TrangThaiDAO
    {
        Connection db = null;
        public TrangThaiDAO()
        {
            db = new Connection();
        }
        public DataTable DSTrangThai()
        {
            return db.ExcuteQuery("Select  * From TRANGTHAI",
                CommandType.Text, null);
        }
        public bool ThemTrangThai(ref string err, TrangThaiVO tt)
        {
            return db.MyExecuteNonQuery("SpThemTrangThai",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@TRANGTHAI", tt.TRANGTHAI));
        }
        public bool XoaTrangThai(ref string err, TrangThaiVO tt)
        {
            return db.MyExecuteNonQuery("SpXoaTrangThai",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@TRANGTHAI", tt.TRANGTHAI));
        }
    }
}
