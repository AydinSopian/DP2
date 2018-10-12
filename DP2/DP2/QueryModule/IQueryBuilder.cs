using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2
{
    /// <summary>
    /// Builder interface for QueryBuilders.
    /// </summary>
    interface IQueryBuilder
    {
        /// <summary>
        /// Builds query keyword.
        /// </summary>
        void BuildKeyword();

        /// <summary>
        /// Builds tables to be queried.
        /// </summary>
        /// <param name="tables"></param>
        void BuildTables(string tables);

        /// <summary>
        /// Builds values of the table to be edited/viewed etc.
        /// </summary>
        /// <param name="values"></param>
        void BuildValues(string values);

        /// <summary>
        /// Builds the condition of the query.
        /// </summary>
        /// <param name="condition"></param>
        void BuildWhere(string condition);

        /// <summary>
        /// Builds the columns to be edited/viewed etc.
        /// </summary>
        /// <param name="columns"></param>
        void BuildColumns(string columns);

        /// <summary>
        /// Builds the final query after being built.
        /// </summary>
        /// <returns></returns>
        string GetQuery();
    }
}
