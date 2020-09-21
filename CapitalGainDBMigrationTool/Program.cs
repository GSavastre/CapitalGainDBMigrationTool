using System;
using System.Collections.Generic;
using System.Configuration;
using CapitalGainDBMigrationTool.TableItems;
using Microsoft.Office.Interop.Excel;
using MongoDB.Bson;
using Excel = Microsoft.Office.Interop.Excel;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace CapitalGainDBMigrationTool
{
    class Program
    {
        static void Main(string[] args) {

            //TODO: Change this to a var
            string path = ConfigurationManager.AppSettings["D"];
            int sheet = 1;

            ExcelReader reader = new ExcelReader(path, sheet);
            reader.DisplayFile();
            reader.CloseFile();

            #region testing collection creation

            //if (DBInteraction.Connect())
            //{
            //    Table t = new Table("testCollection");
            //    DBInteraction.CreateCollection(t.name);
            //}

            #endregion

        }
    }
}
