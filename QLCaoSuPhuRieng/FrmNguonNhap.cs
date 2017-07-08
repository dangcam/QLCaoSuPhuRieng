using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using QLCaoSuPhuRieng.DAO;
using QLCaoSuPhuRieng.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCaoSuPhuRieng
{
    public partial class FrmNguonNhap : RibbonForm
    {
        NguonNhapDAO nn = null;
        DataTable dt = null;
        DataRow dr = null;
        NguonNhapVO nguon = null;

        public FrmNguonNhap()
        {
            InitializeComponent();
            nn = new NguonNhapDAO();
            nguon = new NguonNhapVO();
        }
        void LoadData()
        {
            gridControlNguon.DataSource = dt;
        }
        private void FrmNguonNhap_Load(object sender, EventArgs e)
        {
            dt = nn.DSNguon();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";

                nguon.NGUON = txtNguon.Text;
                if (nn.ThemNguon(ref err, nguon))
                {
                    dr = dt.NewRow();
                    dr[0] = nguon.NGUON;
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
            txtNguon.ResetText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            string err = "";
            // Hiện hộp thoại hỏi đáp 
            DataRow drRow = gridViewNguon.GetFocusedDataRow();

            traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try {
                if (traloi == DialogResult.Yes)
                {
                    nguon.NGUON = drRow[0].ToString();
                    if (nn.XoaNguon(ref err, nguon))
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

        private void FrmNguonNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            nn = null;
            dt = null;
            dr = null;
            nguon = null;
            System.GC.Collect();
        }
    }
}
