namespace QLCaoSuPhuRieng
{
    partial class FrmNguyenLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNguyenLieu));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlNguyenLieu = new DevExpress.XtraGrid.GridControl();
            this.gridViewNguyenLieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NGUYENLIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENNGUYENLIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTenNL = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNguyenLieu = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguyenLieu.Properties)).BeginInit();
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
            this.btnXoa.Location = new System.Drawing.Point(189, 389);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 26);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(113, 389);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(60, 26);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(37, 389);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 26);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gridControlNguyenLieu
            // 
            this.gridControlNguyenLieu.Location = new System.Drawing.Point(12, 117);
            this.gridControlNguyenLieu.MainView = this.gridViewNguyenLieu;
            this.gridControlNguyenLieu.MenuManager = this.ribbonControl;
            this.gridControlNguyenLieu.Name = "gridControlNguyenLieu";
            this.gridControlNguyenLieu.Size = new System.Drawing.Size(260, 254);
            this.gridControlNguyenLieu.TabIndex = 17;
            this.gridControlNguyenLieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNguyenLieu});
            // 
            // gridViewNguyenLieu
            // 
            this.gridViewNguyenLieu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NGUYENLIEU,
            this.TENNGUYENLIEU});
            this.gridViewNguyenLieu.GridControl = this.gridControlNguyenLieu;
            this.gridViewNguyenLieu.Name = "gridViewNguyenLieu";
            this.gridViewNguyenLieu.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewNguyenLieu_RowClick);
            // 
            // NGUYENLIEU
            // 
            this.NGUYENLIEU.Caption = "Nguyên Liệu";
            this.NGUYENLIEU.FieldName = "NGUYENLIEU";
            this.NGUYENLIEU.Name = "NGUYENLIEU";
            this.NGUYENLIEU.OptionsColumn.AllowEdit = false;
            this.NGUYENLIEU.Visible = true;
            this.NGUYENLIEU.VisibleIndex = 0;
            this.NGUYENLIEU.Width = 70;
            // 
            // TENNGUYENLIEU
            // 
            this.TENNGUYENLIEU.Caption = "Tên Nguyên Liệu";
            this.TENNGUYENLIEU.FieldName = "TENNGUYENLIEU";
            this.TENNGUYENLIEU.Name = "TENNGUYENLIEU";
            this.TENNGUYENLIEU.OptionsColumn.AllowEdit = false;
            this.TENNGUYENLIEU.Visible = true;
            this.TENNGUYENLIEU.VisibleIndex = 1;
            this.TENNGUYENLIEU.Width = 172;
            // 
            // txtTenNL
            // 
            this.txtTenNL.Location = new System.Drawing.Point(127, 78);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNL.Properties.Appearance.Options.UseFont = true;
            this.txtTenNL.Size = new System.Drawing.Size(145, 22);
            this.txtTenNL.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên Nguyên Liệu:";
            // 
            // txtNguyenLieu
            // 
            this.txtNguyenLieu.Location = new System.Drawing.Point(127, 45);
            this.txtNguyenLieu.MenuManager = this.ribbonControl;
            this.txtNguyenLieu.Name = "txtNguyenLieu";
            this.txtNguyenLieu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNguyenLieu.Properties.Appearance.Options.UseFont = true;
            this.txtNguyenLieu.Size = new System.Drawing.Size(145, 22);
            this.txtNguyenLieu.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(39, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nguyên Liệu:";
            // 
            // FrmNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 435);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gridControlNguyenLieu);
            this.Controls.Add(this.txtTenNL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNguyenLieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNguyenLieu";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nguyên Liệu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNguyenLieu_FormClosing);
            this.Load += new System.EventHandler(this.FrmNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguyenLieu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.GridControl gridControlNguyenLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn TENNGUYENLIEU;
        private DevExpress.XtraEditors.TextEdit txtTenNL;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtNguyenLieu;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn NGUYENLIEU;
    }
}