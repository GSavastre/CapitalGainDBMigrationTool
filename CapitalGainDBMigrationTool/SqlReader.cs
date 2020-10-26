using CapitalGainDBMigrationTool.MappingClasses;
using MongoDB.Bson.Serialization.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Text;

namespace CapitalGainDBMigrationTool
{
    static class SqlReader
    {
        //menu table
        const int MENU_TRANSAZIONE = 10;
        const int MENU_PADRE = 14;
        const int DESCR_SELETTORE = 11;
        const int DESCR_TRANSAZIONE = 12;
        const int LINK = 13;
        const int ORDINAMENTO = 15;
        const int QUICK_LAUNCH = 16;
        const int LINK_ACTION = 17;
        const int LINK_CONTROLLER = 18;

        //auth table
        const int AUTH_PARENT = 11;
        const int AUTH_TRANSAZIONE = 10;
        const int AUTH_COMANDO = 12;
        const int AUTH_DESCR = 13;
        const int AUTH_CONTROLLER = 14;
        const int AUTH_ACTION = 15;
        const int AUTH_GRANT_LEVEL = 16;

        static bool found = false;

        public static List<Menu> ElaborateMenuInserts() {
            Console.WriteLine($"Elaborating sql file...");
            List<Menu> m = new List<Menu>();
            string _filePath = @"C:\Users\cosmi\Desktop\schema_dati.sql";
            
            using (StreamReader _reader = new StreamReader(_filePath)) {
                string _line;
                string[] _subLine;
                while ((_line = _reader.ReadLine()) != null) {
                    if (_line.Contains("INSERT")) {
                        _subLine = _line.Split(",");
                        if (_subLine[0].Contains("Menu")) {

                            if (ClearData(_subLine[MENU_PADRE]) == "*")
                            {
                                foreach (Menu _m in m)
                                {
                                    if (_m.nome == ClearData(_subLine[MENU_TRANSAZIONE]))
                                    {
                                        break;
                                    }
                                }

                                Menu newMenu = new Menu(ClearData(_subLine[MENU_TRANSAZIONE]), ClearData(_subLine[DESCR_SELETTORE]),
                                    ClearData(_subLine[DESCR_TRANSAZIONE]), ClearData(_subLine[LINK]), ClearData(_subLine[LINK_ACTION]),
                                    ClearData(_subLine[LINK_CONTROLLER]), ClearData(_subLine[QUICK_LAUNCH]), Int32.Parse(ClearData(_subLine[ORDINAMENTO])));

                                MenuIntegrityCheck(newMenu);

                                m.Add(newMenu);

                            }
                            #region else
                            /*else {
                                foreach (Menu _m in m) {
                                    found = false;
                                    
                                    if (_m.Transazione == ClearData(_subLine[MENU_PADRE]))
                                    {
                                        Menu newMenu = new Menu(ClearData(_subLine[MENU_TRANSAZIONE]), ClearData(_subLine[DESCR_SELETTORE]),
                                            ClearData(_subLine[DESCR_TRANSAZIONE]), ClearData(_subLine[LINK]), ClearData(_subLine[LINK_ACTION]),
                                            ClearData(_subLine[LINK_CONTROLLER]), ClearData(_subLine[QUICK_LAUNCH]), ClearData(_subLine[ORDINAMENTO]));
                                        MenuIntegrityCheck(newMenu);

                                        _m.Children.Add(newMenu);
                                        
                                        found = true;
                                    }
                                    else {
                                        foreach (Menu _sm in _m.Children) {
                                            Menu menuToSearch = new Menu(ClearData(_subLine[MENU_TRANSAZIONE]), ClearData(_subLine[DESCR_SELETTORE]),
                                            ClearData(_subLine[DESCR_TRANSAZIONE]), ClearData(_subLine[LINK]), ClearData(_subLine[LINK_ACTION]),
                                            ClearData(_subLine[LINK_CONTROLLER]), ClearData(_subLine[QUICK_LAUNCH]), ClearData(_subLine[ORDINAMENTO]));
                                            MenuIntegrityCheck(menuToSearch);

                                            CheckIfMenuExistsInSubMenuAndAdd(_sm, ClearData(_subLine[MENU_PADRE]), menuToSearch);

                                            if (found)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }
                            }*/
                            #endregion
                        }
                    }
                }
            }

            using (StreamReader _reader = new StreamReader(_filePath))
            {
                string _line;
                string[] _subLine;
                while ((_line = _reader.ReadLine()) != null)
                {
                    if (_line.Contains("INSERT"))
                    {
                        _subLine = _line.Split(",");
                        if (_subLine[0].Contains("Autorizzazione"))
                        {

                            if (ClearData(_subLine[AUTH_PARENT]) != "ULL")
                            {
                                found = false;
                                foreach (Menu _m in m)
                                {
                                    if (_m.nome == ClearData(_subLine[AUTH_PARENT]))
                                    {

                                        MenuChild mc = new MenuChild(ClearData(_subLine[AUTH_TRANSAZIONE]), ClearData(_subLine[AUTH_COMANDO]), 
                                            ClearData(_subLine[AUTH_DESCR]), ClearData(_subLine[AUTH_CONTROLLER]), ClearData(_subLine[AUTH_ACTION]), 
                                            ClearData(_subLine[AUTH_GRANT_LEVEL]));

                                        _m.children.Add(mc);
                                        found = true;
                                        break;
                                    }

                                    if (!found) {
                                        MenuChild mc = new MenuChild(ClearData(_subLine[AUTH_TRANSAZIONE]), ClearData(_subLine[AUTH_COMANDO]),
                                            ClearData(_subLine[AUTH_DESCR]), ClearData(_subLine[AUTH_CONTROLLER]), ClearData(_subLine[AUTH_ACTION]),
                                            ClearData(_subLine[AUTH_GRANT_LEVEL]));

                                        foreach (MenuChild _cm in _m.children) {
                                            CheckIfMenuExistsInMenuChildAndAdd(_cm ,ClearData(_subLine[AUTH_PARENT]), mc);
                                        }
                                    }
                                }
                                
                            }
                            #region else
                            /*else {
                                foreach (Menu _m in m) {
                                    found = false;
                                    
                                    if (_m.Transazione == ClearData(_subLine[MENU_PADRE]))
                                    {
                                        Menu newMenu = new Menu(ClearData(_subLine[MENU_TRANSAZIONE]), ClearData(_subLine[DESCR_SELETTORE]),
                                            ClearData(_subLine[DESCR_TRANSAZIONE]), ClearData(_subLine[LINK]), ClearData(_subLine[LINK_ACTION]),
                                            ClearData(_subLine[LINK_CONTROLLER]), ClearData(_subLine[QUICK_LAUNCH]), ClearData(_subLine[ORDINAMENTO]));
                                        MenuIntegrityCheck(newMenu);

                                        _m.Children.Add(newMenu);
                                        
                                        found = true;
                                    }
                                    else {
                                        foreach (Menu _sm in _m.Children) {
                                            Menu menuToSearch = new Menu(ClearData(_subLine[MENU_TRANSAZIONE]), ClearData(_subLine[DESCR_SELETTORE]),
                                            ClearData(_subLine[DESCR_TRANSAZIONE]), ClearData(_subLine[LINK]), ClearData(_subLine[LINK_ACTION]),
                                            ClearData(_subLine[LINK_CONTROLLER]), ClearData(_subLine[QUICK_LAUNCH]), ClearData(_subLine[ORDINAMENTO]));
                                            MenuIntegrityCheck(menuToSearch);

                                            CheckIfMenuExistsInSubMenuAndAdd(_sm, ClearData(_subLine[MENU_PADRE]), menuToSearch);

                                            if (found)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }
                            }*/
                            #endregion
                        }
                    }
                }
            }

            return m;
        }

