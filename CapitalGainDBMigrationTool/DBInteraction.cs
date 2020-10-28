using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using CapitalGainDBMigrationTool.MappingClasses;
using Microsoft.IdentityModel.Protocols;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
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
        public static Utente TryLogin(string _id, string _pwd)
        {
            var _collectionUtenti = db.GetCollection<Utente>("Utente");

            var _filter = Builders<Utente>.Filter.Eq("USERID", _id) &
                        Builders<Utente>.Filter.Eq("PASSWORD", _pwd);

            try
            {
                Utente _user = _collectionUtenti.Find(_filter).FirstOrDefault();
                return _user;
            }
            catch
            {
                return null;
            }

        }
        public static void PopulateMenus(List<Menu> menus) {
            try
            {
                var _collection = db.GetCollection<Menu>("Menu");
                _collection.DeleteMany(Builders<Menu>.Filter.Empty);
                _collection.InsertMany(menus);
                Console.WriteLine("Menu aggiunti");
            }
            catch (Exception e) {
                Console.WriteLine($"Errore inserimento menu. {e.Message}");
            }
        }
        public static void AddMenusToAuths()
        {
            List<ObjectId> ids = new List<ObjectId>();
            List<Menu> allMenus = new List<Menu>();
            var _menuCollection = db.GetCollection<Menu>("Menu");
            allMenus = _menuCollection.Find(new BsonDocument()).ToList();

            var _autorizzazioneCollection = db.GetCollection<Autorizzazione>("Autorizzazione");

            var _filter = Builders<Autorizzazione>.Filter.Eq(a => a.nome, "User");

            foreach (Menu _m in allMenus)
            {
                //ids.Add(_m.id);
            }

            var _update = Builders<Autorizzazione>.Update.PushEach(a => a.menu, ids);

            _autorizzazioneCollection.FindOneAndUpdate(_filter, _update);

            Console.WriteLine("----valori aggiornati----");
        }
        //public static void AddAuthToUser(string _authorizationName, string _userId) {
        //    var _authCol = db.GetCollection<Autorizzazione>("Autorizzazione");
        //    var _filterAuth = Builders<Autorizzazione>.Filter.Eq("NOME", _authorizationName);
        //    Autorizzazione _auth = _authCol.Find(_filterAuth).First();

        //    var _utenteCol = db.GetCollection<Utente>("Utente");
        //    var _filterUtente = Builders<Utente>.Filter.Eq("USERID", _userId);
        //    var _update = Builders<Utente>.Update.Push(u => u.autorizzazioni, _auth.id);

        //    try
        //    {
        //        _utenteCol.FindOneAndUpdate(_filterUtente, _update);
        //        Console.WriteLine($"---- Auth aggiunta ----");
        //    }
        //    catch (Exception e) {
        //        Console.WriteLine($"Errore nell'aggiunta auth. {e.Message}");
        //    }
            

        //}
        public static List<Autorizzazione> GetAllAuth()
        {
            var _collectionAuth = db.GetCollection<Autorizzazione>("Autorizzazione");
            return _collectionAuth.Find(new BsonDocument()).ToList();
        }
        public static List<Menu> GetUserMenus(string _role, ObjectId _istitute) {

            List<Menu> menus = new List<Menu>();

            var _insCol = db.GetCollection<Istituto>("Istituto");
            var _filterIns = Builders<Istituto>.Filter.Eq(i => i.Id, _istitute);

            Istituto _i = _insCol.Find(_filterIns).FirstOrDefault();

            foreach (Profilo _p in _i.profili) {
                if (_p.descrizione == _role) {
                    foreach (SubMenu _sm in _p.menu) {
                        var _colMenu = db.GetCollection<Menu>("Menu");
                        var _filterMenu = Builders<Menu>.Filter.Eq("Id", _sm.Id);

                        Menu _m = _colMenu.Find(_filterMenu).First();
                        menus.Add(_m);
                    }
                }
            }

            return menus;
        }

        public static List<Menu> GetMenus(ObjectId id) {
            var _colMenu = db.GetCollection<Menu>("Menu");
            var _filterMenu = Builders<Menu>.Filter.Eq("Id", id);
            
            return _colMenu.Find(_filterMenu).ToList();
        }

        #region ...

        /// <summary>
        /// Creates a collection with the given name
        /// </summary>
        /// <param name="_table"></param>
        /// <returns></returns>
        //public static bool CreateCollection(Table _table) {
        //    try {
        //        db.CreateCollection(_table.name);
        //        Console.WriteLine("Collection creata : " + _table);
        //    }
        //    catch (Exception _e) {
        //        Console.WriteLine("Impossible creare collection ..." + _e.Message);
        //        return false;
        //    }
            
        //    return true;
        //}

        ///// <summary>
        ///// Creates the collections with the given names
        ///// </summary>
        ///// <param name="_tables"></param>
        ///// <returns></returns>
        //public static bool CreateCollections(List<Table> _tables)
        //{
        //    try
        //    {
        //        foreach (Table _t in _tables) {
        //            db.CreateCollection(_t.id);
        //            Console.WriteLine("Collection creata : " + _t.id);
        //        }
        //    }
        //    catch (Exception _e)
        //    {
        //        Console.WriteLine("Impossible creare collection ..." + _e.Message);
        //        return false;
        //    }

        //    return true;
        //}

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

            var _collectionUtenti = db.GetCollection<Utente>("Utente");
            return _collectionUtenti.Find(new BsonDocument()).ToList();
        }
        public static Utente GetUserDetails(string _userId) {
            var _utenteCol = db.GetCollection<Utente>("Utente");
            var _filterUtente = Builders<Utente>.Filter.Eq("USERID", _userId);

            return _utenteCol.Find(_filterUtente).First();
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

        #endregion

    }
}
