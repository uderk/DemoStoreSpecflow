using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DemoStoreSpecflowProject.Support
{
    public class DBhelper
    {
        public string connString = "server=localhost;uid=root;pwd=root;database=local";
        public MySqlConnection myConnection = new MySqlConnection();
        public DBhelper()
        {
            myConnection.ConnectionString = connString;
            myConnection.Open();
        }

       

    }

}
