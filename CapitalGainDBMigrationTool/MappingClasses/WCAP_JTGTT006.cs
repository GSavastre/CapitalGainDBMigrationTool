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
        public int ist;
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
        [BsonElement("N_SOGG_FISC")]
        public int n_sogg_fisc;
        [BsonElement("SRAP")]
        public int srap;
        [BsonElement("NDG")]
        public string ndg;
        [BsonElement("PROC_PROV")]
        public string proc_prov;
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
        [BsonElement("CAU_O")]
        public string cau_o;
        [BsonElement("SCA_O")]
        public string sca_o;
        [BsonElement("OPE_O")]
        public string ope_o;
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
        [BsonElement("VAL_NOM_P")]
        public float val_nom_p;
        [BsonElement("CTV_E_P")]
        public float ctv_e_p;
        [BsonElement("CTV_V_P")]
        public float ctv_v_p;
        [BsonElement("MED")]
        public DateTime med;
        [BsonElement("CARICO")]
        public DateTime carico;
        [BsonElement("PM_E")]
        public float pm_e;
        [BsonElement("PM_V")]
        public float pm_v;
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
        public float fisc_e;
        [BsonElement("FISC_V")]
        public float fisc_v;
        [BsonElement("X_INS")]
        public string x_ins;
        [BsonElement("X_AGG")]
        public string x_agg;

        //public WCAP_JTGTT006(WCAP_JTGTT007 e) {
        //    id = e.id;
        //    istituto = e.istituto;
        //    proc_prov = e.proc_prov;
        //    ope_o = e.ope_o;
        //    rap = e.rap;
        //    prd = e.prd;
        //    gain = e.gain;
        //    regime = e.regime;
        //    srap = e.srap;
        //    ndg = e.ndg;
        //    tip_prd = e.tip_prd;
        //    val_nom = e.val_nom;
        //    ctv_e = e.ctv_e;
        //    ctv_v = e.ctv_v;
        //    cmb_tra = e.cmb_tra;
        //    imp_nav = e.imp_nav;
        //    cau = e.cau;
        //    segno = e.segno;
        //    pm_e_est = e.pm_e_est;
        //    cau_o = e.cau_o;
        //    ope_o_col = e.ope_o_col;
        //    coe_ret = e.coe_ret;
        //    coe_rip = e.coe_rip;
        //    med_ope = e.med_ope;
        //    contab = e.contab;
        //    fil_amm = e.fil_amm;
        //    fil_ope = e.fil_ope;
        //    ins = DateTime.Now;
        //    agg = DateTime.Now;

        //}

        public WCAP_JTGTT006(int ist, string rap, string prd, DateTime gain, int prog_ass, string regime, int n_sogg_fisc, int srap, string ndg,
                            string proc_prov, string tip_prd, float val_nom, float ctv_e, float ctv_v, float cmb_tra, float imp_nav, string cau,
                            string segno, string oneroso, float pm_e_est, string cau_o, string sca_o, string ope_o, string ope_o_col, float coe_ret,
                            float coe_rip, DateTime med_ope, DateTime contab, float val_nom_p, float ctv_e_p, float ctv_v_p, DateTime med, DateTime carico, float pm_e,
                            float pm_v, string f_vld, DateTime d_vld, string mtv, string fil_amm, string fil_ope, float fisc_e, float fisc_v,
                            string x_ins = "", string x_agg = "") {

            this.ist = ist;
            this.rap = rap;
            this.prd = prd;
            this.gain = gain;
            this.prog_ass = prog_ass;
            this.regime = regime;
            this.n_sogg_fisc = n_sogg_fisc;
            this.srap = srap;
            this.ndg = ndg;
            this.proc_prov = proc_prov;
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
            this.cau_o = cau_o;
            this.sca_o = sca_o;
            this.ope_o = ope_o;
            this.ope_o_col = ope_o_col;
            this.coe_ret = coe_ret;
            this.coe_rip = coe_rip;
            this.med_ope = med_ope;
            this.contab = contab;
            this.val_nom_p = val_nom_p;
            this.ctv_e_p = ctv_e_p;
            this.ctv_v_p = ctv_v_p;
            this.med = med;
            this.carico = carico;
            this.pm_e = pm_e;
            this.pm_v = pm_v;
            this.f_vld = f_vld;
            this.d_vld = d_vld;
            this.mtv = mtv;
            this.fil_amm = fil_amm;
            this.fil_ope = fil_ope;
            this.fisc_e = fisc_e;
            this.fisc_v = fisc_v;
            this.x_ins = x_ins;
            this.x_agg = x_agg;
        }

    }
}
