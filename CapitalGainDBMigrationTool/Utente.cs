using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace CapitalGainDBMigrationTool
{
    class Utente
    {
        [BsonId]
        public ObjectId id { get; }
        [BsonElement("USERID")]
        public string userId { get; set; }
        [BsonElement("PASSWORD")]
        public string password { get; set; }
        [BsonElement("DESCRIZIONE")]
        public string descrizione { get; set; }
        [BsonElement("ISTITUTO")]
        public string istituto { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_userId"></param>
        /// <param name="_password"></param>
        /// <param name="_descrizione"></param>
        /// <param name="_istituto"></param>
        public Utente(string _userId, string _password, string _descrizione, string _istituto) {
            userId = _userId;
            password = _password;
            descrizione = _descrizione;
            istituto = _istituto;
        }

        /// <summary>
        /// Constructor with only 1 parameter. Used for testing.
        /// </summary>
        /// <param name="_userId"></param>
        public Utente(string _userId) {
            userId = _userId;
            password = "";
            descrizione = "";
            istituto = "";
        }

    }
}
