using System;
using System.Collections.Generic;
using System.Text;

namespace CapitalGainDBMigrationTool.TableItems {
    class Table {

        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        List<TableAttribute> attributes = new List<TableAttribute>();

        public Table() { }
    }
}
