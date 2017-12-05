using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTest
{
    class publicConnectionToMSDB
    {

        public static string connectionString = @"Data Source = 192.168.250.200; Initial Catalog = DBForTests; Persist Security Info=True;User ID= sa; Password= ASDqwe!@#;"; 

        public System.Data.SqlClient.SqlConnection connectionToMSDB()
        {

            System.Data.SqlClient.SqlConnection connectionToDB = new System.Data.SqlClient.SqlConnection(connectionString);
            return connectionToDB;

        }

        

    }
}
