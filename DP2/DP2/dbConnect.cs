using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DP2
{
    class dbConnect
    {
        public dbConnect()
        {

        }

        public void runQuery(string queryEntered)
        {
            string query = queryEntered;

            if (query == "")
            {
                Console.WriteLine("Please insert some SQL query");
                return;
            }

            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kuhchingtest;sslmode=none";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    Console.WriteLine("Your query generated results, please see the console");
                    while (myReader.Read())
                    {
                        for (int x = 0; x < myReader.FieldCount; x++)
                        {
                            Console.WriteLine(myReader.GetString(x) + " - ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Query successfully executed");
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Query error " + e.Message);
            }
        }
    }
}
