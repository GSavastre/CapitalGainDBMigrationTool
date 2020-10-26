using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitalGainDBMigrationTool.MappingClasses
{
    public class WCAP_JTGTT006
    {
        [BsonId]
        public ObjectId id;
        [BsonElement("IST")]
        public string istituto;
        [BsonElement("RAP")]
        public string rap;
        [BsonElement("PRD")]
        public string prd;
        [BsonElement("GAIN")]
        public DateTime gain;
        [BsonElement("PROG_ASS")]
        public int prog_ass;
        [BsonElement("REGIME")]
        public string regime;
        [BsonElement("SRAP")]
        public int srap;
        [BsonElement("NDG")]
        public string ndg;
        [BsonElement("PROC_PROV")]
        public string proc_prov;
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
        [BsonElement("CAU_O")]
        public string cau_o;
        [BsonElement("SCA_O")]
        public string sca_o;
        [BsonElement("OPE_O")]
        public string ope_o;
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
        [BsonElement("VAL_NOM_P")]
        public int val_nom_p;
        [BsonElement("CTV_E_P")]
        public int ctv_e_p;
        [BsonElement("CTV_V_P")]
        public int ctv_v_p;
        [BsonElement("MED")]
        public DateTime med;
        [BsonElement("CARICO")]
        public DateTime carico;
        [BsonElement("PM_E")]
        public int pm_e;
        [BsonElement("PM_V")]
        public int pm_v;
        [BsonElement("F_VLD")]
        public string f_vld;
        [BsonElement("D_VLD")]
        public DateTime d_vld;
        [BsonElement("MTV")]
        public string mtv;
        [BsonElement("FIL_AMM")]
        public string fil_amm;
        [BsonElement("FIL_OPE")]
        public string fil_ope;
        [BsonElement("FISC_E")]
        public int fisc_e;
        [BsonElement("FISC_V")]
        public int fisc_v;
        [BsonElement("X_INS")]
        public DateTime ins;
        [BsonElement("X_AGG")]
        public DateTime agg;

        public WCAP_JTGTT006(WCAP_JTGTT007 e) {
            id = e.id;
            istituto = e.istituto;
            proc_prov = e.proc_prov;
            ope_o = e.ope_o;
            rap = e.rap;
            prd = e.prd;
            gain = e.gain;
            regime = e.regime;
            srap = e.srap;
            ndg = e.ndg;
            tip_prd = e.tip_prd;
            val_nom = e.val_nom;
            ctv_e = e.ctv_e;
            ctv_v = e.ctv_v;
            cmb_tra = e.cmb_tra;
            imp_nav = e.imp_nav;
            cau = e.cau;
            segno = e.segno;
            pm_e_est = e.pm_e_est;
            cau_o = e.cau_o;
            ope_o_col = e.ope_o_col;
            coe_ret = e.coe_ret;
            coe_rip = e.coe_rip;
            med_ope = e.med_ope;
            contab = e.contab;
            fil_amm = e.fil_amm;
            fil_ope = e.fil_ope;
            ins = DateTime.Now;
            agg = DateTime.Now;

        }

    }
}
