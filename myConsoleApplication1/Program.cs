using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace myConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("RepoDB");
            var collection = db.GetCollection<User>("users");
            var user1 = new User
            {
                Username ="kalyan",
                password="kal123",
                role="admin"

            };

            collection.InsertOne(user1);
        }
    }
    public class User
    {
        public ObjectId Id {get; set;}
        public string Username { get; set; }
        public string password { get; set; }
        public string role { get; set; }

    }
}
