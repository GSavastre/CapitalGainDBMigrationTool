using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using CapitalGainDBMigrationTool.TableClasses;
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

        /// <summary>
        /// Display the excel file on console
        /// </summary>
        /// <param name="limitRows">The amount of rows to display, if equals to -1 display all rows</param>
        public void DisplayFile(int limitRows = -1) {
            if(limitRows == -1) {
                limitRows = rows;
            }

            //Iterate the rows
            for (int i = 1; i <= limitRows; i++) {
                //Display the row number
                Console.Write($"{i} ");
                for(int j = 1; j <= cols; j++) {
                    //Cast the col number to a char, eg : "A1,B1"
                    char columnID = (char)(j + 'A' - 1);
                    if (excelSheet.Range[$"{((char)(j + 'A' - 1))}{i}"].Value != null && i!= 2) {
                        Console.Write($"{excelSheet.Range[$"{columnID}{i}"].Value.ToString()} | ");
                    } else {
                        Console.Write("".PadRight(10, '-'));
                    }
                }
                //End of row
                Console.WriteLine("\n".PadRight(40, '_'));
            }
        }

        //Ugliest thing I have ever written in my life smh
        /// <summary>
        /// Read an excel file and parse its contents to a list of tables
        /// </summary>
        /// <param name="limitRows">The amount of rows to read, if equals to -1 read all rows</param>
        /// <returns></returns>
        public List<Table> ReadFile(int limitRows = -1) {
            List<Table> tables = new List<Table>();
            Table table = null;
            TableAttribute attribute = new TableAttribute();
            string tableId, tableName, tableDescription = "";

            if(limitRows == -1) {
                limitRows = rows;
            }
            for (int i = 1; i <= limitRows; i++) {
                
                //All tables in the excel file use an 18 font size, this is the only common attribute to distinguish a table from a table attribute
                if((double)excelSheet.Range[$"A{i}"].Font.Size == tableFontSize && excelSheet.Range[$"A{i}"].Value != null) {
                    //Add the previously read table, on first iteration table will be null
                    if(table != null) {
                        tables.Add(table);
                        table = null;
                    }

                    //All tables info is on the column A,B and G so it's fixed
                    try {
                        tableId = excelSheet.Range[$"A{i}"].Value.ToString();
                        tableName = excelSheet.Range[$"B{i}"].Value.ToString();
                        tableDescription = excelSheet.Range[$"G{i}"].Value.ToString();
                        table = new Table(tableId, tableName, tableDescription);
                    } catch(Exception e) {
                        Console.WriteLine($"Errore nella lettura di una tabella riga: {i} del file");
                        Console.WriteLine($"Messaggio errore:{e.Message}");
                    }
                    //Skip to next row where table attributes start
                    i++;
                    
                    //TODO: Understand what cluster is, it's not a column of the table so I skipped it
                    while (excelSheet.Range[$"A{i}"].Value != null && excelSheet.Range[$"A{i}"].Value.ToString() != "CLUSTER") {
                        //Get the entire row and cast it to an array of strings
                        try {
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
                            table.AddAttribute(new TableAttribute(stringValue));
                        }catch(Exception e) {
                            Console.WriteLine($"Errore nella lettura dei dati della tabella: ${table.name} in riga: ${i}");
                            Console.WriteLine($"Messaggio errore: ${e.Message}");
                        }
                        
                        i++;
                    }
                }
            }
            //Add the last table that was read, since it's out of the loop it can not add the last table which was placed at the start of the loop when a new table was read
            tables.Add(table);
            return tables;
        }
        
        /// <summary>
        /// Close up the file and free up the memory 
        /// </summary>
        public void CloseFile() {
            excel.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
        }
    }
}
