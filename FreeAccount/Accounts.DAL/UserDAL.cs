using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounts.Model.Model;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Accounts.DAL
{
    public class UserDAL
    {
        MongoServer server;
        MongoDatabase db;
        public void CreateUser(UserModel um)
        {
            server = new MongoServer(new MongoServerSettings() { Server = new MongoServerAddress("localhost",27017) });
            db = server.GetDatabase("FreeAccount");
            MongoCollection<BsonDocument> userDetails = db.GetCollection<BsonDocument>("Users");
            userDetails.Insert<UserModel>(um);
        }
    }
}
