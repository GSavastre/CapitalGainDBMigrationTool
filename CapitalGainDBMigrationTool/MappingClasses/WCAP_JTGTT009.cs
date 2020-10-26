using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitalGainDBMigrationTool.MappingClasses
{
    public class WCAP_JTGTT009
    {
        [BsonElement("IST")]
        public int IST;
        [BsonElement("F_KEY")]
        public string f_key;
        [BsonElement("C_KEY")]
        public string c_key;
        [BsonElement("INSERIM")]
        public DateTime inserim;
        [BsonElement("FIL_AMM")]
        public string fil_amm;
        [BsonElement("FIL_OPE")]
        public string fil_ope;
        [BsonElement("X_INS")]
        public string x_ins;
        [BsonElement("X_AGG")]
        public string x_agg;
    }
}
