using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DP2
{
    class RequestLog
    {
        private static RequestLog instance = null;

        private SqlConnection conn;
        private SqlDataAdapter adp;

        private QueryBuilderFactory qFactory;

        private string query;
        public string GetQuery
        {
            get { return this.query; }
        }

        private RequestLog()
        {
            //conn = new SqlConnection("ConnectionString");
            adp = new SqlDataAdapter();
            qFactory = new QueryBuilderFactory();
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
        /// Runs requested query
        /// </summary>
        public void RunQuery()
        {
            using (conn)
            using (adp)
            {

            }
        }

        /// <summary>
        /// Gets the user requested GetQuery
        /// </summary>
        /// <param name="id"></param>
        /// <param name="columnsCondition"></param>
        /// <param name="tables"></param>
        public void GetRequestedQuery(int id, string columnsCondition, string tables)
        {
            QueryDirector qDirector = new QueryDirector(qFactory.CreateQueryBuilder(id));

            qDirector.MakeQuery(tables, columnsCondition);

            query = qDirector.GetQuery;
        }

        /// <summary>
        /// Gets the user requested GetQuery
        /// </summary>
        /// <param name="id"></param>
        /// <param name="columnsCondition"></param>
        /// <param name="tables"></param>
        public void GetRequestedQuery(int id, string tables, string columnsCondition, string values)
        {
            QueryDirector qDirector = new QueryDirector(qFactory.CreateQueryBuilder(id));

            qDirector.MakeQuery(tables, columnsCondition, values);

            query = qDirector.GetQuery;
        }

    }
}
