using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using QLCaoSuPhuRieng.DAO;
using QLCaoSuPhuRieng.VO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLCaoSuPhuRieng
{
    public partial class FrmTrangThai : RibbonForm
    {
        TrangThaiDAO tt = null;
        DataTable dt = null;
        DataRow dr = null;
        TrangThaiVO trangthai = null;
        public FrmTrangThai()
        {
            InitializeComponent();
            tt = new TrangThaiDAO();
            trangthai = new TrangThaiVO();
        }
        void LoadData()
        {
            gridControlTrangThai.DataSource = dt;
        }
        private void FrmTrangThai_Load(object sender, EventArgs e)
        {
            dt = tt.DSTrangThai();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";

                trangthai.TRANGTHAI = txtTrangThai.Text;
                if (tt.ThemTrangThai(ref err, trangthai))
                {
                    dr = dt.NewRow();
                    dr[0] = trangthai.TRANGTHAI;
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
            txtTrangThai.ResetText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            string err = "";
            // Hiện hộp thoại hỏi đáp 
            DataRow drRow = gridViewTrangThai.GetFocusedDataRow();

            traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (traloi == DialogResult.Yes)
                {
                    trangthai.TRANGTHAI = drRow[0].ToString();
                    if (tt.XoaTrangThai(ref err, trangthai))
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

        private void FrmTrangThai_FormClosing(object sender, FormClosingEventArgs e)
        {
             tt = null;
             dt = null;
             dr = null;
             trangthai = null;
            GC.Collect();
        }
    }
}
