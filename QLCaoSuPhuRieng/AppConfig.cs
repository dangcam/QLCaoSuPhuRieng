using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCaoSuPhuRieng
{
    class AppConfig
    {
        public static string username = "";
        public static string password = "";
        public static string role_user = "";
        public static string code_user = "";
        public static string servername = "";
        public static string database = "";
        public static string Database
        {
            get
            {
                return database;
            }
            set
            {
                database = value;
            }
        }
        public static string ServerName
        {
            get
            {
                return servername;
            }
            set
            {
                servername = value;
            }
        }
        public static string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public static string Code_user
        {
            get
            {
                return code_user;
            }
            set
            {
                code_user = value;
            }
        }
        public static string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public static string Role_user
        {
            get
            {
                return role_user;
            }
            set
            {
                role_user = value;
            }
        }
    }
}
