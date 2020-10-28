using CapitalGainDBMigrationTool.MappingClasses;
using Microsoft.Office.Interop.Excel;
using MongoDB.Bson;
using MongoDB.Driver.Core.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace CapitalGainDBMigrationTool
{
    public static class FileReader
    {
        static string filePath = @"C:\Users\cosmi\Desktop\movimGain9.txt";

        static int[,] len_off = new int[30, 2];
        static Dictionary<int, string> values = new Dictionary<int, string>();

        public static List<WCAP_JTGTT007> ReadTxt()
        {
            List<WCAP_JTGTT007> listaMovimentiInput = new List<WCAP_JTGTT007>();

            GetExcelLenghtAndOffsetData();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string s;
                while ((s = reader.ReadLine()) != null)
                {
                    char[] record = new char[391];
                    record = s.ToCharArray();

                    for (int i = 0; i < 30; i++)
                    {
                        int len = len_off[i, 0];
                        int off = len_off[i, 1] - 1;

                        char[] segment = new char[len];

                        for (int j = 0; j < len; j++)
                        {
                            try
                            {
                                segment[j] = record[off + j];
                            }
                            catch
                            {
                                segment[j] = ' ';
                            }
                        }
                        values.Add(i, new string(segment));
                    }

                    listaMovimentiInput.Add(new WCAP_JTGTT007(values));
                    values.Clear();
                }
            }

            return listaMovimentiInput;
        }

        static void GetExcelLenghtAndOffsetData()
        {
            int start_col = 3;
            int start_row = 3;

            int sheet = 4;
            _Application excel = new Application();
            Workbook wb = excel.Workbooks.Open(ConfigurationManager.AppSettings["D"]);
            Worksheet ws = (Worksheet)wb.Worksheets[sheet];

            for (int r = start_row; r < 33; r++)
            {
                //Console.WriteLine( $"{((Microsoft.Office.Interop.Excel.Range)ws.Cells[r, start_col]).Value2} : " +
                //               $"{((Microsoft.Office.Interop.Excel.Range)ws.Cells[r, start_col+1]).Value2}");

                len_off[r - 3, 0] = Int32.Parse(((Microsoft.Office.Interop.Excel.Range)ws.Cells[r, start_col]).Value2.ToString());
                len_off[r - 3, 1] = Int32.Parse(((Microsoft.Office.Interop.Excel.Range)ws.Cells[r, start_col + 1]).Value2.ToString());

            }
        }

        public static void PrintMovementsStatus(List<WCAP_JTGTT007> listaMovimentiInput)
        {
            foreach (WCAP_JTGTT007 record in listaMovimentiInput)
            {
                Console.WriteLine($"{record.proc_prov} - {record.stato}");
            }
        }

        //TODO metodo per controlli avanzati

    }
}
