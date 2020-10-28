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
        public float imposta;
        [BsonElement("IMPOSTA_S")]
        public float imposta_s;
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

        public WCAP_JTGTT005(int ist, DateTime reg, string competen, string regime, float imposta, float imposta_s,
                            string regolare, string f_stato, DateTime d_stato, string x_ins = "", string x_agg = "") {

            this.ist = ist;
            this.reg = reg;
            this.competen = competen;
            this.regime = regime;
            this.imposta = imposta;
            this.imposta_s = imposta_s;
            this.regolare = regolare;
            this.f_stato = f_stato;
            this.d_stato = d_stato;
            this.x_ins = x_ins;
            this.x_agg = x_agg;
        }
    }
}
