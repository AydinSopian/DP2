using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2
{
    class UpdateQueryBuilder : IQueryBuilder
    {
        private Query query;

        public UpdateQueryBuilder()
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
            query.SetKeyword("UPDATE ");
        }

        public void BuildTables(string tables)
        {
            query.SetTables(tables);
        }

        public void BuildValues(string values)
        {
            query.SetValues(" SET " + values);
        }

        public string GetQuery()
        {
            return query.GetKeyword + query.GetTables + query.GetValues + query.GetWhere;
        }
    }
}
