using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitalGainDBMigrationTool.MappingClasses
{
    public class WCAP_JTITT272
    {
        [BsonElement("IST")]
        public int ist;
        [BsonElement("NDG")]
        public string ndg;
        [BsonElement("RAP")]
        public string rap;
        [BsonElement("DES_RAP")]
        public string des_rap;
        [BsonElement("DECOR")]
        public DateTime decor;
        [BsonElement("TIPO_REG")]
        public string tipo_reg;
        [BsonElement("CC_REG")]
        public string cc_reg;
        [BsonElement("X_INS")]
        public string x_ins;
        [BsonElement("X_AGG")]
        public string x_agg;
    }
}
