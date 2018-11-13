using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2
{
    class Query : IQueryPlan
    {
        private string keyword, tables, values, columns, where;

        public void SetColumns(string columns)
        {
            this.columns = columns;
        }

        public string GetColumns
        {
            get { return this.columns; }
        }

        public void SetWhere(string where)
        {
            this.where = where;
        }

        public string GetWhere
        {
            get { return this.where; }
        }

        public void SetKeyword(string keyword)
        {
            this.keyword = keyword;
        }

        public string GetKeyword
        {
            get { return this.keyword; }
        }

        public void SetTables(string tables)
        {
            this.tables = tables;
        }

        public string GetTables
        {
            get { return this.tables; }
        }

        public void SetValues(string values)
        {
            this.values = values;
        }

        public string GetValues
        {
            get { return this.values; }
        }
    }
}
