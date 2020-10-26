using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitalGainDBMigrationTool.MappingClasses
{
    class MenuChild
    {
        [BsonId]
        public ObjectId Id;

        [BsonElement("NOME")]
        public string Nome;

        [BsonElement("COMANDO")]
        public string Comando;

        [BsonElement("DESCRIZIONE")]
        public string Descrizione;

        [BsonElement("CONTROLLER")]
        public string Controller;

        [BsonElement("ACTION")]
        public string Action;

        [BsonElement("GRANT_LEVEL")]
        public string GrantLevel;

        [BsonElement("VOCI")]
        public List<MenuChild> Children;

        public MenuChild(string nome, string comando, string descrizione, string controller, string action, string grantLevel)
        {
            Nome = nome;
            Comando = comando;
            Descrizione = descrizione;
            Controller = controller;
            Action = action;
            GrantLevel = grantLevel;
            Children = new List<MenuChild>();
            
        }
    }
}
