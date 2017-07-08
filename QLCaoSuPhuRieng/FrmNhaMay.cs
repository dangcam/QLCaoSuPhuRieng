using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using QLCaoSuPhuRieng.DAO;
using QLCaoSuPhuRieng.VO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLCaoSuPhuRieng
{
    public partial class FrmNhaMay : RibbonForm
    {
        NhaMayDAO nm = null;
        DataTable dt = null;
        DataRow dr = null;
        NhaMayVO nhamay = null;
        public FrmNhaMay()
        {
            InitializeComponent();
            nm = new NhaMayDAO();
            nhamay = new NhaMayVO();
        }
        void LoadData()
        {
            gridControlNhaMay.DataSource = dt;
        }
        private void FrmNhaMay_Load(object sender, EventArgs e)
        {
            dt = nm.DSNhaMay();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";

                nhamay.NHAMAY = txtNhaMay.Text;
                if (nm.ThemNhaMay(ref err, nhamay))
                {
                    dr = dt.NewRow();
                    dr[0] = nhamay.NHAMAY;
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
            txtNhaMay.ResetText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            string err = "";
            // Hiện hộp thoại hỏi đáp 
            DataRow drRow = gridViewNhaMay.GetFocusedDataRow();
            
            traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try {
                if (traloi == DialogResult.Yes)
                {
                    nhamay.NHAMAY = drRow[0].ToString();
                    if (nm.XoaNhaMay(ref err, nhamay))
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

        private void FrmNhaMay_FormClosing(object sender, FormClosingEventArgs e)
        {
             nm = null;
             dt = null;
             dr = null;
             nhamay = null;
            System.GC.Collect();
        }
    }
}
