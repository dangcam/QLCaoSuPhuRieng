namespace QLCaoSuPhuRieng
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnNhapLieu = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBaoCao = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnXemKQKiemPham = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCauHinh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnNhaMay = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnNguon = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnThanhPham = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBanh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnNguyenLieu = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnTrangThai = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBaoPE = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBaoBi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnNhapKho = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCaSX = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCaTruong = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnNam = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupChucNang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupNam = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.labelControlNgayLamViec = new DevExpress.XtraEditors.LabelControl();
            this.picLogo = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.barBtnNhapLieu,
            this.barBtnBaoCao,
            this.barBtnXemKQKiemPham,
            this.barBtnCauHinh,
            this.barBtnNhaMay,
            this.barBtnNguon,
            this.barBtnThanhPham,
            this.barBtnBanh,
            this.barBtnNguyenLieu,
            this.barBtnTrangThai,
            this.barBtnBaoPE,
            this.barBtnBaoBi,
            this.barBtnNhapKho,
            this.barBtnCaSX,
            this.barBtnCaTruong,
            this.barBtnNam});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 17;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageHeThong,
            this.ribbonPageQuanLy});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowCategoryInCaption = false;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(864, 143);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // barBtnNhapLieu
            // 
            this.barBtnNhapLieu.Caption = "Nhập liệu";
            this.barBtnNhapLieu.Glyph = global::QLCaoSuPhuRieng.Properties.Resources.document_edit;
            this.barBtnNhapLieu.Id = 1;
            this.barBtnNhapLieu.LargeGlyph = global::QLCaoSuPhuRieng.Properties.Resources.document_edit;
            this.barBtnNhapLieu.Name = "barBtnNhapLieu";
            this.barBtnNhapLieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNhapLieu_ItemClick);
            // 
            // barBtnBaoCao
            // 
            this.barBtnBaoCao.Caption = "Báo cáo";
            this.barBtnBaoCao.Id = 2;
            this.barBtnBaoCao.LargeGlyph = global::QLCaoSuPhuRieng.Properties.Resources.Reports;
            this.barBtnBaoCao.Name = "barBtnBaoCao";
            this.barBtnBaoCao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBaoCao_ItemClick);
            // 
            // barBtnXemKQKiemPham
            // 
            this.barBtnXemKQKiemPham.Caption = "Xem kết quả Kiểm phẩm";
            this.barBtnXemKQKiemPham.Id = 3;
            this.barBtnXemKQKiemPham.LargeGlyph = global::QLCaoSuPhuRieng.Properties.Resources.view_pim_notes;
            this.barBtnXemKQKiemPham.Name = "barBtnXemKQKiemPham";
            // 
            // barBtnCauHinh
            // 
            this.barBtnCauHinh.Caption = "Cấu hình";
            this.barBtnCauHinh.Id = 4;
            this.barBtnCauHinh.LargeGlyph = global::QLCaoSuPhuRieng.Properties.Resources.Aroche_Delta_Settings;
            this.barBtnCauHinh.Name = "barBtnCauHinh";
            this.barBtnCauHinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCauHinh_ItemClick);
            // 
            // barBtnNhaMay
            // 
            this.barBtnNhaMay.Caption = "Nhà máy";
            this.barBtnNhaMay.Id = 5;
            this.barBtnNhaMay.LargeGlyph = global::QLCaoSuPhuRieng.Properties.Resources.factory;
            this.barBtnNhaMay.Name = "barBtnNhaMay";
            this.barBtnNhaMay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNhaMay_ItemClick);
            // 
            // barBtnNguon
            // 
            this.barBtnNguon.Caption = "Nguồn nhập";
            this.barBtnNguon.Id = 6;
            this.barBtnNguon.LargeGlyph = global::QLCaoSuPhuRieng.Properties.Resources.Import;
            this.barBtnNguon.Name = "barBtnNguon";
            this.barBtnNguon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNguon_ItemClick);
            // 
            // barBtnThanhPham
            // 
            this.barBtnThanhPham.Caption = "Thành phẩm";
            this.barBtnThanhPham.Id = 7;
            this.barBtnThanhPham.LargeGlyph = global::QLCaoSuPhuRieng.Properties.Resources.Black_Special_Ok;
            this.barBtnThanhPham.Name = "barBtnThanhPham";
            this.barBtnThanhPham.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThanhPham_ItemClick);
            // 
            // barBtnBanh
            // 
            this.barBtnBanh.Caption = "Bành";
            this.barBtnBanh.Id = 8;
            this.barBtnBanh.LargeGlyph = global::QLCaoSuPhuRieng.Properties.Resources.Parcel_pack_box;
            this.barBtnBanh.Name = "barBtnBanh";
            this.barBtnBanh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBanh_ItemClick);
            // 
            // barBtnNguyenLieu
            // 
            this.barBtnNguyenLieu.Caption = "Nguyên liệu";
            this.barBtnNguyenLieu.Id = 9;
            this.barBtnNguyenLieu.LargeGlyph = global::QLCaoSuPhuRieng.Properties.Resources.material_drop_tool;
            this.barBtnNguyenLieu.Name = "barBtnNguyenLieu";
            this.barBtnNguyenLieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNguyenLieu_ItemClick);
            // 
            // barBtnTrangThai
            // 
            this.barBtnTrangThai.Caption = "Trạng thái";
            this.barBtnTrangThai.Id = 10;
            this.barBtnTrangThai.LargeGlyph = global::QLCaoSuPhuRieng.Properties.Resources.information;
            this.barBtnTrangThai.Name = "barBtnTrangThai";
            this.barBtnTrangThai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnTrangThai_ItemClick);
            // 
            // barBtnBaoPE
            // 
            this.barBtnBaoPE.Caption = "BaoPE";
            this.barBtnBaoPE.Id = 11;
            this.barBtnBaoPE.LargeGlyph = global::QLCaoSuPhuRieng.Properties.Resources.bullets_folded;
            this.barBtnBaoPE.Name = "barBtnBaoPE";
            this.barBtnBaoPE.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBaoPE_ItemClick);
            // 
            // barBtnBaoBi
            // 
            this.barBtnBaoBi.Caption = "BaoBi";
            this.barBtnBaoBi.Id = 12;
            this.barBtnBaoBi.LargeGlyph = global::QLCaoSuPhuRieng.Properties.Resources.Bullets_folded_bi;
            this.barBtnBaoBi.Name = "barBtnBaoBi";
            this.barBtnBaoBi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBaoBi_ItemClick);
            // 
            // barBtnNhapKho
            // 
            this.barBtnNhapKho.Caption = "Nhập kho";
            this.barBtnNhapKho.Id = 13;
            this.barBtnNhapKho.LargeGlyph = global::QLCaoSuPhuRieng.Properties.Resources.Import;
            this.barBtnNhapKho.Name = "barBtnNhapKho";
            this.barBtnNhapKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNhapKho_ItemClick);
            // 
            // barBtnCaSX
            // 
            this.barBtnCaSX.Caption = "Ca SX";
            this.barBtnCaSX.Id = 14;
            this.barBtnCaSX.LargeGlyph = global::QLCaoSuPhuRieng.Properties.Resources.People_Boss;
            this.barBtnCaSX.Name = "barBtnCaSX";
            this.barBtnCaSX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCaSX_ItemClick);
            // 
            // barBtnCaTruong
            // 
            this.barBtnCaTruong.Caption = "Ca Trưởng";
            this.barBtnCaTruong.Id = 15;
            this.barBtnCaTruong.LargeGlyph = global::QLCaoSuPhuRieng.Properties.Resources.Boss_Chief;
            this.barBtnCaTruong.Name = "barBtnCaTruong";
            this.barBtnCaTruong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCaTruong_ItemClick);
            // 
            // barBtnNam
            // 
            this.barBtnNam.Caption = "Năm";
            this.barBtnNam.Id = 16;
            this.barBtnNam.LargeGlyph = global::QLCaoSuPhuRieng.Properties.Resources.Calendar;
            this.barBtnNam.Name = "barBtnNam";
            this.barBtnNam.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNam_ItemClick);
            // 
            // ribbonPageHeThong
            // 
            this.ribbonPageHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupHeThong,
            this.ribbonPageGroupChucNang});
            this.ribbonPageHeThong.Name = "ribbonPageHeThong";
            this.ribbonPageHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroupHeThong
            // 
            this.ribbonPageGroupHeThong.ItemLinks.Add(this.barBtnCauHinh);
            this.ribbonPageGroupHeThong.Name = "ribbonPageGroupHeThong";
            this.ribbonPageGroupHeThong.ShowCaptionButton = false;
            // 
            // ribbonPageGroupChucNang
            // 
            this.ribbonPageGroupChucNang.ItemLinks.Add(this.barBtnNhapLieu);
            this.ribbonPageGroupChucNang.ItemLinks.Add(this.barBtnBaoCao);
            this.ribbonPageGroupChucNang.ItemLinks.Add(this.barBtnXemKQKiemPham);
            this.ribbonPageGroupChucNang.Name = "ribbonPageGroupChucNang";
            this.ribbonPageGroupChucNang.ShowCaptionButton = false;
            // 
            // ribbonPageQuanLy
            // 
            this.ribbonPageQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupQuanLy,
            this.ribbonPageGroupNam});
            this.ribbonPageQuanLy.Name = "ribbonPageQuanLy";
            this.ribbonPageQuanLy.Text = "Quản lý";
            // 
            // ribbonPageGroupQuanLy
            // 
            this.ribbonPageGroupQuanLy.ItemLinks.Add(this.barBtnNhaMay);
            this.ribbonPageGroupQuanLy.ItemLinks.Add(this.barBtnNguon);
            this.ribbonPageGroupQuanLy.ItemLinks.Add(this.barBtnThanhPham);
            this.ribbonPageGroupQuanLy.ItemLinks.Add(this.barBtnBanh);
            this.ribbonPageGroupQuanLy.ItemLinks.Add(this.barBtnNguyenLieu);
            this.ribbonPageGroupQuanLy.ItemLinks.Add(this.barBtnTrangThai);
            this.ribbonPageGroupQuanLy.ItemLinks.Add(this.barBtnBaoPE);
            this.ribbonPageGroupQuanLy.ItemLinks.Add(this.barBtnBaoBi);
            this.ribbonPageGroupQuanLy.ItemLinks.Add(this.barBtnNhapKho);
            this.ribbonPageGroupQuanLy.ItemLinks.Add(this.barBtnCaSX);
            this.ribbonPageGroupQuanLy.ItemLinks.Add(this.barBtnCaTruong);
            this.ribbonPageGroupQuanLy.Name = "ribbonPageGroupQuanLy";
            this.ribbonPageGroupQuanLy.ShowCaptionButton = false;
            // 
            // ribbonPageGroupNam
            // 
            this.ribbonPageGroupNam.ItemLinks.Add(this.barBtnNam);
            this.ribbonPageGroupNam.Name = "ribbonPageGroupNam";
            this.ribbonPageGroupNam.ShowCaptionButton = false;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.labelControlNgayLamViec);
            this.panelControl.Controls.Add(this.picLogo);
            this.panelControl.Controls.Add(this.labelControl3);
            this.panelControl.Controls.Add(this.labelControl2);
            this.panelControl.Controls.Add(this.labelControl1);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 143);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(864, 348);
            this.panelControl.TabIndex = 1;
            // 
            // labelControlNgayLamViec
            // 
            this.labelControlNgayLamViec.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControlNgayLamViec.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControlNgayLamViec.Location = new System.Drawing.Point(671, 291);
            this.labelControlNgayLamViec.Name = "labelControlNgayLamViec";
            this.labelControlNgayLamViec.Size = new System.Drawing.Size(154, 16);
            this.labelControlNgayLamViec.TabIndex = 4;
            this.labelControlNgayLamViec.Text = "Ngày làm việc: 18/01/2016";
            // 
            // picLogo
            // 
            this.picLogo.EditValue = global::QLCaoSuPhuRieng.Properties.Resources.phurieng_logo;
            this.picLogo.Location = new System.Drawing.Point(79, 37);
            this.picLogo.MenuManager = this.ribbonControl;
            this.picLogo.Name = "picLogo";
            this.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Properties.Appearance.Options.UseBackColor = true;
            this.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picLogo.Size = new System.Drawing.Size(110, 107);
            this.picLogo.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(300, 127);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(266, 48);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "CHƯƠNG TRÌNH QUẢN LÝ\r\nNHẬP KHO THÀNH PHẨM";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelControl2.Location = new System.Drawing.Point(301, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(263, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "NMCB TRUNG TÂM - DC MỦ TINH";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl1.Location = new System.Drawing.Point(277, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(302, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "CÔNG TY TNHH MTV CAO SU PHÚ RIỀNG";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 491);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Công ty Cao Su Phú Riềng";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHeThong;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit picLogo;
        private DevExpress.XtraEditors.LabelControl labelControlNgayLamViec;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupHeThong;
        private DevExpress.XtraBars.BarButtonItem barBtnNhapLieu;
        private DevExpress.XtraBars.BarButtonItem barBtnBaoCao;
        private DevExpress.XtraBars.BarButtonItem barBtnXemKQKiemPham;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupChucNang;
        private DevExpress.XtraBars.BarButtonItem barBtnCauHinh;
        private DevExpress.XtraBars.BarButtonItem barBtnNhaMay;
        private DevExpress.XtraBars.BarButtonItem barBtnNguon;
        private DevExpress.XtraBars.BarButtonItem barBtnThanhPham;
        private DevExpress.XtraBars.BarButtonItem barBtnBanh;
        private DevExpress.XtraBars.BarButtonItem barBtnNguyenLieu;
        private DevExpress.XtraBars.BarButtonItem barBtnTrangThai;
        private DevExpress.XtraBars.BarButtonItem barBtnBaoPE;
        private DevExpress.XtraBars.BarButtonItem barBtnBaoBi;
        private DevExpress.XtraBars.BarButtonItem barBtnNhapKho;
        private DevExpress.XtraBars.BarButtonItem barBtnCaSX;
        private DevExpress.XtraBars.BarButtonItem barBtnCaTruong;
        private DevExpress.XtraBars.BarButtonItem barBtnNam;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNam;
    }
}

