using System;
using System.Collections.Generic;
using System.Configuration;
using CapitalGainDBMigrationTool.TableClasses;
using Microsoft.Office.Interop.Excel;
using MongoDB.Bson;
using Excel = Microsoft.Office.Interop.Excel;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace CapitalGainDBMigrationTool
{
    class Program
    {
        static void Main(string[] args) {

            
            string path = ConfigurationManager.AppSettings["S"];
            int sheet = 1;

            ExcelReader reader = new ExcelReader(path, sheet);
            reader.DisplayFile(20);
            //List<Table> tables = reader.ReadFile();
            reader.CloseFile();

            #region testing collection creation

            //if (DBInteraction.Connect())
            //{
            //    Table t = new Table("testCollection");
            //    DBInteraction.CreateCollection(t);
            //}

            #endregion

        }
    }
}
