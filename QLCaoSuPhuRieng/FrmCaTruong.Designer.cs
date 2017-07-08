namespace QLCaoSuPhuRieng
{
    partial class FrmCaTruong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaTruong));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlCaTruong = new DevExpress.XtraGrid.GridControl();
            this.gridViewCaTruong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CATRUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCaTruong = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCaTruong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCaTruong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaTruong.Properties)).BeginInit();
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
            this.btnXoa.Location = new System.Drawing.Point(147, 317);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 26);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(50, 317);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 26);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gridControlCaTruong
            // 
            this.gridControlCaTruong.Location = new System.Drawing.Point(13, 93);
            this.gridControlCaTruong.MainView = this.gridViewCaTruong;
            this.gridControlCaTruong.MenuManager = this.ribbonControl;
            this.gridControlCaTruong.Name = "gridControlCaTruong";
            this.gridControlCaTruong.Size = new System.Drawing.Size(236, 200);
            this.gridControlCaTruong.TabIndex = 10;
            this.gridControlCaTruong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCaTruong});
            // 
            // gridViewCaTruong
            // 
            this.gridViewCaTruong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CATRUONG});
            this.gridViewCaTruong.GridControl = this.gridControlCaTruong;
            this.gridViewCaTruong.Name = "gridViewCaTruong";
            // 
            // CATRUONG
            // 
            this.CATRUONG.Caption = "Ca Trưởng";
            this.CATRUONG.FieldName = "CATRUONG";
            this.CATRUONG.Name = "CATRUONG";
            this.CATRUONG.OptionsColumn.AllowEdit = false;
            this.CATRUONG.Visible = true;
            this.CATRUONG.VisibleIndex = 0;
            // 
            // txtCaTruong
            // 
            this.txtCaTruong.Location = new System.Drawing.Point(99, 48);
            this.txtCaTruong.MenuManager = this.ribbonControl;
            this.txtCaTruong.Name = "txtCaTruong";
            this.txtCaTruong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCaTruong.Properties.Appearance.Options.UseFont = true;
            this.txtCaTruong.Size = new System.Drawing.Size(145, 22);
            this.txtCaTruong.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ca Trưởng:";
            // 
            // FrmCaTruong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 365);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gridControlCaTruong);
            this.Controls.Add(this.txtCaTruong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCaTruong";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ca Trưởng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCaTruong_FormClosing);
            this.Load += new System.EventHandler(this.FrmCaTruong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCaTruong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCaTruong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaTruong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.GridControl gridControlCaTruong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCaTruong;
        private DevExpress.XtraEditors.TextEdit txtCaTruong;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn CATRUONG;
    }
}