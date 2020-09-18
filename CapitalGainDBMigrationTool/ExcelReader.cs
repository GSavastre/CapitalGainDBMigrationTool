using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using Microsoft.Office.Interop.Excel;

using Excel = Microsoft.Office.Interop.Excel;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace CapitalGainDBMigrationTool
{
    class ExcelReader
    {
        string path {get; set;}
        int sheet {get; set;}

        Application excel = new Application();
        Workbook excelBook;
        Worksheet excelSheet;
        Range excelRange;

        int rows { get; set; }
        int cols { get; set; }

        public ExcelReader(string path, int sheet) {
            this.path = path;
            this.sheet = sheet;

            excelBook = excel.Workbooks.Open(path);
            excelSheet = (Worksheet)excelBook.Sheets[sheet];
            excelRange = excelSheet.UsedRange;
            rows = excelRange.Rows.Count;
            cols = excelRange.Columns.Count;
        }

        public void DisplayFile() {
            for(int i = 1; i <= rows; i++) {
                Console.Write($"{i} ");
                for(int j = 1; j <= cols; j++) {
                    if(excelSheet.Range[$"{((char)(j + 'A' - 1))}{i}"].Value != null) {
                        Console.Write($"{excelSheet.Range[$"{((char)(j + 'A' - 1))}{i}"].Value.ToString()} ");
                    }
                }
                Console.WriteLine("");
            }
        }

        public void CloseFile() {
            excel.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
        }
    }
}
