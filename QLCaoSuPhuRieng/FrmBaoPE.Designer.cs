namespace QLCaoSuPhuRieng
{
    partial class FrmBaoPE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoPE));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlBaoPE = new DevExpress.XtraGrid.GridControl();
            this.gridViewBaoPE = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BAOPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtBaoPE = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBaoPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBaoPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaoPE.Properties)).BeginInit();
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
            this.btnXoa.Location = new System.Drawing.Point(147, 318);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 26);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(50, 318);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 26);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gridControlBaoPE
            // 
            this.gridControlBaoPE.Location = new System.Drawing.Point(13, 94);
            this.gridControlBaoPE.MainView = this.gridViewBaoPE;
            this.gridControlBaoPE.MenuManager = this.ribbonControl;
            this.gridControlBaoPE.Name = "gridControlBaoPE";
            this.gridControlBaoPE.Size = new System.Drawing.Size(236, 200);
            this.gridControlBaoPE.TabIndex = 10;
            this.gridControlBaoPE.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBaoPE});
            // 
            // gridViewBaoPE
            // 
            this.gridViewBaoPE.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BAOPE});
            this.gridViewBaoPE.GridControl = this.gridControlBaoPE;
            this.gridViewBaoPE.Name = "gridViewBaoPE";
            // 
            // BAOPE
            // 
            this.BAOPE.Caption = "BAOPE";
            this.BAOPE.FieldName = "BAOPE";
            this.BAOPE.Name = "BAOPE";
            this.BAOPE.OptionsColumn.AllowEdit = false;
            this.BAOPE.Visible = true;
            this.BAOPE.VisibleIndex = 0;
            // 
            // txtBaoPE
            // 
            this.txtBaoPE.Location = new System.Drawing.Point(91, 49);
            this.txtBaoPE.MenuManager = this.ribbonControl;
            this.txtBaoPE.Name = "txtBaoPE";
            this.txtBaoPE.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBaoPE.Properties.Appearance.Options.UseFont = true;
            this.txtBaoPE.Size = new System.Drawing.Size(145, 22);
            this.txtBaoPE.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(35, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "BaoPE:";
            // 
            // FrmBaoPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 365);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gridControlBaoPE);
            this.Controls.Add(this.txtBaoPE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBaoPE";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaoPE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBaoPE_FormClosing);
            this.Load += new System.EventHandler(this.FrmBaoPE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBaoPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBaoPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaoPE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.GridControl gridControlBaoPE;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBaoPE;
        private DevExpress.XtraGrid.Columns.GridColumn BAOPE;
        private DevExpress.XtraEditors.TextEdit txtBaoPE;
        private System.Windows.Forms.Label label1;
    }
}