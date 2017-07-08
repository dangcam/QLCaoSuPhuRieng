namespace QLCaoSuPhuRieng
{
    partial class FrmNhaMay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhaMay));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlNhaMay = new DevExpress.XtraGrid.GridControl();
            this.gridViewNhaMay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NHAMAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNhaMay = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhaMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhaMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaMay.Properties)).BeginInit();
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
            this.btnXoa.Location = new System.Drawing.Point(147, 316);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 26);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(50, 316);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 26);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gridControlNhaMay
            // 
            this.gridControlNhaMay.Location = new System.Drawing.Point(13, 92);
            this.gridControlNhaMay.MainView = this.gridViewNhaMay;
            this.gridControlNhaMay.MenuManager = this.ribbonControl;
            this.gridControlNhaMay.Name = "gridControlNhaMay";
            this.gridControlNhaMay.Size = new System.Drawing.Size(236, 200);
            this.gridControlNhaMay.TabIndex = 10;
            this.gridControlNhaMay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNhaMay});
            // 
            // gridViewNhaMay
            // 
            this.gridViewNhaMay.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NHAMAY});
            this.gridViewNhaMay.GridControl = this.gridControlNhaMay;
            this.gridViewNhaMay.Name = "gridViewNhaMay";
            // 
            // NHAMAY
            // 
            this.NHAMAY.Caption = "Nhà Máy";
            this.NHAMAY.FieldName = "NHAMAY";
            this.NHAMAY.Name = "NHAMAY";
            this.NHAMAY.OptionsColumn.AllowEdit = false;
            this.NHAMAY.Visible = true;
            this.NHAMAY.VisibleIndex = 0;
            // 
            // txtNhaMay
            // 
            this.txtNhaMay.Location = new System.Drawing.Point(91, 47);
            this.txtNhaMay.MenuManager = this.ribbonControl;
            this.txtNhaMay.Name = "txtNhaMay";
            this.txtNhaMay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNhaMay.Properties.Appearance.Options.UseFont = true;
            this.txtNhaMay.Size = new System.Drawing.Size(145, 22);
            this.txtNhaMay.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhà Máy:";
            // 
            // FrmNhaMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 365);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gridControlNhaMay);
            this.Controls.Add(this.txtNhaMay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNhaMay";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL Nhà Máy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNhaMay_FormClosing);
            this.Load += new System.EventHandler(this.FrmNhaMay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhaMay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhaMay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaMay.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.GridControl gridControlNhaMay;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNhaMay;
        private DevExpress.XtraGrid.Columns.GridColumn NHAMAY;
        private DevExpress.XtraEditors.TextEdit txtNhaMay;
        private System.Windows.Forms.Label label1;
    }
}