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
    class NguyenLieuDAO
    {
        Connection db = null;
        public NguyenLieuDAO()
        {
            db = new Connection();
        }
        public DataTable DSNguyenLieu()
        {
            return db.ExcuteQuery("Select  * From NGUYENLIEU",
                CommandType.Text, null);
        }
        public bool ThemNguyenLieu(ref string err, NguyenLieuVO nl)
        {
            return db.MyExecuteNonQuery("SpThemNguyenLieu",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@NGUYENLIEU", nl.NGUYENLIEU),
                new SqlParameter("@TENNGUYENLIEU",nl.TENNGUYENLIEU));
        }
        public bool SuaNguyenLieu(ref string err, NguyenLieuVO nl)
        {
            return db.MyExecuteNonQuery("SpSuaNguyenLieu",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@NGUYENLIEU", nl.NGUYENLIEU),
                new SqlParameter("@TENNGUYENLIEU", nl.TENNGUYENLIEU));
        }
        public bool XoaNguyenLieu(ref string err, NguyenLieuVO nl)
        {
            return db.MyExecuteNonQuery("SpXoaNguyenLieu",
                CommandType.StoredProcedure, ref err,
                   new SqlParameter("@NGUYENLIEU", nl.NGUYENLIEU));
        }
    }
}
