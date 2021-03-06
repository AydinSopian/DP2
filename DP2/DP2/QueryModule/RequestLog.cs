﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace DP2
{
    class RequestLog
    {
        private static RequestLog instance = null;

        private MySqlConnection dbConnect;
        private string connectionString;
        private MySqlDataAdapter adp;
        private MySqlCommand command;

        private QueryBuilderFactory qFactory;
        private QueryDirector qDirector;
        private string query;

        public string GetQuery()
        {
            return query;
        }

        private RequestLog()
        {
            qFactory = new QueryBuilderFactory();
            connectionString = "datasource=35.198.212.34;port=3306;username=root;password=;database=dp2;sslmode=none";
            dbConnect = new MySqlConnection(connectionString);
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
        public DataTable RunSelectQuery(string tables, string columns, string condition)
        {
            DataTable dt = new DataTable();
            qDirector = new QueryDirector(new SelectQueryBuilder());
            qDirector.MakeQuery(tables, columns, condition, "");

            query = qDirector.GetQuery;

            try
            {
                using (dbConnect)
                using (command = new MySqlCommand(query, dbConnect))
                using (adp = new MySqlDataAdapter(command))
                {
                    dbConnect.Open();
                    adp.Fill(dt);
                    dbConnect.Close();
                }

                return dt;
            }
            catch (Exception e)
            {
                UIComponents.UIError error = new UIComponents.UIError("Error, could not connect to server", "OK");
                error.ShowDialog();
                MessageBox.Show(query);
            }

            return null;
        }

        public void RunQuery(int queryId, string tables, string columns, string condition, string values)
        {
            qDirector = new QueryDirector(qFactory.CreateQueryBuilder(queryId));

            qDirector.MakeQuery(tables, columns, condition, values);

            query = qDirector.GetQuery;

            try
            {
                using (dbConnect)
                using (command = new MySqlCommand(query, dbConnect))
                {
                    dbConnect.Open();
                    command.ExecuteNonQuery();
                    dbConnect.Close();
                }
            }
            catch (Exception e)
            {
                UIComponents.UIError error = new UIComponents.UIError("Error, could not connect to server", "OK");
                error.ShowDialog();
                MessageBox.Show(query);
            }
        }

    }
}
