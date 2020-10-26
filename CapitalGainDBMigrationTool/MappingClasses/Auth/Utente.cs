using CapitalGainDBMigrationTool.MappingClasses;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;

namespace CapitalGainDBMigrationTool
{
    class Utente
    {
        [BsonId]
        public ObjectId id;
        [BsonElement("USERID")]
        public string userId;
        [BsonElement("PASSWORD")]
        public string password;
        [BsonElement("DESCRIZIONE")]
        public string descrizione;
        [BsonElement("ISTITUTO")]
        public int istituto;
        [BsonElement("UFFICIO")]
        public string ufficio;
        [BsonElement("CODICE")]
        public string codice;
        [BsonElement("DATA_ACCESSO")]
        public string data_accesso;
        [BsonElement("ORA_ACCESSO")]
        public string ora_accesso;
        [BsonElement("EMAIL")]
        public string email;
        [BsonElement("INFO_INSERIMENTO")]
        public string info_inserimento;
        [BsonElement("INFO_AGGIORNAMENTO")]
        public string info_aggiornamento;

        public Utente() { }

    }
}
