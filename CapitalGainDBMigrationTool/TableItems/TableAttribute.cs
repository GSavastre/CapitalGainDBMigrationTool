using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CapitalGainDBMigrationTool.TableItems {
    class TableAttribute {
        public string name { get; set; }
        public string type { get; set; }
        public double size { get; set; }
        public char of { get; set; }
        public string constraints { get; set; }
        public string description{get; set;}
        public string domain { get; set; }
        public string comment { get; set; }
        public string link { get; set; }
        public string mandatoryInMap { get; set; }
        public string searchCriteria { get; set; }
        public string gridVisibility { get; set; }
        public string shortDescription { get; set; }

        public TableAttribute() { }

    }
}
