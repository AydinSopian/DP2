using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2
{
    class InsertQueryBuilder : IQueryBuilder
    {
        private Query query;

        public InsertQueryBuilder()
        {
            query = new Query();
        }

        public void BuildKeyword()
        {
            query.SetKeyword("INSERT INTO ");
        }

        public void BuildColumns(string columns)
        {
            query.SetColumns("(" + columns + ")");
        }

        public void BuildWhere(string condition)
        {
            throw new NotImplementedException();
        }

        public void BuildTables(string tables)
        {
            query.SetTables(tables + " ");
        }

        public void BuildValues(string values)
        {
            query.SetValues(" VALUES (" + values + ")");
        }

        public string GetQuery()
        {
            return query.QueryKeyword + query.QueryTables + query.QueryColumns + query.QueryValues;
        }
    }
}
