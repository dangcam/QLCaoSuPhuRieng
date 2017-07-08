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
    public partial class FrmNguyenLieu : RibbonForm
    {
        NguyenLieuDAO nl = null;
        DataTable dt = null;
        DataRow dr = null;
        NguyenLieuVO nguyenlieu = null;
        public FrmNguyenLieu()
        {
            InitializeComponent();
            nl = new NguyenLieuDAO();
            nguyenlieu = new NguyenLieuVO();

        }
        bool them = false;
        void LoadData()
        {
            them = false;
            gridControlNguyenLieu.DataSource = dt;
            gridViewNguyenLieu_RowClick(null, null);
        }
        private void FrmNguyenLieu_Load(object sender, EventArgs e)
        {
            dt = nl.DSNguyenLieu();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            txtNguyenLieu.Enabled = true;
            txtNguyenLieu.ResetText();
            txtTenNL.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                if (them)
                {
                    nguyenlieu.NGUYENLIEU = txtNguyenLieu.Text;
                    nguyenlieu.TENNGUYENLIEU = txtTenNL.Text;
                    if (nl.ThemNguyenLieu(ref err, nguyenlieu))
                    {
                        dr = dt.NewRow();
                        dr[0] = nguyenlieu.NGUYENLIEU;
                        dr[1] = nguyenlieu.TENNGUYENLIEU;
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

                    nguyenlieu.NGUYENLIEU = txtNguyenLieu.Text;
                    nguyenlieu.TENNGUYENLIEU = txtTenNL.Text;
                    if (nl.SuaNguyenLieu(ref err, nguyenlieu))
                    {
                        int index = dt.Rows.IndexOf(dr);
                        dt.Rows[index][1] = nguyenlieu.TENNGUYENLIEU;
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
            DataRow drRow = gridViewNguyenLieu.GetFocusedDataRow();

            traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (traloi == DialogResult.Yes)
                {
                    nguyenlieu.NGUYENLIEU = drRow[0].ToString();
                    if (nl.XoaNguyenLieu(ref err, nguyenlieu))
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

        private void gridViewNguyenLieu_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                dr = null;
                txtNguyenLieu.Enabled = false;
                dr = gridViewNguyenLieu.GetFocusedDataRow();
                txtNguyenLieu.Text = dr[0].ToString();
                txtTenNL.Text = dr[1].ToString();
            }
            catch
            {
            }
        }

        private void FrmNguyenLieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            nl = null;
            dt = null;
            dr = null;
            nguyenlieu = null;
            System.GC.Collect();
        }
    }
}
