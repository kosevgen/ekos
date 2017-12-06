//
//
//

using System;
using System.Data.SqlClient;


namespace DBTest
{
    public class PublicConnectionToMSDB
    {
        public string connectionString ;

        public PublicConnectionToMSDB() {

            connectionString = @"Data Source = 192.168.250.200; Initial Catalog = DBForTests; Persist Security Info=True;User ID= sa; Password= ASDqwe!@#;";

        }

        public PublicConnectionToMSDB(string dataSource)
        {

            connectionString = @"Data Source = " + dataSource +"; Initial Catalog = DBForTests; Persist Security Info=True;User ID= sa; Password= ASDqwe!@#;";

        }

        public PublicConnectionToMSDB(string dataSource, string initialCatalog)
        {

            connectionString = @"Data Source = " + dataSource + "; Initial Catalog = " + initialCatalog + "; Persist Security Info=True;User ID= sa; Password= ASDqwe!@#;";

        }

        public PublicConnectionToMSDB(string dataSource, string initialCatalog, string persistSecuritiInfo, string userName , string password) {

            connectionString = @"Data Source = " + dataSource + "; Initial Catalog = " + initialCatalog + "; Persist Security Info = " + persistSecuritiInfo + ";User ID= " + userName + "; Password= " + password + ";";

        }



        public SqlConnection ConnectionToMSDB()
        {

            SqlConnection connectionToDB = new SqlConnection(connectionString);
            return connectionToDB;

        }


    }
}
