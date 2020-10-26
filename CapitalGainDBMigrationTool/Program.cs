using System;
<<<<<<< Updated upstream
=======
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CapitalGainDBMigrationTool.MappingClasses;
using CapitalGainDBMigrationTool.TableClasses;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Menu = CapitalGainDBMigrationTool.MappingClasses.Menu;
using Range = Microsoft.Office.Interop.Excel.Range;
>>>>>>> Stashed changes

namespace CapitalGainDBMigrationTool
{
    class Program
<<<<<<< Updated upstream
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
=======
    {        
        static void Main(string[] args) {

            #region BATCH CHAIN 
            List<WCAP_JTGTT007> listaMovimentiInput = new List<WCAP_JTGTT007>();

            // 1 STEP
            //load from db 
            //DBCInteraction.Connect();
            //listaMovimentiInput = DBCInteraction.Get_WCAP007();

            //load from file
            listaMovimentiInput.AddRange(FileReader.ReadTxt());
            FileReader.PrintMovementsStatus(listaMovimentiInput);

            // 2 STEP


            #endregion

            //string path = ConfigurationManager.AppSettings["D"];
            //int sheet = 1;

            //ExcelReader reader = new ExcelReader(path, sheet);
            ////reader.DisplayFile(20);
            //List<Table> tables = reader.ReadFile();
            //reader.CloseFile();

            //DBInteraction.Connect();

            //List<Menu> menus = DBInteraction.GetUserMenus("User", ObjectId.Parse("5f86c13b86f28f82c0d341d0"));

            //foreach (Menu m in menus) {
            //    Console.WriteLine(m.ToJson());
            //}

            #region testing login function

            //if (DBInteraction.Connect())
            //{
            //    Utente _u = DBInteraction.TryLogin("DallaglioM", "banana");
            //    Console.WriteLine($"login con {_u.userId}");
            //}
            #endregion

            #region testing populate menu

            //List<Menu> m = SqlReader.ElaborateMenuInserts();
            //DBInteraction.PopulateMenus(m);

            //foreach (Menu _m in m)
            //{
            //    Console.WriteLine($"----{_m.Transazione}----");
            //    foreach (MenuChild mc in _m.Children) {
            //        PrintMenu(mc);
            //    }

            //}

            #endregion

            //foreach (Menu _m in DBInteraction.GetUserMenus("DallaglioM")) {
            //    Console.WriteLine(_m.nome);
            //    if (_m.voci.Count > 0) {
            //        foreach (SubMenu _sm in _m.voci) {
            //            PrintSubMenu(_sm);
            //        }
            //    }
            //}

            //Utente _u = DBInteraction.GetUserDetails("DallaglioM");
            //Console.WriteLine($"User : {_u.userId} : {_u.id}");
            //foreach (ObjectId _oid in _u.autorizzazioni) {
            //    Console.WriteLine($"Auth : {_oid}");
            //}

            //DBInteraction.AddAuthToUser("User", "DallaglioM");

            //DBInteraction.AddMenusToAuths();

            //foreach (Autorizzazione a in DBInteraction.GetAllAuth()) { 
            //    Console.WriteLine($"{a.id} : {a.nome}");
            //    foreach (ObjectId oid in a.menu) {
            //        Console.WriteLine($"\t{oid}");
            //    }
            //}


        }

        public static void PrintMenu(MenuChild _m)
        {
            Console.WriteLine(_m.Nome);
            if (_m.Children.Count > 0)
            {
                foreach (MenuChild __sm in _m.Children)
                {
                    PrintMenu(__sm);
                }
            }
>>>>>>> Stashed changes
        }
    }
}
