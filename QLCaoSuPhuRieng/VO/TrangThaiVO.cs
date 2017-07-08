using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCaoSuPhuRieng.VO
{
    class TrangThaiVO
    {
        private string _trangThai;
        public TrangThaiVO()
        {

        }
        public string TRANGTHAI
        {
            get
            {
                return _trangThai;
            }
            set
            {
                _trangThai = value;
            }
        }
    }
}