        private static void CheckIfMenuExistsInMenuChildAndAdd(MenuChild _sm, string _parent, MenuChild _toSearch)
        {
            if (_sm.Nome == _parent)
            {
                _sm.Children.Add(_toSearch);
                found = true;
            }
            else
            {
                if (_sm.Children.Count > 0)
                {
                    foreach (MenuChild __sm in _sm.Children)
                    {
                        CheckIfMenuExistsInMenuChildAndAdd(__sm, _parent, _toSearch);
                    }
                }
            }
        }

        private static string ClearData(string _data) {
            string _clearData;
            _clearData = _data.Substring(2);
            _clearData = _clearData.Trim('\'');

            if (_clearData.Contains("')")) {
                _clearData = _clearData.TrimEnd('\'', ')');
            }
            return _clearData;
        }
        private static string ClearNullData(string _data)
        {
            string _clearData;
            _clearData = _data.Substring(1);
            return _clearData;
        }

        private static void MenuIntegrityCheck(Menu m) {
            if (m.quickL == "ULL") {
                m.quickL = null;
            }
            if (m.action == "ULL") {
                m.action = null;
            }
            if (m.controller == "ULL") {
                m.controller = null;
            }
            if (m.link == "ULL") {
                m.link = null;
            }
        }
    }
}
