using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2
{
    class SelectQueryBuilder : IQueryBuilder
    {
        private Query query;

        public SelectQueryBuilder()
        {
            query = new Query();
        }

        public void BuildColumns(string columns)
        {
            query.SetColumns(columns);
        }

        public void BuildWhere(string condition)
        {
            if(condition.Length > 0)
            {
                query.SetWhere(" WHERE " + condition);
            }
            else
            {
                query.SetWhere("");
            }
            
        }

        public void BuildKeyword()
        {
            query.SetKeyword("SELECT ");
        }

        public void BuildTables(string tables)
        {
            query.SetTables(" FROM " + tables);
        }

        public void BuildValues(string values)
        {
            throw new NotImplementedException(); 
        }

        public string GetQuery()
        {
            return query.GetKeyword + query.GetColumns + query.GetTables + query.GetWhere;
        }

    }
}
