using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CapitalGainDBMigrationTool.TableItems {
    //TODO: Add constraints on attributes on items to insure that they are not null
    class TableItem {
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

        public TableItem() { }

        public TableItem(string name, string type, 
                        double size, char of, 
                        string constraints, string description, 
                        string domain, string comment, 
                        string link, string mandatoryInMap,
                        string searchCriteria, string gridVisibility,
                        string shortDescription) {
            this.name = name;
            this.type = type;
            this.size = size;
            this.of = of;
            this.constraints = constraints;
            this.description = description;
            this.domain = domain;
            this.comment = comment;
            this.link = link;
            this.mandatoryInMap = mandatoryInMap;
            this.searchCriteria = searchCriteria;
            this.gridVisibility = gridVisibility;
            this.shortDescription = shortDescription;
        }

    }
}
