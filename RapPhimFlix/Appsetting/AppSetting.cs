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
        public static string ConnectionString = "Data Source=DESKTOP-F97LING\\SQLEXPRESS;Initial Catalog=QLCinema;Integrated Security=True";
        
        public static int VaiTro = -1;
    }
}
