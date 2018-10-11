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

        public void MakeQuery(string columnsCondition, string tables)
        {
            queryBuilder.BuildKeyword();
            queryBuilder.BuildTables(tables);

            if(queryBuilder is SelectQueryBuilder)
            {
                queryBuilder.BuildColumns(columnsCondition);
            }
            else if(queryBuilder is DeleteQueryBuilder)
            {
                queryBuilder.BuildWhere(columnsCondition);
            }
        }

        public void MakeQuery(string tables, string columnsCondition, string values)
        {
            queryBuilder.BuildKeyword();
            queryBuilder.BuildTables(tables);
            queryBuilder.BuildValues(values);

            if (queryBuilder is InsertQueryBuilder)
            {
                queryBuilder.BuildColumns(columnsCondition);
            }
            else if(queryBuilder is UpdateQueryBuilder)
            {
                queryBuilder.BuildWhere(columnsCondition);
            }
        }

        /// <summary>
        /// Returns a query.
        /// </summary>
        public string Query
        {
            get { return this.queryBuilder.GetQuery(); }
        }
    }
}
