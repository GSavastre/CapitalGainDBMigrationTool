using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CapitalGainDBMigrationTool.MappingClasses
{
    public class WCAP_JTGTT009
    {
        [BsonElement("IST")]
        public int ist;
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

        public WCAP_JTGTT009(int ist, string f_key, string c_key, DateTime inserim, string fil_amm,
                            string fil_ope, string x_ins = "", string x_agg = "") {
            this.ist = ist;
            this.f_key = f_key;
            this.c_key = c_key;
            this.inserim = inserim;
            this.fil_amm = fil_amm;
            this.fil_ope = fil_ope;
            this.x_ins = x_ins;
            this.x_agg = x_agg;
        }
    }

}
