using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitalGainDBMigrationTool.MappingClasses
{
    public  class WCAP_JTGTT004
    {
        [BsonElement("IST")]
        public int ist;
        [BsonElement("SOGG_FISC")]
        public string sogg_fisc;
        [BsonElement("GAIN")]
        public DateTime gain;
        [BsonElement("PROG")]
        public int prog;
        [BsonElement("TIPO_SOGG")]
        public string tipo_sogg;
        [BsonElement("REGIME")]
        public string regime;
        [BsonElement("TIPO_REG")]
        public string tipo_reg;
        [BsonElement("CC_REG")]
        public string cc_reg;
        [BsonElement("CAU")]
        public string cau;
        [BsonElement("STORNO")]
        public DateTime storno;
        [BsonElement("INSERIM")]
        public DateTime inserim;
        [BsonElement("IMPOSTA")]
        public double imposta;
        [BsonElement("F_SCARICO")]
        public string f_scarico;
        [BsonElement("D_SCARICO")]
        public DateTime d_scarico;
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
