using CapitalGainDBMigrationTool.MappingClasses;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CapitalGainDBMigrationTool
{
    public static class WCAP_SqlReader
    {
        static string filePath = @"C:\Users\cosmi\Desktop\QuerySiCapitalGain.sql";

        #region 003
        const int IST_03 = 32;
        const int SOGG_FISC_03 = 33;
        const int GAIN_03 = 34;
        const int TIPO_REC_03 = 35;
        const int PLUS_03 = 36;
        const int MINUS_03 = 38;
        const int MIN_ACC_03 = 40;
        const int MIN_CMP_03 = 42;
        const int MIN_ACC_1_03 = 44;
        const int MIN_CMP_1_03 = 46;
        const int MIN_ACC_2_03 = 48;
        const int MIN_CMP_2_03 = 50;
        const int MIN_ACC_3_03 = 52;
        const int MIN_CMP_3_03 = 54;
        const int MIN_ACC_4_03 = 56;
        const int MIN_CMP_4_03 = 58;
        const int IMPONIB_03 = 60;
        const int TIPO_SOGG_03 = 62;
        const int REGIME_03 = 63;
        const int TIPO_PV_03 = 64;
        const int STATO_03 = 65;
        const int FIL_AMM_03 = 66;
        const int FIL_OPE_03 = 67;
        const int X_INS = 76;
        const int X_AGG = 77;
        #endregion

        #region 005
        const int IST_05 = 18;
        const int REG_05 = 19;
        const int COMPETEN_05 = 20;
        const int REGIME_05 = 21;
        const int IMPOSTA_05 = 22;
        const int IMPOSTA_S_05 = 24;
        const int REGOLARE_05 = 26;
        const int F_STATO_05 = 27;
        const int D_STATO_05 = 28;
        const int X_INS_05 = 37;
        const int X_AGG_05 = 38;
        #endregion

        #region 006
        const int IST_06 = 51;
        const int RAP_06 = 52;
        const int PRD_06 = 53;
        const int GAIN_06 = 54;
        const int PROG_ASS_06 = 55;
        const int REGIME_06 = 56;
        const int N_SOGG_FISC_06 = 57;
        const int SRAP_06 = 58;
        const int NDG_06 = 59;
        const int PROC_PROV_06 = 60;
        const int TIP_PRD_06 = 61;
        const int VAL_NOM_06 = 62;
        const int CTV_E_06 = 63;
        const int CTV_V_06 = 64;
        const int CMB_TRA_06 = 65;
        const int IMP_NAV_06 = 66;
        const int CAU_06 = 67;
        const int SEGNO_06 = 68;
        const int ONEROSO_06 = 69;
        const int PM_E_EST_06 = 70;
        const int CAU_O_06 = 71;
        const int SCA_O_06 = 72;
        const int OPE_O_06 = 73;
        const int OPE_O_COL_06 = 74;
        const int COE_RET_06 = 75;
        const int COE_RIP_06 = 76;
        const int MED_OPE_06 = 77;
        const int CONTAB_06 = 78;
        const int VAL_NOM_P_06 = 79;
        const int CTV_E_P_06 = 80;
        const int CTV_V_P_06 = 81;
        const int MED_06 = 82;
        const int CARICO_06 = 83;
        const int PM_E_06 = 84;
        const int PM_V_06 = 85; 
        const int F_VLD_06 = 86;
        const int D_VLD_06 = 87;
        const int MTV_06 = 88;
        const int FIL_AMM_06 = 89;
        const int FIL_OPE_06 = 90;
        const int FISC_E_06 = 91;
        const int FISC_V_06 = 92;
        const int X_INS_06 = 101;
        const int X_AGG_06 = 102;
        #endregion

        #region 007
        const int IST_07 = 42;
        const int PROC_PROV_07 = 43;
        const int OPE_O_07 = 44;
        const int STATO_07 = 45;
        const int ORDINAMENTO_07 = 46;
        const int RAP_07 = 47;
        const int PRD_07 = 48;
        const int GAIN_07 = 49;
        const int REGIME_07 = 50;
        const int SRAP_07 = 51;
        const int NDG_07 = 52;
        const int TIP_PRD_07 = 53;
        const int VAL_NOM_07 = 54;
        const int CTV_E_07 = 55;
        const int CTV_V_07 = 56;
        const int CMB_TRA_07 = 57;
        const int IMP_NAV_07 = 58;
        const int CAU_07 = 59;
        const int SEGNO_07 = 60;
        const int ONEROSO_07 = 61;
        const int PM_E_EST_07 = 62;
        const int STORNO_07 = 63;
        const int CAU_O_07 = 64;
        const int SCA_O_07 = 65;
        const int OPE_O_COL_07 = 66;
        const int COE_RET_07 = 67;
        const int COE_RIP_07 = 68;
        const int MED_OPE_07 = 69;
        const int CONTAB_07 = 70;
        const int FOR_07 = 71;
        const int ERR_07 = 72;
        const int FIL_AMM_07 = 73;
        const int FIL_OPE_07 = 74;
        const int X_INS_07 = 83;
        const int X_AGG_07 = 84;
        #endregion

        #region 270
        const int IST_270 = 24;
        const int NDG_270 = 25;
        const int RESIDENTE_270 = 26;
        const int PAE_UIC_270 = 27;
        const int SETTORE_270 = 28;
        const int RAMO_270 = 29;
        const int NATA_GIUR_270 = 30;
        const int RAP_270 = 31;
        const int DES_RAP_270 = 32;
        const int REGIME_270 = 33;
        const int COMPENSA_270 = 34;
        const int QUALIF_270 = 35;
        const int DECOR_270 = 36;
        const int MOVIMENTA_270 = 37;
        const int ESERCIZIO_270 = 38;
        const int D_INS_270 = 39;
        const int X_INS_270 = 47;
        const int X_AGG_270 = 48;
        #endregion

        #region 271
        const int IST_271 = 13;
        const int NDG_271 = 14;
        const int DES_NDG_271 = 15;
        const int NDG_COIN_271 = 16;
        const int X_INS_271 = 25;
        const int X_AGG_271 = 26;
        #endregion


        public static void Populate003FromSql() {
            List<WCAP_JTGTT003> records_003 = new List<WCAP_JTGTT003>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                string[] subLine;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("INSERT"))
                    {
                        subLine = line.Split(",");
                        if (subLine[0].Contains("WCAP_JTGTT003"))
                        {
                            //Console.WriteLine(ClearStringBasic(subLine[TIPO_PV_03]));
                            
                            WCAP_JTGTT003 record_003 = new WCAP_JTGTT003(ExtractIstituto(subLine[IST_03]),
                                                                        ClearStringBasic(subLine[SOGG_FISC_03]),
                                                                        ExtractDateValue(subLine[GAIN_03]),
                                                                        ClearStringBasic(subLine[TIPO_REC_03]),
                                                                        ExtractFloatValue(subLine[PLUS_03]),
                                                                        ExtractFloatValue(subLine[MINUS_03]),
                                                                        ExtractFloatValue(subLine[MIN_ACC_03]),
                                                                        ExtractFloatValue(subLine[MIN_CMP_03]),
                                                                        ExtractFloatValue(subLine[MIN_ACC_1_03]),
                                                                        ExtractFloatValue(subLine[MIN_CMP_1_03]),
                                                                        ExtractFloatValue(subLine[MIN_ACC_2_03]),
                                                                        ExtractFloatValue(subLine[MIN_CMP_2_03]),
                                                                        ExtractFloatValue(subLine[MIN_ACC_3_03]),
                                                                        ExtractFloatValue(subLine[MIN_CMP_3_03]),
                                                                        ExtractFloatValue(subLine[MIN_ACC_4_03]),
                                                                        ExtractFloatValue(subLine[MIN_CMP_4_03]),
                                                                        ExtractFloatValue(subLine[IMPONIB_03]),
                                                                        ClearStringBasic(subLine[TIPO_SOGG_03]),
                                                                        ClearStringBasic(subLine[REGIME_03]),
                                                                        ClearStringBasic(subLine[TIPO_PV_03]),
                                                                        ClearStringBasic(subLine[STATO_03]),
                                                                        ClearStringBasic(subLine[FIL_AMM_03]),
                                                                        ClearStringBasic(subLine[FIL_OPE_03]),
                                                                        ClearStringBasic(subLine[X_INS]),
                                                                        ClearStringBasic(subLine[X_AGG])
                                                                        );

                            records_003.Add(record_003);
                        }
                    }
                }
            }

            if (DBCInteraction.Connect())
            {
                DBCInteraction.Insert_WCAP003s(records_003);
            }
            
        }

        public static void Populate005FromSql()
        {
            List<WCAP_JTGTT005> records_005 = new List<WCAP_JTGTT005>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                string[] subLine;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("INSERT"))
                    {
                        subLine = line.Split(",");
                        if (subLine[0].Contains("WCAP_JTGTT005"))
                        {
                            //int i = 0;
                            //foreach (string s in subLine) {
                            //    Console.WriteLine($"{i} - {s}");
                            //    i++;
                            //}
                            //break;
                            //Console.WriteLine(ClearStringBasic(subLine[TIPO_PV_03]));

                            WCAP_JTGTT005 record_005 = new WCAP_JTGTT005(ExtractIstituto(subLine[IST_05]),
                                                                        ExtractDateValue(subLine[REG_05]),
                                                                        ClearStringBasic(subLine[COMPETEN_05]),
                                                                        ClearStringBasic(subLine[REGIME_05]),
                                                                        ExtractFloatValue(subLine[IMPOSTA_05]),
                                                                        ExtractFloatValue(subLine[IMPOSTA_S_05]),
                                                                        ClearStringBasic(subLine[REGOLARE_05]),
                                                                        ClearStringBasic(subLine[F_STATO_05]),
                                                                        ExtractDateValue(subLine[D_STATO_05]),
                                                                        ClearStringBasic(subLine[X_INS_05]),
                                                                        ClearStringBasic(subLine[X_AGG_05])
                                                                        );

                            records_005.Add(record_005);
                        }
                    }
                }
            }

            if (DBCInteraction.Connect())
            {
                DBCInteraction.Insert_WCAP005s(records_005);
            }

        }

        public static void Populate006FromSql()
        {
            List<WCAP_JTGTT006> records_006 = new List<WCAP_JTGTT006>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                string[] subLine;
                List<string> subRecord = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("INSERT"))
                    {
                        subRecord.Clear();
                        subLine = line.Split(",");
                        if (subLine[0].Contains("WCAP_JTGTT006") && subLine.Length > 1)
                        {
                            for (int j = 0; j < subLine.Length; j++) {
                                if (subLine[j].Contains("CAST") && subLine[j].Contains("Decimal"))
                                {
                                    subRecord.Add(subLine[j] + subLine[j + 1]);
                                    j++;
                                }
                                else {
                                    subRecord.Add(subLine[j]);
                                }
                            }

                            //int i = 0;
                            //Console.WriteLine($"-----------------------");
                            //foreach (string s in subRecord)
                            //{
                            //    Console.WriteLine($"{i} - {s}");
                            //    i++;
                            //}
                            //Console.WriteLine($"-----------------------");
                            //break;

                            WCAP_JTGTT006 record_006 = new WCAP_JTGTT006(ExtractIstituto(subRecord[IST_06]),
                                                                        ClearStringBasic(subRecord[RAP_06]),
                                                                        ClearStringBasic(subRecord[PRD_06]),
                                                                        ExtractDateValue(subRecord[GAIN_06]),
                                                                        Int32.Parse(subRecord[PROG_ASS_06]),
                                                                        ClearStringBasic(subRecord[REGIME_06]),
                                                                        Int32.Parse(subRecord[N_SOGG_FISC_06]),
                                                                        Int32.Parse(subRecord[SRAP_06]),
                                                                        ClearStringBasic(subRecord[NDG_06]),
                                                                        ClearStringBasic(subRecord[PROC_PROV_06]),
                                                                        ClearStringBasic(subRecord[TIP_PRD_06]),
                                                                        ExtractFloatValue(subRecord[VAL_NOM_06]),
                                                                        ExtractFloatValue(subRecord[CTV_E_06]),
                                                                        ExtractFloatValue(subRecord[CTV_V_06]),
                                                                        ExtractFloatValue(subRecord[CMB_TRA_06]),
                                                                        ExtractFloatValue(subRecord[IMP_NAV_06]),
                                                                        ClearStringBasic(subRecord[CAU_06]),
                                                                        ClearStringBasic(subRecord[SEGNO_06]),
                                                                        ClearStringBasic(subRecord[ONEROSO_06]),
                                                                        ExtractFloatValue(subRecord[PM_E_EST_06]),
                                                                        ClearStringBasic(subRecord[CAU_O_06]),
                                                                        ClearStringBasic(subRecord[SCA_O_06]),
                                                                        ClearStringBasic(subRecord[OPE_O_06]),
                                                                        ClearStringBasic(subRecord[OPE_O_COL_06]),
                                                                        ExtractFloatValue(subRecord[COE_RET_06]),
                                                                        ExtractFloatValue(subRecord[COE_RIP_06]),
                                                                        ExtractDateValue(subRecord[MED_OPE_06]),
                                                                        ExtractDateValue(subRecord[CONTAB_06]),
                                                                        ExtractFloatValue(subRecord[VAL_NOM_P_06]),
                                                                        ExtractFloatValue(subRecord[CTV_E_P_06]),
                                                                        ExtractFloatValue(subRecord[CTV_V_P_06]),
                                                                        ExtractDateValue(subRecord[MED_06]),
                                                                        ExtractDateValue(subRecord[CARICO_06]),
                                                                        ExtractFloatValue(subRecord[PM_E_06]),
                                                                        ExtractFloatValue(subRecord[PM_V_06]),
                                                                        ClearStringBasic(subRecord[F_VLD_06]),
                                                                        ExtractDateValue(subRecord[D_VLD_06]),
                                                                        ClearStringBasic(subRecord[MTV_06]),
                                                                        ClearStringBasic(subRecord[FIL_AMM_06]),
                                                                        ClearStringBasic(subRecord[FIL_OPE_06]),
                                                                        ExtractFloatValue(subRecord[FISC_E_06]),
                                                                        ExtractFloatValue(subRecord[FISC_V_06]),
                                                                        null,
                                                                        ClearStringBasic(subRecord[X_INS_06]),
                                                                        ClearStringBasic(subRecord[X_AGG_06])
                                                                        ); ;

                            records_006.Add(record_006);
                        }
                    }
                }
            }

            if (DBCInteraction.Connect())
            {
                DBCInteraction.Insert_WCAP006s(records_006);
            }

        }

        public static void Populate007FromSql()
        {
            List<WCAP_JTGTT007> records_007 = new List<WCAP_JTGTT007>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                string[] subLine;
                List<string> subRecord = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("INSERT"))
                    {
                        subRecord.Clear();
                        subLine = line.Split(",");
                        if (subLine[0].Contains("WCAP_JTGTT007") && subLine.Length > 1)
                        {
                            for (int j = 0; j < subLine.Length; j++)
                            {
                                if (subLine[j].Contains("CAST") && subLine[j].Contains("Decimal"))
                                {
                                    subRecord.Add(subLine[j] + subLine[j + 1]);
                                    j++;
                                }
                                else
                                {
                                    subRecord.Add(subLine[j]);
                                }
                            }

                            //int i = 0;
                            //Console.WriteLine($"-----------------------");
                            //foreach (string s in subRecord)
                            //{
                            //    Console.WriteLine($"{i} - {s}");
                            //    i++;
                            //}
                            //Console.WriteLine($"-----------------------");
                            //break;

                            WCAP_JTGTT007 record_007 = new WCAP_JTGTT007(ExtractIstituto(subRecord[IST_07]),
                                                                        ClearStringBasic(subRecord[PROC_PROV_07]),
                                                                        ClearStringBasic(subRecord[OPE_O_07]),
                                                                        ClearStringBasic(subRecord[STATO_07]),
                                                                        Int32.Parse(subRecord[ORDINAMENTO_07]),
                                                                        ClearStringBasic(subRecord[RAP_07]),
                                                                        ClearStringBasic(subRecord[PRD_07]),
                                                                        ExtractDateValue(subRecord[GAIN_07]),
                                                                        ClearStringBasic(subRecord[REGIME_07]),
                                                                        Int32.Parse(subRecord[SRAP_07]),
                                                                        ClearStringBasic(subRecord[NDG_07]),
                                                                        ClearStringBasic(subRecord[TIP_PRD_07]),
                                                                        ExtractFloatValue(subRecord[VAL_NOM_07]),
                                                                        ExtractFloatValue(subRecord[CTV_E_07]),
                                                                        ExtractFloatValue(subRecord[CTV_V_07]),
                                                                        ExtractFloatValue(subRecord[CMB_TRA_07]),
                                                                        ExtractFloatValue(subRecord[IMP_NAV_07]),
                                                                        ClearStringBasic(subRecord[CAU_07]),
                                                                        ClearStringBasic(subRecord[SEGNO_07]),
                                                                        ClearStringBasic(subRecord[ONEROSO_07]),
                                                                        ExtractFloatValue(subRecord[PM_E_EST_07]),
                                                                        ClearStringBasic(subRecord[STORNO_07]),
                                                                        ClearStringBasic(subRecord[CAU_O_07]),
                                                                        ClearStringBasic(subRecord[SCA_O_07]),
                                                                        ClearStringBasic(subRecord[OPE_O_COL_07]),
                                                                        ExtractFloatValue(subRecord[COE_RET_07]),
                                                                        ExtractFloatValue(subRecord[COE_RIP_07]),
                                                                        ExtractDateValue(subRecord[MED_OPE_07]),
                                                                        ExtractDateValue(subRecord[CONTAB_07]),
                                                                        ClearStringBasic(subRecord[FOR_07]),
                                                                        ClearStringBasic(subRecord[ERR_07]),
                                                                        ClearStringBasic(subRecord[FIL_AMM_07]),
                                                                        ClearStringBasic(subRecord[FIL_OPE_07]),
                                                                        ClearStringBasic(subRecord[X_INS_07]),
                                                                        ClearStringBasic(subRecord[X_INS_07])
                                                                        );

                            records_007.Add(record_007);
                        }
                    }
                }
            }

            if (DBCInteraction.Connect())
            {
                DBCInteraction.Insert_WCAP007s(records_007);
            }

        }

        public static void Populate270FromSql()
        {
            List<WCAP_JTITT270> records_270 = new List<WCAP_JTITT270>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                string[] subLine;
                List<string> subRecord = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("INSERT"))
                    {
                        subRecord.Clear();
                        subLine = line.Split(",");
                        if (subLine[0].Contains("WCAP_JTITT270") && subLine.Length > 1)
                        {
                            for (int j = 0; j < subLine.Length; j++)
                            {
                                if (subLine[j].Contains("CAST") && subLine[j].Contains("Decimal"))
                                {
                                    subRecord.Add(subLine[j] + subLine[j + 1]);
                                    j++;
                                }
                                else
                                {
                                    subRecord.Add(subLine[j]);
                                }
                            }

                            //int i = 0;
                            //Console.WriteLine($"-----------------------");
                            //foreach (string s in subRecord)
                            //{
                            //    Console.WriteLine($"{i} - {s}");
                            //    i++;
                            //}
                            //Console.WriteLine($"-----------------------");
                            //break;

                            WCAP_JTITT270 record_270 = new WCAP_JTITT270(ExtractIstituto(subRecord[IST_270]),
                                                                        ClearStringBasic(subRecord[NDG_270]),
                                                                        ClearStringBasic(subRecord[RESIDENTE_270]),
                                                                        ExtractIntValue(subRecord[PAE_UIC_270]),
                                                                        ExtractIntValue(subRecord[SETTORE_270]),
                                                                        ExtractIntValue(subRecord[RAMO_270]),
                                                                        ClearStringBasic(subRecord[NATA_GIUR_270]),
                                                                        ClearStringBasic(subRecord[RAP_270]),
                                                                        ClearStringBasic(subRecord[DES_RAP_270]),
                                                                        ClearStringBasic(subRecord[REGIME_270]),
                                                                        ClearStringBasic(subRecord[COMPENSA_270]),
                                                                        ClearStringBasic(subRecord[QUALIF_270]),
                                                                        ExtractDateValue(subRecord[DECOR_270]),
                                                                        ClearStringBasic(subRecord[MOVIMENTA_270]),
                                                                        ExtractDateValue(subRecord[ESERCIZIO_270]),
                                                                        ExtractDateValue(subRecord[D_INS_270]),
                                                                        null, //lista di cc aggiunta durante il passaggio a mongo
                                                                        null, //addebito (004) aggiunto durante il passaggio a mongo
                                                                        ClearStringBasic(subRecord[X_INS_270]),
                                                                        ClearStringBasic(subRecord[X_AGG_270])
                                                                        ); ;

                            records_270.Add(record_270);
                        }
                    }
                }
            }

            if (DBCInteraction.Connect())
            {
                DBCInteraction.Insert_WCAP270s(records_270);
            }

        }

        public static void Populate271FromSql()
        {
            List<WCAP_JTITT271> records_271 = new List<WCAP_JTITT271>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                string[] subLine;
                List<string> subRecord = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("INSERT"))
                    {
                        subRecord.Clear();
                        subLine = line.Split(",");
                        if (subLine[0].Contains("WCAP_JTITT271") && subLine.Length > 1)
                        {
                            for (int j = 0; j < subLine.Length; j++)
                            {
                                if (subLine[j].Contains("CAST") && subLine[j].Contains("Decimal"))
                                {
                                    subRecord.Add(subLine[j] + subLine[j + 1]);
                                    j++;
                                }
                                else
                                {
                                    subRecord.Add(subLine[j]);
                                }
                            }

                            //int i = 0;
                            //Console.WriteLine($"-----------------------");
                            //foreach (string s in subRecord)
                            //{
                            //    Console.WriteLine($"{i} - {s}");
                            //    i++;
                            //}
                            //Console.WriteLine($"-----------------------");
                            //break;

                            WCAP_JTITT271 record_271 = new WCAP_JTITT271(ExtractIstituto(subRecord[IST_271]),
                                                                        ClearStringBasic(subRecord[NDG_271]),
                                                                        ClearStringBasic(subRecord[DES_NDG_271]),
                                                                        ClearStringBasic(subRecord[NDG_COIN_271]),
                                                                        ClearStringBasic(subRecord[X_INS_271]),
                                                                        ClearStringBasic(subRecord[X_AGG_271])
                                                                        );

                            records_271.Add(record_271);
                        }
                    }
                }
            }

            if (DBCInteraction.Connect())
            {
                DBCInteraction.Insert_WCAP271s(records_271);
            }

        }

        #region UTILITY

        static int ExtractIstituto(string segment) {
            //segment = [TGN003_X_AGG]) VALUES(1 -> devo estrapolare l'1 
            segment = segment.Split("(")[1];
            return Int32.Parse(segment);
        }
        static DateTime ExtractDateValue(string segment) {
            //segment = CAST(N'2010-09-15' AS Date)) -> estraggo data
            if (segment == " NULL") {
                return DateTime.MinValue;
            }

            segment = segment.Split("'")[1];
            return DateTime.Parse(segment);
        }
        static float ExtractFloatValue(string segment) {
            //segment = CAST(0.000 AS Decimal(17
            if (segment == " NULL") {
                return 0f;
            }

            segment = string.Format("{0:F3}", segment.Split("(")[1].Split(" ")[0]);
            return float.Parse(segment);
        }
        static int ExtractIntValue(string segment)
        {
            //segment = CAST(0.000 AS Decimal(17
            if (segment == " NULL")
            {
                return 0;
            }

            return Int32.Parse(segment);
        }
        static string ClearStringBasic(string segment)
        {
            if (segment == " NULL") {
                return null;
            }

            segment = segment.Substring(2);
            segment = segment.Trim('\'');

            if (segment.Contains("')"))
            {
                segment = segment.TrimEnd('\'', ')');
            }
            return segment;
        }

        #endregion
    }
}
