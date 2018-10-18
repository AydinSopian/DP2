using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace DP2
{
    class RequestLog
    {
        private static RequestLog instance = null;

        private MySqlConnection dbConnect;
        private string connectionString;

        private DataSet output;

        private MySqlDataAdapter adp;

        private MySqlCommand command;

        private QueryBuilderFactory qFactory;

        private string query;
        public string GetQuery
        {
            get { return this.query; }
        }

        private RequestLog()
        {
            qFactory = new QueryBuilderFactory();
            connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dp2;";
            dbConnect = new MySqlConnection(connectionString);
            output = new DataSet();
        }

        /// <summary>
        /// RequestLog singleton instance getter
        /// </summary>
        /// <returns></returns>
        public static RequestLog Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RequestLog();
                }

                return instance;
            }
        }

        /// <summary>
        /// Runs the requested query
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tables"></param>
        /// <param name="columns"></param>
        /// <param name="condition"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public DataTable RunQuery(int id, string tables, string columns, string condition, string values)
        {
            DataTable dt = new DataTable();
            output.Clear();

            QueryDirector qDirector = new QueryDirector(qFactory.CreateQueryBuilder(id));

            qDirector.MakeQuery(tables, columns, condition, values);

            query = qDirector.GetQuery;

            //try
            //{
            using (dbConnect)
            using (command = new MySqlCommand(query, dbConnect))
            using (adp = new MySqlDataAdapter(command))
            {
                if (id == 1)
                {
                    adp.Fill(output, "outputData");
                }
                else
                {
                    dbConnect.Open();
                    command.ExecuteNonQuery();
                    dbConnect.Close();
                }
            }
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show("Error, could not connect to server");
            //}

            dt = output.Tables["outputData"];

            return dt;
        }

    }
}
