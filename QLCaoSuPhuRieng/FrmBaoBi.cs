using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using QLCaoSuPhuRieng.DAO;
using QLCaoSuPhuRieng.VO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLCaoSuPhuRieng
{
    public partial class FrmBaoBi : RibbonForm
    {

        BaoBiDAO bi = null;
        DataTable dt = null;
        DataRow dr = null;
        BaoBiVO bao = null;
        public FrmBaoBi()
        {
            InitializeComponent();
            bi = new BaoBiDAO();
            bao = new BaoBiVO();
        }
        void LoadData()
        {
            gridControlBaoBi.DataSource = dt;
        }
        private void FrmBaoBi_Load(object sender, EventArgs e)
        {
            dt = bi.DSBaoBi();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";

                bao.BAOBI = txtBaoBi.Text;
                if (bi.ThemBaoBi(ref err, bao))
                {
                    dr = dt.NewRow();
                    dr[0] = bao.BAOBI;
                    dt.Rows.Add(dr);
                    XtraMessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    XtraMessageBox.Show("Không thêm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {

            }
            txtBaoBi.ResetText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            string err = "";
            // Hiện hộp thoại hỏi đáp 
            DataRow drRow = gridViewBaoBi.GetFocusedDataRow();

            traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (traloi == DialogResult.Yes)
                {
                    bao.BAOBI = drRow[0].ToString();
                    if (bi.XoaBaoBi(ref err, bao))
                    {
                        XtraMessageBox.Show("Xóa thành công!");
                        int index = dt.Rows.IndexOf(drRow);
                        dt.Rows[index].Delete();
                        LoadData();
                    }
                    else
                    {
                        XtraMessageBox.Show("Không thể xóa mẫu tin này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch { }
        }

        private void FrmBaoBi_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            bi = null;
            dt = null;
            dr = null;
            bao = null;
            System.GC.Collect();
        }
    }
}
