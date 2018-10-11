using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2
{
    /// <summary>
    /// QueryBuilder factory.
    /// </summary>
    class QueryBuilderFactory
    {
        /// <summary>
        /// Method that return QueryBuilder depending on user input.
        /// </summary>
        /// <param name="inputId"></param>
        /// <returns></returns>
        public IQueryBuilder CreateQueryBuilder(int inputId)
        {
            switch (inputId)
            {
                case 1: return new SelectQueryBuilder();
                case 2: return new DeleteQueryBuilder();
                case 3: return new InsertQueryBuilder();
                case 4: return new UpdateQueryBuilder();
            }

            return null;
        }
    }
}
