using CapitalGainDBMigrationTool.MappingClasses;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace CapitalGainDBMigrationTool
{
    static class DBCInteraction
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["MongoDBC"].ConnectionString;
        private static MongoClient client;
        private static IMongoDatabase db;

        /// <summary>
        /// Connects to a predefined database.
        /// </summary>
        public static bool Connect()
        {

            //connessione al cluster atlas
            try
            {
                Console.WriteLine("DBInteraction - tentativo di connessione ...");
                client = new MongoClient(connectionString);

                Console.WriteLine(" - OK");

            }
            catch (Exception _e)
            {
                Console.WriteLine("Connessione al server fallita." + _e.Message);
                return false;
            }

            //acquisizione del database "capitalgain"
            try
            {
                Console.WriteLine("Acquisendo database ...");
                db = client.GetDatabase("capitalgain_chain");

                Console.WriteLine(db.DatabaseNamespace + " - OK\n");
            }
            catch (Exception _e)
            {
                Console.WriteLine("Acquisizione database fallita. " + _e.Message);
                return false;
            }

            return true;
        }

        #region 003
        public static bool Insert_WCAP003(WCAP_JTGTT003 record)
        {
            var _003Col = db.GetCollection<WCAP_JTGTT003>("WCAP_JTGTT003");

            try
            {
                _003Col.InsertOne(record);
                Console.WriteLine("Inserito record in 003");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Errore in inserimento 003 {e.Message}");
                return false;
            }
        }

        public static bool Insert_WCAP003s(List<WCAP_JTGTT003> records)
        {
            db.DropCollection("WCAP_JTGTT007");
            var _003Col = db.GetCollection<WCAP_JTGTT003>("WCAP_JTGTT003");

            try
            {
                _003Col.InsertMany(records);
                Console.WriteLine("Inseriti records in 003");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Errore in inserimento 003 {e.Message}");
                return false;
            }
        }

        #endregion

        #region 005
        public static bool Insert_WCAP005(WCAP_JTGTT005 record)
        {
            var _005Col = db.GetCollection<WCAP_JTGTT005>("WCAP_JTGTT005");

            try
            {
                _005Col.InsertOne(record);
                Console.WriteLine("Inserito record in 005");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Errore in inserimento 005 {e.Message}");
                return false;
            }
        }

        public static bool Insert_WCAP005s(List<WCAP_JTGTT005> records)
        {
            //db.DropCollection("WCAP_JTGTT005");
            var _005Col = db.GetCollection<WCAP_JTGTT005>("WCAP_JTGTT005");

            try
            {
                _005Col.InsertMany(records);
                Console.WriteLine("Inseriti records in 005");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Errore in inserimento 005 {e.Message}");
                return false;
            }
        }
        #endregion

        #region 006
        public static bool Insert_WCAP006(WCAP_JTGTT006 record)
        {
            var _006Col = db.GetCollection<WCAP_JTGTT006>("WCAP_JTGTT006");

            try
            {
                _006Col.InsertOne(record);
                Console.WriteLine("Inserito record in 006");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Errore in inserimento 006 {e.Message}");
                return false;
            }
        }

        public static bool Insert_WCAP006s(List<WCAP_JTGTT006> records)
        {
            var _006Col = db.GetCollection<WCAP_JTGTT006>("WCAP_JTGTT006");

            try
            {
                _006Col.InsertMany(records);
                Console.WriteLine("Inseriti records in 006");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Errore in inserimento 006 {e.Message}");
                return false;
            }
        }
        #endregion

        #region 007
        public static List<WCAP_JTGTT007> Get_WCAP007() {
            var _007Col = db.GetCollection<WCAP_JTGTT007>("WCAP_JTGTT007");

            return _007Col.Find(new BsonDocument()).ToList();
        }

        public static bool Insert_WCAP007(WCAP_JTGTT007 record)
        {
            var _007Col = db.GetCollection<WCAP_JTGTT007>("WCAP_JTGTT007");

            try
            {
                _007Col.InsertOne(record);
                Console.WriteLine("Inserito record in 007");
                return true;
            }
            catch (Exception e){
                Console.WriteLine($"Errore in inserimento 007 {e.Message}");
                return false;
            }
        }

        public static bool Insert_WCAP007s(List<WCAP_JTGTT007> records)
        {
            var _007Col = db.GetCollection<WCAP_JTGTT007>("WCAP_JTGTT007");

            try
            {
                _007Col.InsertMany(records);
                Console.WriteLine("Inserito record in 007");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Errore in inserimento 007 {e.Message}");
                return false;
            }
        }

        #endregion

        #region 270
        public static bool Insert_WCAP270(WCAP_JTITT270 record)
        {
            var _270Col = db.GetCollection<WCAP_JTITT270>("WCAP_JTITT270");

            try
            {
                _270Col.InsertOne(record);
                Console.WriteLine("Inserito record in 270");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Errore in inserimento 270 {e.Message}");
                return false;
            }
        }

        public static bool Insert_WCAP270s(List<WCAP_JTITT270> records)
        {
            var _270Col = db.GetCollection<WCAP_JTITT270>("WCAP_JTITT270");

            try
            {
                _270Col.InsertMany(records);
                Console.WriteLine("Inseriti records in 270");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Errore in inserimento 270 {e.Message}");
                return false;
            }
        }
        #endregion

        #region 271
        public static bool Insert_WCAP271(WCAP_JTITT271 record)
        {
            var _271Col = db.GetCollection<WCAP_JTITT271>("WCAP_JTITT271");

            try
            {
                _271Col.InsertOne(record);
                Console.WriteLine("Inserito record in 271");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Errore in inserimento 271 {e.Message}");
                return false;
            }
        }

        public static bool Insert_WCAP271s(List<WCAP_JTITT271> records)
        {
            var _271Col = db.GetCollection<WCAP_JTITT271>("WCAP_JTITT271");

            try
            {
                _271Col.InsertMany(records);
                Console.WriteLine("Inseriti records in 271");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Errore in inserimento 271 {e.Message}");
                return false;
            }
        }
        #endregion

    }
}
