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
        public int ist;
        [BsonElement("PROC_PROV")]
        public string proc_prov;
        [BsonElement("OPE_O")]
        public string ope_o;
        [BsonElement("C_STATO")]
        public string stato;
        [BsonElement("ORDINAMENTO")]
        public int ordinamento;
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
        public float val_nom;
        [BsonElement("CTV_E")]
        public float ctv_e;
        [BsonElement("CTV_V")]
        public float ctv_v;
        [BsonElement("CMB_TRA")]
        public float cmb_tra;
        [BsonElement("IMP_NAV")]
        public float imp_nav;
        [BsonElement("CAU")]
        public string cau;
        [BsonElement("SEGNO")]
        public string segno;
        [BsonElement("ONERSO")]
        public string oneroso;
        [BsonElement("PM_E_EST")]
        public float pm_e_est;
        [BsonElement("STORNO")]
        public string storno;
        [BsonElement("CAU_O")]
        public string cau_o;
        [BsonElement("SCA_O")]
        public string sca_o;
        [BsonElement("OPE_O_COL")]
        public string ope_o_col;
        [BsonElement("COE_RET")]
        public float coe_ret;
        [BsonElement("COE_RIP")]
        public float coe_rip;
        [BsonElement("MED_OPE")]
        public DateTime med_ope;
        [BsonElement("CONTAB")]
        public DateTime contab;
        [BsonElement("FOR")]
        public string FOR;
        [BsonElement("ERR")]
        public string err;
        [BsonElement("FIL_AMM")]
        public string fil_amm;
        [BsonElement("FIL_OPE")]
        public string fil_ope;
        [BsonElement("X_INS")]
        public string x_ins;
        [BsonElement("X_AGG")]
        public string x_agg;

        /// <summary>
        /// Costruttore per l'estrapolazione dell'oggetto da file SQL
        /// </summary>
        public WCAP_JTGTT007(int ist, string proc_prov, string ope_o, string stato, int ordinamento, string rap, string prd, DateTime gain,
                            string regime, int srap, string ndg, string tip_prd, float val_nom, float ctv_e, float ctv_v, float cmb_tra,
                            float imp_nav, string cau, string segno, string oneroso, float pm_e_est, string storno, string cau_o, string sca_o,
                            string ope_o_col, float coe_ret, float coe_rip, DateTime med_ope, DateTime contab, string FOR, string err,
                            string fil_amm, string fil_ope, string x_ins = "", string x_agg = "") {

            this.ist = ist;
            this.proc_prov = proc_prov;
            this.ope_o = ope_o;
            this.stato = stato;
            this.ordinamento = ordinamento;
            this.rap = rap;
            this.prd = prd;
            this.gain = gain;
            this.regime = regime;
            this.srap = srap;
            this.ndg = ndg;
            this.tip_prd = tip_prd;
            this.val_nom = val_nom;
            this.ctv_e = ctv_e;
            this.ctv_v = ctv_v;
            this.cmb_tra = cmb_tra;
            this.imp_nav = imp_nav;
            this.cau = cau;
            this.segno = segno;
            this.oneroso = oneroso;
            this.pm_e_est = pm_e_est;
            this.storno = storno;
            this.cau_o = cau_o;
            this.sca_o = sca_o;
            this.ope_o_col = ope_o_col;
            this.coe_ret = coe_ret;
            this.coe_rip = coe_rip;
            this.med_ope = med_ope;
            this.contab = contab;
            this.FOR = FOR;
            this.err = err;
            this.fil_amm = fil_amm;
            this.fil_ope = fil_ope;
            this.x_ins = x_ins;
            this.x_agg = x_agg;
        }

        /// <summary>
        /// Costruttore per l'estrapolazione dell'oggetto da file TXT (flusso di input)
        /// </summary>
        public WCAP_JTGTT007(Dictionary<int, string> values) {
            if (values.Count == 30)
            {
                ist = Int32.Parse(values[0]);
                proc_prov = values[1];
                ope_o = values[2];
                rap = values[3];
                prd = values[4];
                gain = StringToDateTime(values[5]);
                regime = values[6];
                srap = Int32.Parse(values[7]);
                ndg = values[8];
                tip_prd = values[9];
                val_nom = float.Parse(values[10]);
                ctv_e = float.Parse(values[11]);
                ctv_v = float.Parse(values[12]);
                cmb_tra = float.Parse(values[13]);
                imp_nav = float.Parse(values[14]);
                cau = values[15];
                segno = values[16];
                oneroso = values[17];
                pm_e_est = float.Parse(values[18]);
                storno = values[19];
                cau_o = values[20];
                sca_o = values[21];
                ope_o_col = values[22];
                coe_ret = float.Parse(values[23]);
                coe_rip = float.Parse(values[24]);
                med_ope = StringToDateTime(values[25]);
                contab = StringToDateTime(values[26]);
                FOR = values[27];
                fil_amm = values[28];
                fil_ope = values[29];
                
                x_ins = "";
                x_agg = "";
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