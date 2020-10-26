using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitalGainDBMigrationTool.MappingClasses
{
    class Menu
    {
        /*[BsonId]
        public ObjectId id;
        [BsonElement("NOME")]
        public string nome;
        [BsonElement("VOCI")]
        public List<SubMenu> voci = new List<SubMenu>();

        public Menu() { }

        public Menu(string _menu) {
            nome = _menu;
        }

        public Menu(string _menu, List<SubMenu> _subMenus) {
            nome = _menu;
            foreach (SubMenu _s in _subMenus) {
                voci.Add(_s);
            }
        }*/

        [BsonId]
        public ObjectId Id;

        [BsonElement("NOME")]
        public string nome;

        [BsonElement("DESCR_SELETTORE")]
        public string descrSelettore;

        [BsonElement("DESCR_TRANSAZIONE")]
        public string descrTransazione;

        [BsonElement("LINK")]
        public string link;

        [BsonElement("LINK_ACTION")]
        public string action;

        [BsonElement("LINK_CONTROLLER")]
        public string controller;

        [BsonElement("QUICK_LAUNCH")]
        public string quickL;

        [BsonElement("ORDINAMENTO")]
        public int order;

        [BsonElement("VOCI")]
        public List<MenuChild> children;

        public Menu(string nome, string descrSelettore, string descrTransazione, 
            string link, string action, string controller, string quickL, int order ) {

            this.nome = nome;
            this.descrSelettore = descrSelettore;
            this.descrTransazione = descrTransazione;
            this.link = link;
            this.action = action;
            this.controller = controller;
            this.quickL = quickL;
            this.order = order;
        }

    }
}
