using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2
{
    class DeleteQueryBuilder : IQueryBuilder
    {
        private Query query;

        public DeleteQueryBuilder()
        {
            query = new Query();
        }

        public void BuildColumns(string columns)
        {
            throw new NotImplementedException();
        }

        public void BuildWhere(string condition)
        {
            query.SetWhere("WHERE " + condition);
        }

        public void BuildKeyword()
        {
            query.SetKeyword("DELETE FROM ");
        }

        public void BuildTables(string tables)
        {
            query.SetTables(tables);
        }

        public void BuildValues(string values)
        {
            throw new NotImplementedException();
        }

        public string GetQuery()
        {
            return query.GetKeyword + query.GetTables + query.GetWhere;
        }
    }
}
