using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2
{
    class Table
    {
        private string tableName;
        private List<string> columnNames;

        public Table(string tableName, List<string> columnNames)
        {
            this.tableName = tableName;
            this.columnNames = columnNames;
        }

        public string GetTableName()
        {
            return tableName;
        }

        public List<string> GetColumnNames()
        {
            return columnNames;
        }
    }
}
