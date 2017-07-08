using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using QLCaoSuPhuRieng.DAO;
using QLCaoSuPhuRieng.VO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLCaoSuPhuRieng
{
    public partial class FrmCaTruong : RibbonForm
    {
        CaTruongDAO ca = null;
        DataTable dt = null;
        DataRow dr = null;
        CaTruongVO catruong = null;
        public FrmCaTruong()
        {
            InitializeComponent();
            ca = new CaTruongDAO();
            catruong = new CaTruongVO();
        }
        void LoadData()
        {
            gridControlCaTruong.DataSource = dt;
        }
        private void FrmCaTruong_Load(object sender, EventArgs e)
        {
            dt = ca.DSCaTruong();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";

                catruong.CATRUONG = txtCaTruong.Text;
                if (ca.ThemCaTruong(ref err, catruong))
                {
                    dr = dt.NewRow();
                    dr[0] = catruong.CATRUONG;
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
            txtCaTruong.ResetText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            string err = "";
            // Hiện hộp thoại hỏi đáp 
            DataRow drRow = gridViewCaTruong.GetFocusedDataRow();
            traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (traloi == DialogResult.Yes)
                {
                    catruong.CATRUONG = drRow[0].ToString();
                    if (ca.XoaCaTruong(ref err, catruong))
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

        private void FrmCaTruong_FormClosing(object sender, FormClosingEventArgs e)
        {
            ca = null;
            dt = null;
            dr = null;
            catruong = null;
            System.GC.Collect();
        }
    }
}
