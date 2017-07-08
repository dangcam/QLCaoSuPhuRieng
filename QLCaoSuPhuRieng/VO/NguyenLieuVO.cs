using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCaoSuPhuRieng.VO
{
    class NguyenLieuVO
    {
        private string _nguyenlieu;
        private string _tennguyenlieu;
        public NguyenLieuVO()
        {
        }
        public string NGUYENLIEU
        {
            get
            {
                return _nguyenlieu;
            }
            set
            {
                _nguyenlieu = value;
            }
        }
        public string TENNGUYENLIEU
        {
            get
            {
                return _tennguyenlieu;
            }
            set
            {
                _tennguyenlieu = value;
            }
        }
    }
}
