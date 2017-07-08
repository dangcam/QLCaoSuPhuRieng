using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCaoSuPhuRieng.VO
{
    class BaoBiVO
    {
        private string _baobi;
        public BaoBiVO()
        {

        }
        public string BAOBI
        {
            get
            {
                return _baobi;
            }
            set
            {
                _baobi = value;
            }
        }
    }
}
