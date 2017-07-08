namespace QLCaoSuPhuRieng
{
    partial class FrmBanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanh));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBanh = new DevExpress.XtraEditors.TextEdit();
            this.gridControlBanh = new DevExpress.XtraGrid.GridControl();
            this.gridViewBanh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.B = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBanh)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(262, 27);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(39, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bành: ";
            // 
            // txtBanh
            // 
            this.txtBanh.Location = new System.Drawing.Point(90, 56);
            this.txtBanh.MenuManager = this.ribbonControl;
            this.txtBanh.Name = "txtBanh";
            this.txtBanh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBanh.Properties.Appearance.Options.UseFont = true;
            this.txtBanh.Size = new System.Drawing.Size(145, 22);
            this.txtBanh.TabIndex = 2;
            // 
            // gridControlBanh
            // 
            this.gridControlBanh.Location = new System.Drawing.Point(12, 101);
            this.gridControlBanh.MainView = this.gridViewBanh;
            this.gridControlBanh.MenuManager = this.ribbonControl;
            this.gridControlBanh.Name = "gridControlBanh";
            this.gridControlBanh.Size = new System.Drawing.Size(236, 200);
            this.gridControlBanh.TabIndex = 4;
            this.gridControlBanh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBanh});
            // 
            // gridViewBanh
            // 
            this.gridViewBanh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.B});
            this.gridViewBanh.GridControl = this.gridControlBanh;
            this.gridViewBanh.Name = "gridViewBanh";
            this.gridViewBanh.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewBanh_RowClick);
            // 
            // B
            // 
            this.B.Caption = "BANH";
            this.B.FieldName = "BANH";
            this.B.Name = "BANH";
            this.B.OptionsColumn.AllowEdit = false;
            this.B.Visible = true;
            this.B.VisibleIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(49, 325);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 26);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Appearance.Options.UseForeColor = true;
            this.btnXoa.Location = new System.Drawing.Point(146, 325);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 26);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FrmBanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 365);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gridControlBanh);
            this.Controls.Add(this.txtBanh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBanh";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL Bành";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBanh_FormClosing);
            this.Load += new System.EventHandler(this.FrmBanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtBanh;
        private DevExpress.XtraGrid.GridControl gridControlBanh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBanh;
        private DevExpress.XtraGrid.Columns.GridColumn B;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
    }
}