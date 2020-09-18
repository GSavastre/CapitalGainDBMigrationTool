using System;
using System.Collections.Generic;

namespace CapitalGainDBMigrationTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region testing
            DBInteraction.Connect();

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
