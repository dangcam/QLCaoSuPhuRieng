using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using QLCaoSuPhuRieng.DAO;
using QLCaoSuPhuRieng.VO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLCaoSuPhuRieng
{
    public partial class FrmBaoPE : RibbonForm
    {
        BaoPEDAO pe = null;
        DataTable dt = null;
        DataRow dr = null;
        BaoPEVO bao = null;
        public FrmBaoPE()
        {
            InitializeComponent();
            bao = new BaoPEVO();
            pe = new BaoPEDAO();
        }
        void LoadData()
        {
            gridControlBaoPE.DataSource = dt;
        }
        private void FrmBaoPE_Load(object sender, EventArgs e)
        {
            dt = pe.DSBaoPE();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";

                bao.BAOPE = txtBaoPE.Text;
                if (pe.ThemBaoPE(ref err, bao))
                {
                    dr = dt.NewRow();
                    dr[0] = bao.BAOPE;
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
            txtBaoPE.ResetText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            string err = "";
            // Hiện hộp thoại hỏi đáp 
            DataRow drRow = gridViewBaoPE.GetFocusedDataRow();

            traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (traloi == DialogResult.Yes)
                {
                    bao.BAOPE = drRow[0].ToString();
                    if (pe.XoaBaoPE(ref err, bao))
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

        private void FrmBaoPE_FormClosing(object sender, FormClosingEventArgs e)
        {
            pe = null;
            dt = null;
            dr = null;
            bao = null;
            System.GC.Collect();
        }
    }
}
