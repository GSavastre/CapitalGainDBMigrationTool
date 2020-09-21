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

        /// <summary>
        /// Connects to a predefined database.
        /// </summary>
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
                Console.WriteLine("Acquisendo database ...");
                db = client.GetDatabase("capitalgain");

                Console.WriteLine(db.DatabaseNamespace + " - OK\n");
            }
            catch (Exception e) {
                Console.WriteLine("Acquisizione database fallita. " + e.Message);
            }
        }

        /// <summary>
        /// Gets all the users from the "utente" collection.
        /// </summary>
        /// <returns>
        /// Returns a List<Utente>.
        /// </returns>
        public static List<Utente> GetAllUsers() {

            var collectionUtenti = db.GetCollection<Utente>("utente");
            return collectionUtenti.Find(new BsonDocument()).ToList();
        }

        /// <summary>
        /// Adds user to the "utente" collection.
        /// </summary>
        /// <param name="_user"></param>
        /// <returns></returns>
        public static bool AddUser(Utente _user) {

            try {
                var _doc = _user.ToBsonDocument();
                var _collection = db.GetCollection<BsonDocument>("utente");

                _collection.InsertOneAsync(_doc);

                Console.WriteLine("Aggiunto utente : " + _user.userId);
            }
            catch (Exception e) {
                Console.WriteLine("Impossibile aggiungere utente ..." + e.Message);
                return false;
            }

            return true;
        }

    }
}
