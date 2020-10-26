using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitalGainDBMigrationTool.MappingClasses
{
    class Istituto
    {
        [BsonId]
        public ObjectId Id;
        [BsonElement("CED")]
        public string ced;
        [BsonElement("ABI")]
        public string abi;
        [BsonElement("BIC")]
        public string bic;
        [BsonElement("DESCR_RIDOTTA")]
        public string descr_ridotta;
        [BsonElement("DESCR_ESTESA")]
        public string descr_estesa;
        [BsonElement("ESTINTO")]
        public bool estinto;
        [BsonElement("INFO_INSERIMENTO")]
        public string info_ridotta;
        [BsonElement("INFO_AGGIORNAMENTO")]
        public string info_estesa;
        [BsonElement("PROFILI")]
        public List<Profilo> profili;
    }
}
