using MongoDB.Driver;
using ReactjsCoreTest.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactjsCoreTest.Infrastrusture.Interfaces
{
   public interface IDBContext
    {
        IMongoCollection<Product> Products { get; }
        IMongoCollection<ProductTag> ProductTags { get; }
        IMongoCollection<ProductCategory> ProductCategorys { get; }
        IMongoCollection<AppUser> AppUsers { get; }
    }
}
