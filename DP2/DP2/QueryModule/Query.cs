using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2
{
    class Query : IQueryPlan
    {
        private string queryKeyword, queryTables, queryValues, queryColumns, queryWhere;

        public void SetColumns(string columns)
        {
            queryColumns = columns;
        }

        public string QueryColumns
        {
            get { return this.queryColumns; }
        }

        public void SetWhere(string where)
        {
            queryWhere = where;
        }

        public string QueryWhere
        {
            get { return this.queryWhere; }
        }

        public void SetKeyword(string keyword)
        {
            queryKeyword = keyword;
        }

        public string QueryKeyword
        {
            get { return this.queryKeyword; }
        }

        public void SetTables(string tables)
        {
            queryTables = tables;
        }

        public string QueryTables
        {
            get { return this.queryTables; }
        }

        public void SetValues(string values)
        {
            queryValues = values;
        }

        public string QueryValues
        {
            get { return this.queryValues; }
        }
    }
}
