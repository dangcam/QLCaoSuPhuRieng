namespace QLCaoSuPhuRieng.VO
{
    class ThanhPhamVO
    {
        private string _loaimu;
        private string _ghichu;
        public ThanhPhamVO()
        {
        }
        public string LOAIMU
        {
            get
            {
                return _loaimu;
            }
            set
            {
                _loaimu = value;
            }
        }
        public string GHICHU
        {
            get
            {
                return _ghichu;
            }
            set
            {
                _ghichu = value;
            }
        }
    }
}
