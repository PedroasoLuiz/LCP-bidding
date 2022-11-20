using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using Projeto01.Model;

namespace Projeto01
{
    internal class MongoUtil
    {
        MongoClient mongoClient;
        IMongoDatabase mongoDatabase;
        IMongoCollection<UserManager> mongoCollection;

        public MongoUtil()
        {
            mongoClient = new MongoClient("mongodb + srv://LCP-Licitacoes:<mongo123>@cluster0.hztehbs.mongodb.net/?retryWrites=true&w=majority");
            mongoDatabase = mongoClient.GetDatabase("LCP-bidding");
            MongoCollection = mongoDatabase.GetCollection<UserManager>("Imagem");
        }

        internal IMongoCollection<UserManager> MongoCollection { get => mongoCollection; set => mongoCollection = value; }
    }
}
