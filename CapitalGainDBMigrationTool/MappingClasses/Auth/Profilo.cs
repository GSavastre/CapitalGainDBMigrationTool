using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitalGainDBMigrationTool.MappingClasses
{
    class Profilo
    {
        [BsonId]
        public ObjectId Id;
        [BsonElement("DESCR_PROFILO")]
        public string descrizione;
        [BsonElement("MENU")]
        public List<SubMenu> menu;
    }

    class SubMenu {
        [BsonId]
        public ObjectId Id;
        [BsonElement("SOTTOVOCI")]
        public List<ObjectId> sottovoci;
    }
}
