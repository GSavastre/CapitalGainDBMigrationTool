using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitalGainDBMigrationTool
{
    class Utente
    {
        [BsonId]
        public string id { get; }
        [BsonElement("USERID")]
        public string userId { get; set; }
        [BsonElement("PASSWORD")]
        public string password { get; set; }
        [BsonElement("DESCRIZIONE")]
        public string descrizione { get; set; }
        [BsonElement("ISTITUTO")]
        public string istituto { get; set; }
    }
}
