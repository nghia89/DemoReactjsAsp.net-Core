using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using ReactjsCoreTest.Data.Entities;
using ReactjsCoreTest.Infrastrusture.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactjsCoreTest.Data.Entities
{
  public  class ProductTag 
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public Guid GuiId { get; set; } = Guid.NewGuid();

        public int ProductId { get; set; }
        public string TagId { set; get; }

        public Product Product { set; get; }

        public  Tag Tag { set; get; }
    }
}
