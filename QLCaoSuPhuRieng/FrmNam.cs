using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using QLCaoSuPhuRieng.DAO;
using QLCaoSuPhuRieng.VO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLCaoSuPhuRieng
{
    public partial class FrmNam : RibbonForm
    {
        NamDAO n = null;
        DataTable dt = null;
        DataRow dr = null;
        NamVO nam = null;
        public FrmNam()
        {
            InitializeComponent();
            n = new NamDAO();
            nam = new NamVO();
        }
        void LoadData()
        {
            gridControlNam.DataSource = dt;         
        }
        private void FrmNam_Load(object sender, EventArgs e)
        {
            dt = n.DSNam();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";

                nam.NAM = txtNam.Text;
                if (n.ThemNam(ref err, nam))
                {
                    dr = dt.NewRow();
                    dr[0] = nam.NAM;
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
            txtNam.ResetText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            string err = "";
            // Hiện hộp thoại hỏi đáp 
            DataRow drRow = gridViewNam.GetFocusedDataRow();

            traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (traloi == DialogResult.Yes)
                {
                    nam.NAM = drRow[0].ToString();
                    if (n.XoaNam(ref err, nam))
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

        private void FrmNam_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            n = null;
            dt = null;
            dr = null;
            nam = null;
            System.GC.Collect();
        }
    }
}
