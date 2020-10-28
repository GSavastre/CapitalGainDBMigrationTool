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
        public float imposta;
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

        public WCAP_JTGTT004(int ist, string sogg_fisc, DateTime gain, int prog, string tipo_sogg, string cc_reg, string cau, DateTime storno,
                            DateTime inserim, float imposta, string f_scarico, DateTime d_scarico, string fil_amm, string fil_ope,
                            string x_ins = "", string x_agg = "") {
            this.ist = ist;
            this.sogg_fisc = sogg_fisc;
            this.gain = gain;
            this.prog = prog;
            this.tipo_sogg = tipo_sogg;
            this.cc_reg = cc_reg;
            this.cau = cau;
            this.storno = storno;
            this.inserim = inserim;
            this.imposta = imposta;
            this.f_scarico = f_scarico;
            this.d_scarico = d_scarico;
            this.fil_amm = fil_amm;
            this.fil_ope = fil_ope;
            this.x_ins = x_ins;
            this.x_agg = x_agg;
        }
    }
}
