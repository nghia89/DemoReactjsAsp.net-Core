using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using ReactjsCoreTest.Data.Entities;
using ReactjsCoreTest.Infrastrusture.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactjsCoreTest.EF
{
    public class DBContext: IDBContext
    {
        private IMongoDatabase _database { get; }
        public DBContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _database = client.GetDatabase(options.Value.Database);
            //_configuration = configuration;
            //try
            //{
            //    MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(configuration.GetSection("ConnectionStrings:DefaultConnection").Value));
            //    bool IsSSL = Convert.ToBoolean(configuration.GetSection("ConnectionStrings:IsSSL").Value);
            //    if (IsSSL)
            //    {
            //        settings.SslSettings = new SslSettings { EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12 };
            //    }
            //    var mongoClient = new MongoClient(settings);
            //    _database = mongoClient.GetDatabase(configuration.GetSection("ConnectionStrings:DatabaseName").Value);
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("Can not access to db server.", ex);
            //}
        }
        public IMongoCollection<Product> Products => _database.GetCollection<Product>("Products");

        public IMongoCollection<ProductTag> ProductTags => _database.GetCollection<ProductTag>("ProductTags");

        public IMongoCollection<ProductCategory> ProductCategorys => _database.GetCollection<ProductCategory>("ProductCategorys");

        public IMongoCollection<AppUser> AppUsers => _database.GetCollection<AppUser>("AppUser");

    }
}
