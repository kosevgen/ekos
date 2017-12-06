//!!!Class is not used!!!

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTest
{

    class TestDBStructure
    {

        //Тут буде клас, який тестить чи присутня на сервері база даних "DBForTests"
        // Чи є в тій базі таблиці, а в таблицях певна інформація

        PublicConnectionToMSDB publicConnection = new PublicConnectionToMSDB();
        SqlConnection conn = publicConnection.ConnectionToMSDB();






    }

}
       


