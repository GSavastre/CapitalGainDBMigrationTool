using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitalGainDBMigrationTool.MappingClasses
{
    class WCAP_JTITT270
    {
        [BsonId]
        public ObjectId id;
        [BsonElement("IST")]
        public int ist;
        [BsonElement("NDG")]
        public string ndg;
        [BsonElement("RESIDENTE")]
        public string residente;
        [BsonElement("PAE_UIC")]
        public int pae_uic;
        [BsonElement("SETTORE")]
        public int settore;
        [BsonElement("RAMO")]
        public int ramo;
        [BsonElement("NAT_GIUR")]
        public string nat_giur;
        [BsonElement("RAP")]
        public string rap;
        [BsonElement("DES_RAP")]
        public string des_rap;
        [BsonElement("REGIME")]
        public string regime;
        [BsonElement("COMPENSA")]
        public string compensa;
        [BsonElement("QUALIF")]
        public string qualif;
        [BsonElement("DECOR")]
        public DateTime decor;
        [BsonElement("MOVIMENTA")]
        public string movimenta;
        [BsonElement("ESERCIZIO")]
        public DateTime esercizio;
        [BsonElement("D_INS")]
        public DateTime d_ins;
        [BsonElement("X_INS")]
        public string x_ins;
        [BsonElement("X_AGG")]
        public string x_agg;
    }
}
