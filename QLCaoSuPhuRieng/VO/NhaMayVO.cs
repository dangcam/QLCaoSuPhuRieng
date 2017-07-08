using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCaoSuPhuRieng.VO
{
    class NhaMayVO
    {
        private string _nhaMay;
        public NhaMayVO()
        {

        }
        public string NHAMAY
        {
            get
            {
                return _nhaMay;
            }
            set
            {
                _nhaMay = value;
            }
        }
    }
}
