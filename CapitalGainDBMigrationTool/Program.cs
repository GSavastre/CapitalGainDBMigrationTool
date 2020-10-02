using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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

            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName+$"\\{ConfigurationManager.AppSettings["DataFolderName"]}\\";
            string path = projectDirectory+ConfigurationManager.AppSettings["ExcelFile"];
            string sqlPath = projectDirectory + ConfigurationManager.AppSettings["QueryFile"];

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
