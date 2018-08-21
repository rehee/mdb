using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CsharmMongoDB
{
  public class Connextion
  {
    public static void Get()
    {
      var client = new MongoClient("mongodb://localhost:27017");
      var database = client.GetDatabase("foo");
      var collection = database.GetCollection<BsonDocument>("bar");
      for (var i = 0; i < 1; i++)
      {
        var m = new ModuleA();
        m.Name = "name " + i.ToString();
        m.Time = DateTime.Now;
        m.Count = i;
        var d = m.ToBsonDocument();
        //collection.InsertOne(m.ToBsonDocument());
      }



      //var b = m.ToBsonDocument();
      //var jsonWriterSettings = new MongoDB.Bson.IO.JsonWriterSettings
      //{
      //  OutputMode = MongoDB.Bson.IO.JsonOutputMode.Strict,
      //};
      ////var json = b.ToJson(jsonWriterSettings);
      //var aa = collection.Find(new BsonDocument()).FirstOrDefault();
      //var j = "";
      //foreach(var e in aa.Elements)
      //{
      //  var aaa = e;
      //  var name = aaa.Name;
      //  var value = aaa.Value;
      //  var a = 1;
      //}
      //var back = BsonSerializer.Deserialize<ModuleA>(aa);

      //PropertyInfo[] properties = m.GetType().GetProperties();
      //foreach (PropertyInfo property in properties)
      //{
      //  //property.GetValue();
      //}



      //var tryCast = back;
      //var back = JsonConvert.DeserializeObject<ModuleA>(aa);
      //collection.InsertOne(b);
      //var jj = JsonConvert.SerializeObject(back);
      //var jjBack = JsonConvert.DeserializeObject<ModuleA>(jj);
      object min = 10;
      var filter = Builders<BsonDocument>.Filter.Gt("Count", min);
      //var filter2 = Builders<BsonDocument>.Filter.Gt("Count", 20);
      var filterJson = filter.ToJson();
      var items = collection.Find(filter).ToList();
      var newItem = new { Name = "Name Update" }.ToBsonDocument();
      collection.UpdateMany(new { Count = 2 }.ToBsonDocument(), new BsonDocument { { "$set", newItem } });
      Console.Write(123);
    }

  }
}
