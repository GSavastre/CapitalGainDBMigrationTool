using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitalGainDBMigrationTool.MappingClasses
{
    public class WCAP_JTGTT003
    {
        [BsonId]
        public ObjectId id;
        [BsonElement("IST")]
        public int ist;
        [BsonElement("SOGG_FISC")]
        public string sogg_fisc;
        [BsonElement("GAIN")]
        public DateTime gain;
        [BsonElement("TIPO_REC")]
        public string tipo_rec;
        [BsonElement("PLUS")]
        public float plus;
        [BsonElement("MINUS")]
        public float minus;
        [BsonElement("MIN_ACC")]
        public float min_acc;
        [BsonElement("MIN_CMP")]
        public float min_cmp;
        [BsonElement("MIN_ACC_1")]
        public float min_acc_1;
        [BsonElement("MIN_CMP_1")]
        public float min_cmp_1;
        [BsonElement("MIN_ACC_2")]
        public float min_acc_2;
        [BsonElement("MIN_CMP_2")]
        public float min_cmp_2;
        [BsonElement("MIN_ACC_3")]
        public float min_acc_3;
        [BsonElement("MIN_CMP_3")]
        public float min_cmp_3;
        [BsonElement("MIN_ACC_4")]
        public float min_acc_4;
        [BsonElement("MIN_CMP_4")]
        public float min_cmp_4;
        [BsonElement("IMPONIB")]
        public float imponib;
        [BsonElement("TIPO_SOGG")]
        public string tipo_sogg;
        [BsonElement("REGIME")]
        public string regime;
        [BsonElement("TIPO_PV")]
        public string tipo_pv;
        [BsonElement("STATO")]
        public string stato;
        [BsonElement("FILL_AMM")]
        public string fil_amm;
        [BsonElement("fil_ope")]
        public string fil_ope;
        [BsonElement("X_INS")]
        public string x_ins;
        [BsonElement("X_AGG")]
        public string x_agg;

        public WCAP_JTGTT003(int ist, string sogg_fisc, DateTime gain, string tipo_rec, float plus, float minus, float min_acc, float min_cmp,
                            float min_acc_1, float min_cmp_1, float min_acc_2, float min_cmp_2, float min_acc_3, float min_cmp_3, float min_acc_4, float min_cmp_4,
                            float imponib, string tipo_sogg, string regime, string tipo_pv, string stato, string fil_amm, string fil_ope, string x_ins = "", string x_agg = "") {

            this.ist = ist;
            this.sogg_fisc = sogg_fisc;
            this.gain = gain;
            this.tipo_rec = tipo_rec;
            this.plus = plus;
            this.minus = minus;
            this.min_acc = min_acc;
            this.min_cmp = min_cmp;
            this.min_acc_1 = min_acc_1;
            this.min_cmp_1 = min_cmp_1;
            this.min_acc_2 = min_acc_2;
            this.min_cmp_2 = min_cmp_2;
            this.min_acc_3 = min_acc_3;
            this.min_cmp_3 = min_cmp_3;
            this.min_acc_4 = min_acc_4;
            this.min_cmp_4 = min_cmp_4;
            this.imponib = imponib;
            this.tipo_sogg = tipo_sogg;
            this.regime = regime;
            this.tipo_pv = tipo_pv;
            this.stato = stato;
            this.fil_amm = fil_amm;
            this.fil_ope = fil_ope;
            this.x_ins = x_ins;
            this.x_agg = x_agg;
        }
    }
}
