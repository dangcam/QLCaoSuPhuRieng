namespace QLCaoSuPhuRieng
{
    partial class FrmCaSX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaSX));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlCaSX = new DevExpress.XtraGrid.GridControl();
            this.gridViewCaSX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CATRUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCaSX = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCaSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCaSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaSX.Properties)).BeginInit();
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
            this.btnXoa.Location = new System.Drawing.Point(147, 314);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 26);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(50, 314);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 26);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gridControlCaSX
            // 
            this.gridControlCaSX.Location = new System.Drawing.Point(13, 90);
            this.gridControlCaSX.MainView = this.gridViewCaSX;
            this.gridControlCaSX.MenuManager = this.ribbonControl;
            this.gridControlCaSX.Name = "gridControlCaSX";
            this.gridControlCaSX.Size = new System.Drawing.Size(236, 200);
            this.gridControlCaSX.TabIndex = 15;
            this.gridControlCaSX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCaSX});
            // 
            // gridViewCaSX
            // 
            this.gridViewCaSX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CATRUONG});
            this.gridViewCaSX.GridControl = this.gridControlCaSX;
            this.gridViewCaSX.Name = "gridViewCaSX";
            // 
            // CATRUONG
            // 
            this.CATRUONG.Caption = "Ca SX";
            this.CATRUONG.FieldName = "CASX";
            this.CATRUONG.Name = "CASX";
            this.CATRUONG.OptionsColumn.AllowEdit = false;
            this.CATRUONG.Visible = true;
            this.CATRUONG.VisibleIndex = 0;
            // 
            // txtCaSX
            // 
            this.txtCaSX.Location = new System.Drawing.Point(94, 45);
            this.txtCaSX.MenuManager = this.ribbonControl;
            this.txtCaSX.Name = "txtCaSX";
            this.txtCaSX.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCaSX.Properties.Appearance.Options.UseFont = true;
            this.txtCaSX.Size = new System.Drawing.Size(145, 22);
            this.txtCaSX.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(31, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ca SX:";
            // 
            // FrmCaSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 365);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gridControlCaSX);
            this.Controls.Add(this.txtCaSX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCaSX";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ca Sản Xuất";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCaSX_FormClosing);
            this.Load += new System.EventHandler(this.FrmCaSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCaSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCaSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaSX.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.GridControl gridControlCaSX;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCaSX;
        private DevExpress.XtraGrid.Columns.GridColumn CATRUONG;
        private DevExpress.XtraEditors.TextEdit txtCaSX;
        private System.Windows.Forms.Label label1;
    }
}