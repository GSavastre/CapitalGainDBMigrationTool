using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace CapitalGainDBMigrationTool
{
    static class DBInteraction
    {
        private static MongoClient client;
        private static string connectionString = "mongodb+srv://default:default@cluster0.foggv.azure.mongodb.net/capitalgain";
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
