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
    public partial class FrmCaSX : RibbonForm
    {
        CaSXDAO ca = null;
        DataTable dt = null;
        DataRow dr = null;
        CaSXVO casx = null;
        public FrmCaSX()
        {
            InitializeComponent();
            casx = new CaSXVO();
            ca = new CaSXDAO();
        }
        void LoadData()
        {
            gridControlCaSX.DataSource = dt;
        }
        private void FrmCaSX_Load(object sender, EventArgs e)
        {
            dt = ca.DSCaSX();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";

                casx.CASX = txtCaSX.Text;
                if (ca.ThemCaSX(ref err, casx))
                {
                    dr = dt.NewRow();
                    dr[0] = casx.CASX;
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
            txtCaSX.ResetText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            string err = "";
            // Hiện hộp thoại hỏi đáp 
            DataRow drRow = gridViewCaSX.GetFocusedDataRow();
            traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (traloi == DialogResult.Yes)
                {
                    casx.CASX = drRow[0].ToString();
                    if (ca.XoaCaSX(ref err, casx))
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

        private void FrmCaSX_FormClosing(object sender, FormClosingEventArgs e)
        {
            ca = null;
            dt = null;
            dr = null;
            casx = null;
            System.GC.Collect();
        }
    }
}
