namespace QLCaoSuPhuRieng
{
    partial class FrmNguonNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNguonNhap));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlNguon = new DevExpress.XtraGrid.GridControl();
            this.gridViewNguon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NGUON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNguon = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNguon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNguon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguon.Properties)).BeginInit();
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
            // btnXoa
            // 
            this.btnXoa.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Appearance.Options.UseForeColor = true;
            this.btnXoa.Location = new System.Drawing.Point(147, 315);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 26);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(50, 315);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 26);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gridControlNguon
            // 
            this.gridControlNguon.Location = new System.Drawing.Point(13, 91);
            this.gridControlNguon.MainView = this.gridViewNguon;
            this.gridControlNguon.MenuManager = this.ribbonControl;
            this.gridControlNguon.Name = "gridControlNguon";
            this.gridControlNguon.Size = new System.Drawing.Size(236, 200);
            this.gridControlNguon.TabIndex = 10;
            this.gridControlNguon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNguon});
            // 
            // gridViewNguon
            // 
            this.gridViewNguon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NGUON});
            this.gridViewNguon.GridControl = this.gridControlNguon;
            this.gridViewNguon.Name = "gridViewNguon";
            // 
            // NGUON
            // 
            this.NGUON.Caption = "Nguồn Nhập";
            this.NGUON.FieldName = "NGUON";
            this.NGUON.Name = "NGUON";
            this.NGUON.OptionsColumn.AllowEdit = false;
            this.NGUON.Visible = true;
            this.NGUON.VisibleIndex = 0;
            // 
            // txtNguon
            // 
            this.txtNguon.Location = new System.Drawing.Point(91, 46);
            this.txtNguon.MenuManager = this.ribbonControl;
            this.txtNguon.Name = "txtNguon";
            this.txtNguon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNguon.Properties.Appearance.Options.UseFont = true;
            this.txtNguon.Size = new System.Drawing.Size(145, 22);
            this.txtNguon.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nguồn:";
            // 
            // FrmNguonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 365);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gridControlNguon);
            this.Controls.Add(this.txtNguon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNguonNhap";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nguồn Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNguonNhap_FormClosing);
            this.Load += new System.EventHandler(this.FrmNguonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNguon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNguon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguon.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.GridControl gridControlNguon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNguon;
        private DevExpress.XtraGrid.Columns.GridColumn NGUON;
        private DevExpress.XtraEditors.TextEdit txtNguon;
        private System.Windows.Forms.Label label1;
    }
}