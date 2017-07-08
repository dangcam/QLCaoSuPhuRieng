using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCaoSuPhuRieng.VO
{
    class CaSXVO
    {
        private string _casx;
        public CaSXVO()
        {
        }
        public string CASX
        {
            get
            {
                return _casx;
            }
            set
            {
                _casx = value;
            }
        }
    }
}
