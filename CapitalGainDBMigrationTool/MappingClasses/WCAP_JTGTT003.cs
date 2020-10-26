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
        public double plus;
        [BsonElement("MINUS")]
        public double minus;
        [BsonElement("MIN_ACC")]
        public double pmin_acc;
        [BsonElement("MIN_CMP")]
        public double min_cmp;
        [BsonElement("MIN_ACC_1")]
        public double pmin_acc_1;
        [BsonElement("MIN_CMP_1")]
        public double min_cmp_1;
        [BsonElement("MIN_ACC_2")]
        public double pmin_acc_2;
        [BsonElement("MIN_CMP_2")]
        public double min_cmp_2;
        [BsonElement("MIN_ACC_3")]
        public double pmin_acc_3;
        [BsonElement("MIN_CMP_3")]
        public double min_cmp_3;
        [BsonElement("MIN_ACC_4")]
        public double pmin_acc_4;
        [BsonElement("MIN_CMP_4")]
        public double min_cmp_4;
        [BsonElement("IMPONIB")]
        public double imponib;
        [BsonElement("TIPO_SOGG")]
        public string tipo_sogg;
        [BsonElement("REGIME")]
        public string regime;
        [BsonElement("TIPO_PV")]
        public string tipo_pv;
        [BsonElement("STATO")]
        public string stato;
        [BsonElement("FILL_AMM")]
        public string fill_amm;
        [BsonElement("fil_ope")]
        public string fil_ope;
        [BsonElement("X_INS")]
        public string x_ins;
        [BsonElement("X_AGG")]
        public string x_agg;
    }
}
