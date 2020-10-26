using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitalGainDBMigrationTool.MappingClasses
{
    public class WCAP_JTGTT005
    {
        [BsonId]
        public ObjectId id;
        [BsonElement("IST")]
        public int ist;
        [BsonElement("REG")]
        public DateTime reg;
        [BsonElement("COMPETEN")]
        public string competen;
        [BsonElement("REGIME")]
        public string regime;
        [BsonElement("IMPOSTA")]
        public double imposta;
        [BsonElement("IMPOSTA_S")]
        public double imposta_s;
        [BsonElement("REGOLARE")]
        public string regolare;
        [BsonElement("F_STATO")]
        public string f_stato;
        [BsonElement("D_STATO")]
        public DateTime d_stato;
        [BsonElement("X_INS")]
        public string x_ins;
        [BsonElement("X_AGG")]
        public string x_agg;
    }
}
