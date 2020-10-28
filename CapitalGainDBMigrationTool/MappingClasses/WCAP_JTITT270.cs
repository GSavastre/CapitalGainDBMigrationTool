using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapitalGainDBMigrationTool.MappingClasses
{
    class WCAP_JTITT270
    {
        [BsonId]
        public ObjectId id;
        [BsonElement("IST")]
        public int ist;
        [BsonElement("NDG")]
        public string ndg;
        [BsonElement("RESIDENTE")]
        public string residente;
        [BsonElement("PAE_UIC")]
        public int pae_uic;
        [BsonElement("SETTORE")]
        public int settore;
        [BsonElement("RAMO")]
        public int ramo;
        [BsonElement("NAT_GIUR")]
        public string nat_giur;
        [BsonElement("RAP")]
        public string rap;
        [BsonElement("DES_RAP")]
        public string des_rap;
        [BsonElement("REGIME")]
        public string regime;
        [BsonElement("COMPENSA")]
        public string compensa;
        [BsonElement("QUALIF")]
        public string qualif;
        [BsonElement("DECOR")]
        public DateTime decor;
        [BsonElement("MOVIMENTA")]
        public string movimenta;
        [BsonElement("ESERCIZIO")]
        public DateTime esercizio;
        [BsonElement("D_INS")]
        public DateTime d_ins;
        [BsonElement("X_INS")]
        public string x_ins;
        [BsonElement("X_AGG")]
        public string x_agg;
        [BsonElement("CC")]
        public List<WCAP_JTITT272> cc = new List<WCAP_JTITT272>();

        public WCAP_JTITT270(int ist, string ndg, string residente, int pae_uic, int settore, int ramo, string nat_giur,
                            string rap, string des_rap, string regime, string compensa, string qualif, DateTime decor,
                            string movimenta, DateTime esercizio, DateTime d_ins, List<WCAP_JTITT272> cc,
                            string x_ins = "", string x_agg = "") {
            this.ist = ist;
            this.ndg = ndg;
            this.residente = residente;
            this.pae_uic = pae_uic;
            this.settore = settore;
            this.ramo = ramo;
            this.nat_giur = nat_giur;
            this.rap = rap;
            this.des_rap = des_rap;
            this.regime = regime;
            this.compensa = compensa;
            this.qualif = qualif;
            this.decor = decor;
            this.movimenta = movimenta;
            this.esercizio = esercizio;
            this.d_ins = d_ins;
            
            if (cc != null)
            {
                this.cc = cc;
            }
            else
            {
                this.cc = new List<WCAP_JTITT272>();
            }

            this.x_ins = x_ins;
            this.x_agg = x_agg;
            

        }
    }
}
