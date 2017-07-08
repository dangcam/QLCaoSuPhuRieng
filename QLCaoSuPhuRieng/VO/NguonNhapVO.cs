using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCaoSuPhuRieng.VO
{
    class NguonNhapVO
    {
        private string _nguonNhap;
        public NguonNhapVO()
        {

        }
        public string NGUON
        {
            get
            {
                return _nguonNhap;
            }
            set
            {
                _nguonNhap = value;
            }
        }
    }
}
