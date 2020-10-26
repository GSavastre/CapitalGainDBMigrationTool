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

    }
}
