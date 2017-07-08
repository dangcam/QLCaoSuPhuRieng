using DevExpress.XtraEditors;
using System.Xml;


namespace QLCaoSuPhuRieng
{
  
    class ReadConfig
    {
        XmlDocument xmlfile;
        public void Read()
        {
            xmlfile = new XmlDocument();
            xmlfile.Load("config.xml");
            AppConfig.ServerName = xmlfile.SelectSingleNode("config/server").InnerText.ToString();
            AppConfig.Database = xmlfile.SelectSingleNode("config/batabase").InnerText.ToString();
            AppConfig.Username = xmlfile.SelectSingleNode("config/user").InnerText.ToString();
            AppConfig.Password = xmlfile.SelectSingleNode("config/password").InnerText.ToString();
            AppConfig.Role_user = xmlfile.SelectSingleNode("config/role").InnerText.ToString();
        }
        public void Write()
        {
            xmlfile = new XmlDocument();
            xmlfile.Load("config.xml");
            xmlfile.SelectSingleNode("config/server").InnerText = AppConfig.ServerName;
            xmlfile.SelectSingleNode("config/batabase").InnerText = AppConfig.Database;
            xmlfile.SelectSingleNode("config/user").InnerText = AppConfig.Username;
            xmlfile.SelectSingleNode("config/password").InnerText = AppConfig.Password;
            xmlfile.SelectSingleNode("config/role").InnerText = AppConfig.Role_user;
            xmlfile.Save("config.xml");
            
        }
    }
}
