using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using QLCaoSuPhuRieng.DAO;
using QLCaoSuPhuRieng.VO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLCaoSuPhuRieng
{
    public partial class FrmBanh : RibbonForm
    {
        BanhDAO banh = null;
        DataTable dt = null;
        DataRow dr = null;
        BanhVO ba = null;
        public FrmBanh()
        {
            InitializeComponent();
            banh = new BanhDAO();
            ba = new BanhVO();
        }
       
        void LoadData()
        {
          
            gridControlBanh.DataSource = dt;
            gridViewBanh_RowClick(null, null);

        }
        private void FrmBanh_Load(object sender, EventArgs e)
        {
            dt = banh.DSBanh();
            LoadData();
        }

        private void gridViewBanh_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            /*
            try
            {
                dr = null;
                dr = gridViewBanh.GetFocusedDataRow();
                txtBanh.Text = dr[0].ToString();
                ba.BANH = txtBanh.Text;
            }
            catch
            {
            }
            */
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
              
                    ba.BANH = txtBanh.Text;
                    if (banh.ThemBanh(ref err, ba))
                    {
                        dr = dt.NewRow();
                        dr[0] = ba.BANH;
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
            txtBanh.ResetText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            string err = "";
            // Hiện hộp thoại hỏi đáp 
            DataRow drRow = gridViewBanh.GetFocusedDataRow();

            traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try {
                if (traloi == DialogResult.Yes)
                {
                    ba.BANH = drRow[0].ToString();
                    if (banh.XoaBanh(ref err, ba))
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

        private void FrmBanh_FormClosing(object sender, FormClosingEventArgs e)
        {
            banh = null;
            dt = null;
            dr = null;
            ba = null;
            System.GC.Collect();
        }
    }
}
