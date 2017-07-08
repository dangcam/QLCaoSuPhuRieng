using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using QLCaoSuPhuRieng.DAO;
using QLCaoSuPhuRieng.VO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLCaoSuPhuRieng
{
    public partial class FrmThanhPham : RibbonForm
    {
        ThanhPhamDAO tp = null;
        DataTable dt = null;
        DataRow dr = null;
        ThanhPhamVO thanhpham = null;
        public FrmThanhPham()
        {
            InitializeComponent();
            thanhpham = new ThanhPhamVO();
            tp = new ThanhPhamDAO();
        }
        bool them = false;
        void LoadData()
        {
            them = false;
            gridControlThanhPham.DataSource = dt;
            gridViewThanhPham_RowClick(null, null);
        }
        private void FrmThanhPham_Load(object sender, EventArgs e)
        {
            dt = tp.DSThanhPham();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            txtLoaiMu.Enabled = true;
            txtLoaiMu.ResetText();
            txtGhiChu.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                if (them)
                {
                    thanhpham.LOAIMU = txtLoaiMu.Text;
                    thanhpham.GHICHU = txtGhiChu.Text;
                    if (tp.ThemThanhPham(ref err, thanhpham))
                    {
                        dr = dt.NewRow();
                        dr[0] = thanhpham.LOAIMU;
                        dr[1] = thanhpham.GHICHU;
                        dt.Rows.Add(dr);
                        XtraMessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        XtraMessageBox.Show("Không thêm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                    thanhpham.LOAIMU = txtLoaiMu.Text;
                    thanhpham.GHICHU = txtGhiChu.Text;
                    if (tp.SuaThanhPham(ref err, thanhpham))
                    {
                        int index = dt.Rows.IndexOf(dr);
                        dt.Rows[index][1] = thanhpham.GHICHU;
                        XtraMessageBox.Show("Đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        XtraMessageBox.Show("Không lưu được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            string err = "";
            // Hiện hộp thoại hỏi đáp 
            DataRow drRow = gridViewThanhPham.GetFocusedDataRow();

            traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (traloi == DialogResult.Yes)
                {
                    thanhpham.LOAIMU = drRow[0].ToString();
                    if (tp.XoaThanhPham(ref err, thanhpham))
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

        private void gridViewThanhPham_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                dr = null;
                txtLoaiMu.Enabled = false;
                dr = gridViewThanhPham.GetFocusedDataRow();
                txtLoaiMu.Text = dr[0].ToString();
                txtGhiChu.Text = dr[1].ToString();
            }
            catch
            {
            }
        }

        private void FrmThanhPham_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            tp = null;
            dt = null;
            dr = null;
            thanhpham = null;
            System.GC.Collect();
        }
    }
}
