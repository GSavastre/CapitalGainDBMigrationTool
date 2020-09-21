using System;
using System.Collections.Generic;
using System.Text;

namespace CapitalGainDBMigrationTool.TableItems {
    class Table {

        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public List<TableItem> items = new List<TableItem>();

        public Table() { }
        
        //used for testing
        public Table(string name) {
            this.name = name;
        }

        public void AddItem(TableItem newItem) {
            items.Add(newItem);
        }

        public void AddItem(string name, string type,
                        double size, char of,
                        string constraints, string description,
                        string domain, string comment,
                        string link, string mandatoryInMap,
                        string searchCriteria, string gridVisibility,
                        string shortDescription) {

            items.Add(new TableItem(name, type,
                        size, of,
                        constraints, description,
                        domain, comment,
                        link, mandatoryInMap,
                        searchCriteria, gridVisibility,
                        shortDescription));
        }
    }
}
