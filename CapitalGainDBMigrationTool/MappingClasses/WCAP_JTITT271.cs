using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitalGainDBMigrationTool.MappingClasses
{
    class WCAP_JTITT271
    {
        [BsonId]
        public ObjectId id;
        [BsonElement("IST")]
        public int ist;
        [BsonElement("NDG")]
        public string ndg;
        [BsonElement("DES_NDG")]
        public string des_ndg;
        [BsonElement("NDG_COIN")]
        public string ndg_coin;
        [BsonElement("X_INS")]
        public string x_ins;
        [BsonElement("X_AGG")]
        public string x_agg;

        public WCAP_JTITT271(int ist, string ndg, string des_ndg, string ndg_coin,
                            string x_ins = "", string x_agg = "") {
            this.ist = ist;
            this.ndg = ndg;
            this.des_ndg = ndg;
            this.ndg_coin = ndg_coin;
            this.x_ins = x_ins;
            this.x_agg = x_agg;
        }
    }
}
