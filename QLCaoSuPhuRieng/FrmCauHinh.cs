using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCaoSuPhuRieng
{
    public partial class FrmCauHinh : RibbonForm
    {
        ReadConfig readConfig;
        public FrmCauHinh()
        {
            InitializeComponent();
            readConfig = new ReadConfig();
        }

        private void FrmCauHinh_Load(object sender, EventArgs e)
        {
            txtServerName.Text = AppConfig.ServerName;
            txtDatabaseName.Text = AppConfig.Database;
            txtLogin.Text = AppConfig.Username;
            txtPassword.Text = AppConfig.Password;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            AppConfig.ServerName = txtServerName.Text;
            AppConfig.Database = txtDatabaseName.Text;
            AppConfig.Username = txtLogin.Text;
            AppConfig.Password = txtPassword.Text;
            readConfig.Write();
        }
    }
}
