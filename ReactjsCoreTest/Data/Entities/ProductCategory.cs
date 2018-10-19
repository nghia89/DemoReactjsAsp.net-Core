using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using ReactjsCoreTest.Data.Enums;
using ReactjsCoreTest.Data.Interfaces;
using ReactjsCoreTest.Infrastrusture.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactjsCoreTest.Data.Entities
{
  public  class ProductCategory : IHasSeoMetaData, ISwitchable, IDateTracking
    {
        //public ProductCategory()
        //{
        //    Products = new List<Product>();
        //}
        //public ProductCategory(string name, string description, int? parentId, int? homeOrder,
        //    string image, bool? homeFlag, int sortOrder, Status status, string seoPageTitle, string seoAlias,
        //    string seoKeywords, string seoDescription)
        //{
        //    Name = name;
        //    Description = description;
        //    ParentId = parentId;
        //    HomeOrder = homeOrder;
        //    Image = image;
        //    HomeFlag = homeFlag;
        //    SortOrder = sortOrder;
        //    Status = status;
        //    SeoPageTitle = seoPageTitle;
        //    SeoAlias = seoAlias;
        //    SeoKeywords = seoKeywords;
        //    SeoDescription = seoDescription;
        //}
        [BsonId]
        public ObjectId Id { get; set; }

        public Guid GuiId { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public string Description { get; set; }

        public int? ParentId { get; set; }

        public int? HomeOrder { get; set; }

        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        [BsonDateTimeOptions]
        public DateTime DateCreate { set; get; }

        [BsonDateTimeOptions]
        public DateTime DateModified { set; get; }

        public Status Status { set; get; }
        public string SeoPageTitle { set; get; }
        public string SeoAlias { set; get; }
        public string SeoKeywords { set; get; }
        public string SeoDescription { set; get; }
        public int SortOrder { set; get; }
        public  ICollection<Product> Products { set; get; }
    }
}
