using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnectionClass sqlConnection = new SqlConnectionClass();
            SqlConnection sqlConnectionToMSSQL = new SqlConnection(sqlConnection.sqlConnectionString);
                        
            try
            {

                Console.Write("Establish connection to DB ... ");
                sqlConnectionToMSSQL.Open();
                Console.Write(" COMPLITE " + "\n");
                Console.ReadKey();

            }
            catch(Exception ex) {

                Console.Write("Error during establish connection to DB " + ex);
                Console.ReadKey();

            }

            //do something
            try {

                SqlCommand readAllDataFromDB = sqlConnectionToMSSQL.CreateCommand();
                readAllDataFromDB.CommandText ="SELECT * FROM DBForTests.dbo.HumanInfo";
                SqlDataReader dataReader = readAllDataFromDB.ExecuteReader();
                while (dataReader.Read()) {

                    Console.WriteLine(dataReader["Surname"]);

                }
                Console.ReadKey();

            }
            catch (SqlException sqex) {

                Console.WriteLine(sqex);

            }

            try
            {

                Console.Write("Closing connection to DB ... ");
                sqlConnectionToMSSQL.Close();
                Console.Write(" COMPLITE " + "\n");
                Console.ReadKey();

            }
            catch (Exception ex) {

                Console.Write("Error during closing connection to DB " + ex);
                Console.ReadKey();

            }
            
        }
    }
}
