using System;
using System.Collections.Generic;
namespace CapitalGainDBMigrationTool.TableClasses {
    class Table {

        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public List<TableAttribute> attributes = new List<TableAttribute>();

        public Table() { }
        
        //used for testing
        public Table(string name) {
            this.name = name;
        }

        public Table(string id, string name, string description) {
            this.id = id;
            this.name = name;
            this.description = description;
        }

        public void AddAttribute(TableAttribute newAttribute) {
            attributes.Add(newAttribute);
        }

        public void AddAttribute(string name, string type,
                        double size, char of,
                        string constraints, string description,
                        string domain, string comment,
                        string link, string mandatoryInMap,
                        string searchCriteria, string gridVisibility,
                        string shortDescription) {

            attributes.Add(new TableAttribute(name, type,
                        size, of,
                        constraints, description,
                        domain, comment,
                        link, mandatoryInMap,
                        searchCriteria, gridVisibility,
                        shortDescription));
        }

        public void AddAttribute(string[] attribute) {
            attributes.Add(new TableAttribute(attribute));
        }
    }
}
