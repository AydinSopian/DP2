using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2
{
    /// <summary>
    /// Director for QueryBuilders.
    /// </summary>
    class QueryDirector
    {
        /// <summary>
        /// QueryBuilder of the director (read-only property)
        /// </summary>
        private IQueryBuilder queryBuilder;
        public IQueryBuilder QueryBuilder
        {
            get { return this.queryBuilder; }
        }

        /// <summary>
        /// Director constructor.
        /// </summary>
        /// <param name="queryBuilder"></param>
        public QueryDirector(IQueryBuilder queryBuilder)
        {
            this.queryBuilder = queryBuilder;
        }

        public void MakeQuery(string tables, string columns, string condition, string values)
        {
            queryBuilder.BuildKeyword();
            queryBuilder.BuildTables(tables);

            if(!(queryBuilder is InsertQueryBuilder))
            {
                queryBuilder.BuildWhere(condition);
            }
            
            if(queryBuilder is SelectQueryBuilder)
            {
                queryBuilder.BuildColumns(columns);
            }

            if (queryBuilder is InsertQueryBuilder)
            {
                queryBuilder.BuildColumns(columns);
                queryBuilder.BuildValues(values);
            }

            if (queryBuilder is UpdateQueryBuilder)
            {
                queryBuilder.BuildValues(values);
            }

        }

        /// <summary>
        /// Returns a query.
        /// </summary>
        public string GetQuery
        {
            get { return this.queryBuilder.GetQuery(); }
        }
    }
}
