using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using CapitalGainDBMigrationTool.TableClasses;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace CapitalGainDBMigrationTool
{
    static class DBInteraction
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["MongoDB"].ConnectionString;
        private static MongoClient client;
        private static IMongoDatabase db;

        /// <summary>
        /// Connects to a predefined database.
        /// </summary>
        public static bool Connect() {

            //connessione al cluster atlas
            try {
                Console.WriteLine("DBInteraction - tentativo di connessione ...");
                client = new MongoClient(connectionString);

                Console.WriteLine(" - OK");

            }
            catch (Exception _e) {
                Console.WriteLine("Connessione al server fallita." + _e.Message);
                return false;
            }

            //acquisizione del database "capitalgain"
            try {
                Console.WriteLine("Acquisendo database ...");
                db = client.GetDatabase("capitalgain");

                Console.WriteLine(db.DatabaseNamespace + " - OK\n");
            }
            catch (Exception _e) {
                Console.WriteLine("Acquisizione database fallita. " + _e.Message);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Creates a collection with the given name
        /// </summary>
        /// <param name="_table"></param>
        /// <returns></returns>
        public static bool CreateCollection(Table _table) {
            try {
                db.CreateCollection(_table.name);
                Console.WriteLine("Collection creata : " + _table);
            }
            catch (Exception _e) {
                Console.WriteLine("Impossible creare collection ..." + _e.Message);
                return false;
            }
            
            return true;
        }

        /// <summary>
        /// Creates the collections with the given names
        /// </summary>
        /// <param name="_tables"></param>
        /// <returns></returns>
        public static bool CreateCollections(List<Table> _tables)
        {
            try
            {
                foreach (Table _t in _tables) {
                    db.CreateCollection(_t.name);
                    Console.WriteLine("Collection creata : " + _t.name);
                }
            }
            catch (Exception _e)
            {
                Console.WriteLine("Impossible creare collection ..." + _e.Message);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Inserts the specified record in the specified collection
        /// </summary>
        /// <param name="_collectionName"></param>
        /// <param name="_record"></param>
        /// <returns></returns>
        public static bool AddRecordToCollection(string _collectionName, BsonDocument _record) {
            
            try
            {
                var _collection = db.GetCollection<BsonDocument>(_collectionName);
                _collection.InsertOne(_record);
                Console.WriteLine("Inserito record in " + _collectionName);
            }
            catch (Exception _e) {
                Console.WriteLine("Impossibile aggiungere record a " + _collectionName + "\n" + _e.Message);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Inserts the specified list of records in the specified collection
        /// </summary>
        /// <param name="_collectionName"></param>
        /// <param name="_records"></param>
        /// <returns></returns>
        public static bool AddRecordsToCollection(string _collectionName, List<BsonDocument> _records) {
            
            try
            {
                var _collection = db.GetCollection<BsonDocument>(_collectionName);
                _collection.InsertMany(_records);
                Console.WriteLine("Inseriti records in " + _collectionName);
            }
            catch (Exception _e)
            {
                Console.WriteLine("Impossibile aggiungere records a " + _collectionName + "\n" + _e.Message);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Gets all the users from the "utente" collection.
        /// </summary>
        /// <returns>
        /// Returns a List<Utente>.
        /// </returns>
        public static List<Utente> GetAllUsers() {

            var _collectionUtenti = db.GetCollection<Utente>("utente");
            return _collectionUtenti.Find(new BsonDocument()).ToList();
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
            catch (Exception _e) {
                Console.WriteLine("Impossibile aggiungere utente ..." + _e.Message);
                return false;
            }

            return true;
        }

    }
}
