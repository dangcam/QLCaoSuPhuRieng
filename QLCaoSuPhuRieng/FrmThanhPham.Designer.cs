namespace QLCaoSuPhuRieng
{
    partial class FrmThanhPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThanhPham));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlThanhPham = new DevExpress.XtraGrid.GridControl();
            this.gridViewThanhPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LOAIMU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtLoaiMu = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlThanhPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThanhPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiMu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ribbonControl.AllowMinimizeRibbon = false;
            this.ribbonControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 1;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowCategoryInCaption = false;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(285, 27);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Appearance.Options.UseForeColor = true;
            this.btnXoa.Location = new System.Drawing.Point(190, 390);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 26);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(38, 390);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 26);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gridControlThanhPham
            // 
            this.gridControlThanhPham.Location = new System.Drawing.Point(13, 118);
            this.gridControlThanhPham.MainView = this.gridViewThanhPham;
            this.gridControlThanhPham.MenuManager = this.ribbonControl;
            this.gridControlThanhPham.Name = "gridControlThanhPham";
            this.gridControlThanhPham.Size = new System.Drawing.Size(260, 254);
            this.gridControlThanhPham.TabIndex = 10;
            this.gridControlThanhPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewThanhPham});
            // 
            // gridViewThanhPham
            // 
            this.gridViewThanhPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LOAIMU,
            this.GHICHU});
            this.gridViewThanhPham.GridControl = this.gridControlThanhPham;
            this.gridViewThanhPham.Name = "gridViewThanhPham";
            this.gridViewThanhPham.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewThanhPham_RowClick);
            // 
            // LOAIMU
            // 
            this.LOAIMU.Caption = "Loại Mủ";
            this.LOAIMU.FieldName = "LOAIMU";
            this.LOAIMU.Name = "LOAIMU";
            this.LOAIMU.OptionsColumn.AllowEdit = false;
            this.LOAIMU.Visible = true;
            this.LOAIMU.VisibleIndex = 0;
            // 
            // GHICHU
            // 
            this.GHICHU.Caption = "Ghi Chú";
            this.GHICHU.FieldName = "GHICHU";
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.OptionsColumn.AllowEdit = false;
            this.GHICHU.Visible = true;
            this.GHICHU.VisibleIndex = 1;
            // 
            // txtLoaiMu
            // 
            this.txtLoaiMu.Location = new System.Drawing.Point(95, 46);
            this.txtLoaiMu.MenuManager = this.ribbonControl;
            this.txtLoaiMu.Name = "txtLoaiMu";
            this.txtLoaiMu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLoaiMu.Properties.Appearance.Options.UseFont = true;
            this.txtLoaiMu.Size = new System.Drawing.Size(145, 22);
            this.txtLoaiMu.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Loại Mủ:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(114, 390);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(60, 26);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(36, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ghi Chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(95, 79);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChu.Properties.Appearance.Options.UseFont = true;
            this.txtGhiChu.Size = new System.Drawing.Size(145, 22);
            this.txtGhiChu.TabIndex = 9;
            // 
            // FrmThanhPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 435);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gridControlThanhPham);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLoaiMu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThanhPham";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thành Phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmThanhPham_FormClosing);
            this.Load += new System.EventHandler(this.FrmThanhPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlThanhPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThanhPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiMu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.GridControl gridControlThanhPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewThanhPham;
        private DevExpress.XtraGrid.Columns.GridColumn LOAIMU;
        private DevExpress.XtraEditors.TextEdit txtLoaiMu;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn GHICHU;
    }
}