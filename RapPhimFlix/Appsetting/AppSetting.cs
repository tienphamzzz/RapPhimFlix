using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RapPhimFlix.Appsetting
{
    public class AppSetting
    {
        public static string ConnectionString = "Data Source=LAPTOP-A56O33LS\\SQLEXPRESS;Initial Catalog=QLCinema;Integrated Security=True";
        public static string Admin { get; } = "Admin123";
        public static string Password { get; } = "Admin123";
        public bool checkAdmin(string username, string password)
        {
            if (username == null || password == null) return false;
            if (username != Admin) return false;
            if (password != Password) return false;
            return true;
        }
        public static int VaiTro = -1; // 0 là Admin
        public static string UserName {  get; set; }

    }
}
