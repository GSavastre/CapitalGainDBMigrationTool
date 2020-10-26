using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CapitalGainDBMigrationTool.MappingClasses
{
    class Autorizzazione
    {
        [BsonId]
        public ObjectId id;
        [BsonElement("NOME")]
        public string nome;
        [BsonElement("MENU")]
        public List<ObjectId> menu;
        public Autorizzazione() { }
    }
}
