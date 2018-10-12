using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2
{
    /// <summary>
    /// QueryBuilder blueprint interface.
    /// </summary>
    interface IQueryPlan
    {
        /// <summary>
        /// Sets the keyword of the query.
        /// </summary>
        /// <param name="keyword"></param>
        void SetKeyword(string keyword);

        /// <summary>
        /// Sets the tables to be queried.
        /// </summary>
        /// <param name="tables"></param>
        void SetTables(string tables);

        /// <summary>
        /// Sets values of the table to be edited/viewed etc.
        /// </summary>
        /// <param name="values"></param>
        void SetValues(string values);

        /// <summary>
        /// Sets the condition of the query.
        /// </summary>
        /// <param name="condition"></param>
        void SetWhere(string condition);

        /// <summary>
        /// Sets columns to be edited/viewed etc.
        /// </summary>
        /// <param name="columns"></param>
        void SetColumns(string columns);
    }
}
