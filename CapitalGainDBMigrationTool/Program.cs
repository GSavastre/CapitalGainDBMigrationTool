using System;
using System.Collections.Generic;

using Microsoft.Office.Interop.Excel;

using Excel = Microsoft.Office.Interop.Excel;
using Range = Microsoft.Office.Interop.Excel.Range;
namespace CapitalGainDBMigrationTool
{
    class Program
    {
        static void Main(string[] args) { 
        
            //TODO: Change this to a var
            string path = @"D:\Gabriele\Documents\Tirocinio\DT_GAIN00_BaseDati_V01_Draft.xlsx";
            int sheet = 1;

            ExcelReader reader = new ExcelReader(path, sheet);
            //reader.DisplayFile();
            reader.ReadFile();
            reader.CloseFile();
        }
    }
}
