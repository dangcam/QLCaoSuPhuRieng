using DevExpress.XtraBars.Ribbon;
using QLCaoSuPhuRieng.DAO;
using System;

namespace QLCaoSuPhuRieng
{
    public partial class FrmChonNhaMay : RibbonForm
    {
        NhaMayDAO nm = null;
        public FrmChonNhaMay()
        {
            InitializeComponent();
            nm = new NhaMayDAO();
            FrmNhapKhoChiTiet.NHAMAY = null;
        }
        
        private void FrmChonNhaMay_Load(object sender, EventArgs e)
        {
            cbNhaMay.DataSource = nm.DSNhaMay();
            cbNhaMay.DisplayMember = "NHAMAY";
            cbNhaMay.ValueMember = "NHAMAY";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                FrmNhapKhoChiTiet.NHAMAY = cbNhaMay.SelectedValue.ToString();
                FrmBaoCao.NHAMAY = cbNhaMay.SelectedValue.ToString();
            }
            catch
            {
                FrmNhapKhoChiTiet.NHAMAY = null;
                FrmBaoCao.NHAMAY = null;
            }
            finally
            {
                this.Close();
            }
        }
    }
}
