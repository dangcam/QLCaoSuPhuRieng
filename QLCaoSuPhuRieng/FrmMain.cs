using DevExpress.XtraBars.Ribbon;
using System.Windows.Forms;
using System.Xml;

namespace QLCaoSuPhuRieng
{
    public partial class FrmMain : RibbonForm
    {
        System.DateTime date = System.DateTime.Now;
        ReadConfig readConfig;
        public FrmMain()
        {
            readConfig = new ReadConfig();
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, System.EventArgs e)
        {
            readConfig.Read();
            labelControlNgayLamViec.Text = "Ngày làm việc: " + date.ToShortDateString();
        }

        private void barBtnBanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = new FrmBanh();
            frm.ShowDialog();
        }

        private void barBtnNhaMay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = new FrmNhaMay();
            frm.ShowDialog();
        }

        private void barBtnNguon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = new FrmNguonNhap();
            frm.ShowDialog();
        }

        private void barBtnTrangThai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = new FrmTrangThai();
            frm.ShowDialog();
        }

        private void barBtnNam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = new FrmNam();
            frm.ShowDialog();
        }

        private void barBtnCauHinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = new FrmCauHinh();
            frm.ShowDialog();
        }

        private void barBtnBaoPE_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = new FrmBaoPE();
            frm.ShowDialog();
        }

        private void barBtnBaoBi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = new FrmBaoBi();
            frm.ShowDialog();
        }

        private void barBtnCaTruong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = new FrmCaTruong();
            frm.ShowDialog();
        }

        private void barBtnCaSX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = new FrmCaSX();
            frm.ShowDialog();
        }

        private void barBtnThanhPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = new FrmThanhPham();
            frm.ShowDialog();
        }

        private void barBtnNguyenLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = new FrmNguyenLieu();
            frm.ShowDialog();
        }

        private void barBtnNhapKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = new FrmNhapKho();
            frm.ShowDialog();
        }

        private void barBtnNhapLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = new FrmChonNhaMay();
            frm.ShowDialog();
            if(FrmNhapKhoChiTiet.NHAMAY!=null)
            {
                frm = new FrmNhapKhoChiTiet();
                frm.ShowDialog();
            }
        }

        private void barBtnBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = new FrmChonNhaMay();
            frm.ShowDialog();
            if (FrmBaoCao.NHAMAY != null)
            {
                frm = new FrmBaoCao();
                frm.ShowDialog();
            }
        }
    }
}
