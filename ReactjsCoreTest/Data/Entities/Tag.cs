using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactjsCoreTest.Data.Entities
{
  public  class Tag
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public Guid GuiId { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
