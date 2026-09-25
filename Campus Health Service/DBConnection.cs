using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Campus_Health_Service
{
    public class DBConnection
    {
        private string connectionString =
          "server=localhost;" +
          "database=Campushealthservice;" +
          "uid=root;" +
          "pwd=";



        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
