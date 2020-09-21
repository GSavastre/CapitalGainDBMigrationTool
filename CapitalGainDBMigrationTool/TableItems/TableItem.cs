using System;

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

        public TableItem(string name="", string type="", 
                        double size = 0, char of = ' ', 
                        string constraints="", string description="", 
                        string domain="", string comment="", 
                        string link = "", string mandatoryInMap = "",
                        string searchCriteria = "", string gridVisibility = "",
                        string shortDescription = "") {
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

        public TableItem(string[] items) {
            this.name = items[0];
            this.type = items[1];
            if (string.IsNullOrWhiteSpace(items[2])) {
                this.size = -1;
            } else if (items[2] == "MAX") {
                this.size = 999999;
            } else {
                this.size = Convert.ToDouble(items[2]);
            }

            if (string.IsNullOrEmpty(items[3])) {
                this.of = ' ';
            } else {
                this.of = Convert.ToChar(items[3]);
            }

            this.constraints = items[4];
            this.description = items[5];
            this.domain = items[6];
            this.comment = items[7];
            this.link = items[8];
            this.mandatoryInMap = items[9];
            this.searchCriteria = items[10];
            this.gridVisibility = items[11];
            this.shortDescription = items[12];
        }

    }
}
