using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using CapitalGainDBMigrationTool.TableItems;
using Range = Microsoft.Office.Interop.Excel.Range;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

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

        private const double tableFontSize = 18;

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
                    char columnID = (char)(j + 'A' - 1);
                    if (excelSheet.Range[$"{((char)(j + 'A' - 1))}{i}"].Value != null) {
                        Console.Write($"{excelSheet.Range[$"{columnID}{i}"].Value.ToString()} ");
                    }
                }
                Console.WriteLine("");
            }
        }

        //Ugliest thing I have ever written in my life smh
        public List<Table> ReadFile() {
            List<Table> tables = new List<Table>();
            Table table = null;
            TableItem item = new TableItem();
            string tableId = "";
            string tableName = "";
            string tableDescription = "";
            for (int i = 1; i <= rows; i++) {
                
                if((double)excelSheet.Range[$"A{i}"].Font.Size == tableFontSize && excelSheet.Range[$"A{i}"].Value != null) {
                    if(table != null) {
                        tables.Add(table);
                        table = null;
                    }

                    tableId = excelSheet.Range[$"A{i}"].Value.ToString();
                    tableName = excelSheet.Range[$"B{i}"].Value.ToString();
                    tableDescription = excelSheet.Range[$"G{i}"].Value.ToString();
                    table = new Table(tableId, tableName, tableDescription);
                    //Skip to next row where table items start
                    i++;
                    
                    while (excelSheet.Range[$"A{i}"].Value != null && excelSheet.Range[$"A{i}"].Value.ToString() != "CLUSTER") {
                        #region old code

                        /*item.name = (excelSheet.Range[$"A{i}"].Value ?? "").ToString();
                        item.type = (excelSheet.Range[$"B{i}"].Value ?? "").ToString();
                        if (excelSheet.Range[$"C{i}"].Value.ToString() == null || string.IsNullOrEmpty(excelSheet.Range[$"C{i}"].Value.ToString())) {
                            item.size = -1;
                        } else {
                            item.size = Convert.ToDouble(excelSheet.Range[$"C{i}"].Value.ToString());
                        }
                        
                        item.of = Convert.ToChar(excelSheet.Range[$"D{i}"].Value ?? ' ');
                        item.constraints = (excelSheet.Range[$"E{i}"].Value ?? "").ToString();
                        item.description = (excelSheet.Range[$"F{i}"].Value ?? "").ToString();
                        item.domain = (excelSheet.Range[$"G{i}"].Value ?? "").ToString();
                        item.comment = (excelSheet.Range[$"H{i}"].Value ?? "").ToString();
                        item.link = (excelSheet.Range[$"I{i}"].Value ?? "").ToString();
                        item.mandatoryInMap = (excelSheet.Range[$"J{i}"].Value ?? "").ToString();
                        item.searchCriteria = (excelSheet.Range[$"K{i}"].Value ?? "").ToString();
                        item.gridVisibility = (excelSheet.Range[$"L{i}"].Value ?? "").ToString();
                        item.shortDescription = (excelSheet.Range[$"M{i}"].Value ?? "").ToString();
                        table.AddItem(item);*/
                        //table.AddItem(excelSheet.Range[excelSheet.Cells[i,1],excelSheet.Cells[i,cols]]);
                        #endregion
                        Range range = (Range)excelSheet.Range[excelSheet.Cells[i, 1], excelSheet.Cells[i, cols]];
                        object[,] holder = (object[,])range.Value2;
                        string[] stringValue = new string[cols];
                        for(int n = 1; n <= cols; n++) {
                            if(holder[1, n] == null) {
                                stringValue[n - 1] = "";
                            } else {
                                stringValue[n - 1] = holder[1, n].ToString();
                            }
                            
                        }
                        table.AddItem(new TableItem(stringValue));
                        i++;
                    }
                }
            }
            tables.Add(table);
            return tables;
        }

        public void CloseFile() {
            excel.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
        }
    }
}
