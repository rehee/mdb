using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharmMongoDB
{
  [BsonIgnoreExtraElements(ignoreExtraElements: true, Inherited = true)]
  public class BsonBase
  {
    [BsonId(IdGenerator = typeof(BsonObjectIdGenerator))]
    [BsonRepresentation(BsonType.ObjectId)]
    
    public string Id { get; set; } = new ObjectId().ToString();
  }

  public class ModuleA : BsonBase
  {
    public string Name { get; set; }
    public int Count { get; set; }
    public DateTime Time { get; set; }

  }
}
