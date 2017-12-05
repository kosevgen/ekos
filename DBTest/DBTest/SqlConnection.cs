using System.Data.SqlClient;

namespace DBTest
{

    public class SqlConnectionClass
    {

        static string datasource = "192.168.250.200";
        static string database = "DBForTests";
        static string username = "sa";
        static string password = "ASDqwe!@#";
        public string sqlConnectionString = @"Data Source=" + datasource + ";Initial Catalog="
                    + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
                       
    }

}
       


