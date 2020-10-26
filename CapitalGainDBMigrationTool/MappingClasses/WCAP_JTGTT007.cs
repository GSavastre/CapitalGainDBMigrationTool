using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapitalGainDBMigrationTool.MappingClasses
{
    public class WCAP_JTGTT007
    {
        [BsonId]
        public ObjectId id;
        [BsonElement("IST")]
        public string istituto;
        [BsonElement("PROC_PROV")]
        public string proc_prov;
        [BsonElement("OPE_O")]
        public string ope_o;
        [BsonElement("RAP")]
        public string rap;
        [BsonElement("PRD")]
        public string prd;
        [BsonElement("GAIN")]
        public DateTime gain;
        [BsonElement("REGIME")]
        public string regime;
        [BsonElement("SRAP")]
        public int srap;
        [BsonElement("NDG")]
        public string ndg;
        [BsonElement("TIP_PRD")]
        public string tip_prd;
        [BsonElement("VAL_NOM")]
        public double val_nom;
        [BsonElement("CTV_E")]
        public double ctv_e;
        [BsonElement("CTV_V")]
        public double ctv_v;
        [BsonElement("CMB_TRA")]
        public double cmb_tra;
        [BsonElement("IMP_NAV")]
        public double imp_nav;
        [BsonElement("CAU")]
        public string cau;
        [BsonElement("SEGNO")]
        public char segno;
        [BsonElement("ONERSO")]
        public string oneroso;
        [BsonElement("PM_E_EST")]
        public double pm_e_est;
        [BsonElement("STORNO")]
        public char storno;
        [BsonElement("CAU_O")]
        public string cau_o;
        [BsonElement("SCA_O")]
        public string sca_o;
        [BsonElement("OPE_O_COL")]
        public string ope_o_col;
        [BsonElement("COE_RET")]
        public double coe_ret;
        [BsonElement("COE_RIP")]
        public double coe_rip;
        [BsonElement("MED_OPE")]
        public DateTime med_ope;
        [BsonElement("CONTAB")]
        public DateTime contab;
        [BsonElement("FOR")]
        public string FOR;
        [BsonElement("FIL_AMM")]
        public string fil_amm;
        [BsonElement("FIL_OPE")]
        public string fil_ope;

        [BsonElement("C_STATO")]
        public string stato;
        [BsonElement("ORDINAMENTO")]
        public string ordinamento;
        [BsonElement("ERR")]
        public string err;
        [BsonElement("X_INS")]
        public DateTime ins;
        [BsonElement("X_AGG")]
        public DateTime agg;

        public WCAP_JTGTT007(Dictionary<int, string> values) {
            if (values.Count == 30)
            {
                istituto = values[0];
                proc_prov = values[1];
                ope_o = values[2];
                rap = values[3];
                prd = values[4];
                gain = StringToDateTime(values[5]);
                regime = values[6];
                srap = Int32.Parse(values[7]);
                ndg = values[8];
                tip_prd = values[9];
                val_nom = Convert.ToDouble(values[10]);
                ctv_e = Convert.ToDouble(values[11]);
                ctv_v = Convert.ToDouble(values[12]);
                cmb_tra = Convert.ToDouble(values[13]);
                imp_nav = Convert.ToDouble(values[14]);
                cau = values[15];
                segno = values[16][0];
                oneroso = values[17];
                pm_e_est = Convert.ToDouble(values[18]);
                storno = values[19][0];
                cau_o = values[20];
                sca_o = values[21];
                ope_o_col = values[22];
                coe_ret = Convert.ToDouble(values[23]);
                coe_rip = Convert.ToDouble(values[24]);
                med_ope = StringToDateTime(values[25]);
                contab = StringToDateTime(values[26]);
                FOR = values[27];
                fil_amm = values[28];
                fil_ope = values[29];
                
                ins = DateTime.Now;
                agg = DateTime.Now;
            }
        }

        DateTime StringToDateTime(string _gainDate) {
            int year;
            int month;
            int day;

            year = Int32.Parse($"{_gainDate[0]}{_gainDate[1]}{_gainDate[2]}{_gainDate[3]}");
            month = Int32.Parse($"{_gainDate[4]}{_gainDate[5]}");
            day = Int32.Parse($"{_gainDate[6]}{_gainDate[7]}");

            stato = "OK";

            if (year > DateTime.Now.Year) {
                stato = "KO";
            }
            if (month <= 0 || month > 12) {
                stato = "KO";
            }
            if (day <= 0 || day > 31) {
                stato = "KO";
            }

            return new DateTime(year, month, day);
        }
    }
}