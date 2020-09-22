using System;

namespace CapitalGainDBMigrationTool.TableClasses {
    //TODO: Add constraints on attributes on attributes to insure that they are not null
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

        public TableAttribute(string name="", string type="", 
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

        public TableAttribute(string[] attributes) {
            this.name = attributes[0];
            this.type = attributes[1];
            if (string.IsNullOrWhiteSpace(attributes[2])) {
                this.size = -1;
            } else if (attributes[2] == "MAX") {
                this.size = 999999;
            } else {
                this.size = Convert.ToDouble(attributes[2]);
            }

            if (string.IsNullOrEmpty(attributes[3])) {
                this.of = ' ';
            } else {
                this.of = Convert.ToChar(attributes[3]);
            }

            this.constraints = attributes[4];
            this.description = attributes[5];
            this.domain = attributes[6];
            this.comment = attributes[7];
            this.link = attributes[8];
            this.mandatoryInMap = attributes[9];
            this.searchCriteria = attributes[10];
            this.gridVisibility = attributes[11];
            this.shortDescription = attributes[12];
        }

    }
}
