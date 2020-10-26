using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitalGainDBMigrationTool.MappingClasses
{
    public class WCAP_JTGTT002
    {
        [BsonId]
        public ObjectId id;
        [BsonElement("IST")]
        public int ist;
        [BsonElement("SOGG_FISC")]
        public string sogg_fisc;
        [BsonElement("GAIN")]
        public DateTime gain;
        [BsonElement("TIPO_SOGG")]
        public string tipo_sogg;
        [BsonElement("D_INS")]
        public DateTime d_ins;
        [BsonElement("X_INS")]
        public string x_ins;
        [BsonElement("X_AGG")]
        public string x_agg;
    }
}
