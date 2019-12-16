using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiIndexers
{
    public class PeopleCollection
    {
        private DataTable _table;
        public PeopleCollection(DataTable table) { _table = table; }

        public string this[int index, string name]
        {
            get
            {
                var columns = _table.Columns;
                int j = columns[name].Ordinal;
                return _table.Rows[index][j].ToString();
            }
        }
    }
}
