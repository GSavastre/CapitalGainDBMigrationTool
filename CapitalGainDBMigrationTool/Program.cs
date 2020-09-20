using System;
using System.Collections.Generic;

namespace CapitalGainDBMigrationTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DBInteraction.Connect();

            #region testing

            List<Utente> utenti = DBInteraction.GetAllUsers();
            Console.WriteLine("Utenti trovati : " + utenti.Count);

            foreach (Utente u in utenti)
            {
                Console.WriteLine(u.userId);
            }

            #endregion 

        }
    }
}
