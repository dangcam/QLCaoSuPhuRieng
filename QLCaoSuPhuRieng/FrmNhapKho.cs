using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using QLCaoSuPhuRieng.DAO;
using QLCaoSuPhuRieng.VO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLCaoSuPhuRieng
{
    public partial class FrmNhapKho : RibbonForm
    {
        NhapKhoDAO nk = null;
        DataTable dt = null;
        DataRow dr = null;
        NhapKhoVO nhapkho = null;
        public FrmNhapKho()
        {
            InitializeComponent();
            nk = new NhapKhoDAO();
            nhapkho = new NhapKhoVO();
        }
        bool them = false;
        void LoadData()
        {
            them = false;
            gridControlNhapKho.DataSource = dt;
            gridViewNhapKho_RowClick(null, null);
        }
        private void FrmNhapKho_Load(object sender, EventArgs e)
        {
            cbNhaMay.DataSource = nk.DSNhaMay();
            cbNhaMay.DisplayMember = "NHAMAY";
            cbNhaMay.ValueMember = "NHAMAY";
            dt = nk.DSNhapKho();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            dateNgayNhap.Text = DateTime.Now.ToShortDateString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                if (them)
                {
                    nhapkho.NHAMAY = cbNhaMay.SelectedValue.ToString();
                    nhapkho.NGAYNHAP = DateTime.Parse(DateTime.Parse(dateNgayNhap.Text).ToShortDateString());
                    if (nk.ThemNhapKho(ref err, nhapkho))
                    {
                        /*
                        dr = dt.NewRow();
                        dr[0] = nhapkho.ID + 1;
                        dr[1] = nhapkho.NHAMAY;
                        dr[2] = nhapkho.NGAYNHAP;
                        dt.Rows.Add(dr);
                        */
                        XtraMessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dt = nk.DSNhapKho();
                        LoadData();
                    }
                    else
                    {
                        XtraMessageBox.Show("Không thêm được! "+err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                    nhapkho.NHAMAY = cbNhaMay.SelectedValue.ToString();
                    nhapkho.NGAYNHAP = DateTime.Parse(DateTime.Parse(dateNgayNhap.Text).ToShortDateString());
                    if (nk.SuaNhapKho(ref err, nhapkho))
                    {
                        int index = dt.Rows.IndexOf(dr);
                        dr[1] = nhapkho.NHAMAY;
                        dr[2] = nhapkho.NGAYNHAP;
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
            DataRow drRow = gridViewNhapKho.GetFocusedDataRow();

            traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (traloi == DialogResult.Yes)
                {
                    nhapkho.ID = int.Parse(drRow[0].ToString());
                    if (nk.XoaNhapKho(ref err, nhapkho))
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

        private void gridViewNhapKho_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                dr = null;
                dr = gridViewNhapKho.GetFocusedDataRow();
                nhapkho.ID = int.Parse(dr[0].ToString());
                cbNhaMay.SelectedValue = dr[1].ToString();
                dateNgayNhap.Text = DateTime.Parse(dr[2].ToString()).ToShortDateString();
            }
            catch
            {
            }
        }

        private void FrmNhapKho_FormClosing(object sender, FormClosingEventArgs e)
        {
            nk = null;
            dt = null;
            dr = null;
            nhapkho = null;
            System.GC.Collect();
        }
    }
}
