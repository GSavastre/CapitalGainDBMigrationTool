using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CapitalGainDBMigrationTool
{
    static class DBInteraction
    {
        private static MongoClient client;
        private static string connectionString = ConfigurationManager.ConnectionStrings["MongoDB"].ConnectionString;
        private static IMongoDatabase db;

        public static void Connect() {

            //connessione al cluster atlas
            try {
                Console.WriteLine("DBInteraction - tentativo di connessione ...");
                client = new MongoClient(connectionString);

                Console.WriteLine(" - OK");

            }
            catch (Exception e) {
                Console.WriteLine("Connessione al server fallita." + e.Message);
            }

            //acquisizione del database "capitalgain"
            try {
                Console.WriteLine("Acquisendo database : capitalgain ...");
                db = client.GetDatabase("capitalgain");

                Console.WriteLine(" - OK");
            }
            catch (Exception e) {
                Console.WriteLine("Acquisizione database fallita. " + e.Message);
            }
        }

        public static List<Utente> GetAllUsers() {

            var collectionUtenti = db.GetCollection<Utente>("utente");
            return collectionUtenti.Find(new BsonDocument()).ToList();
        }

    }
}
