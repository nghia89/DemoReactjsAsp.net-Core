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
    public class Product : IDomainEntity, ISwitchable, IDateTracking, IHasSeoMetaData
    {
        //public Product()
        //{
        //    ProductTags = new List<ProductTag>();
        //}

        //public Product(string name, int categoryId, string thumbnailImage,
        //    decimal price, decimal originalPrice, decimal? promotionPrice,
        //    string description, string content, bool? homeFlag, bool? hotFlag,
        //    string tags, string unit, Status status, string seoPageTitle,
        //    string seoAlias, string seoMetaKeyword,
        //    string seoMetaDescription)
        //{
        //    Name = name;
        //    CategoryId = categoryId;
        //    Image = thumbnailImage;
        //    Price = price;
        //    OriginalPrice = originalPrice;
        //    PromotionPrice = promotionPrice;
        //    Description = description;
        //    Content = content;
        //    HomeFlag = homeFlag;
        //    HotFlag = hotFlag;
        //    Tags = tags;
        //    Unit = unit;
        //    Status = status;
        //    SeoPageTitle = seoPageTitle;
        //    SeoAlias = seoAlias;
        //    SeoKeywords = seoMetaKeyword;
        //    SeoDescription = seoMetaDescription;
        //    ProductTags = new List<ProductTag>();
        //}

        //public Product(ObjectId id, string name, int categoryId, string thumbnailImage,
        //     decimal price, decimal originalPrice, decimal? promotionPrice,
        //     string description, string content, bool? homeFlag, bool? hotFlag,
        //     string tags, string unit, Status status, string seoPageTitle,
        //     string seoAlias, string seoMetaKeyword,
        //     string seoMetaDescription)
        //{
        //    Id = id;
        //    Name = name;
        //    CategoryId = categoryId;
        //    Image = thumbnailImage;
        //    Price = price;
        //    OriginalPrice = originalPrice;
        //    PromotionPrice = promotionPrice;
        //    Description = description;
        //    Content = content;
        //    HomeFlag = homeFlag;
        //    HotFlag = hotFlag;
        //    Tags = tags;
        //    Unit = unit;
        //    Status = status;
        //    SeoPageTitle = seoPageTitle;
        //    SeoAlias = seoAlias;
        //    SeoKeywords = seoMetaKeyword;
        //    SeoDescription = seoMetaDescription;
        //    ProductTags = new List<ProductTag>();
        //}
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ObjectId { get; set; }

        public Guid Id { get; set; } = Guid.NewGuid();
       
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public decimal Price { get; set; }
        public decimal? PromotionPrice { get; set; }

        public decimal OriginalPrice { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public bool? HomeFlag { get; set; }

        public bool? HotFlag { get; set; }

        public string Image { get; set; }

        public int? ViewCount { get; set; }

        public string Tags { get; set; }

        public string Unit { get; set; }

        public  ProductCategory ProductCategory { set; get; }

        public virtual ICollection<ProductTag> ProductTags { set; get; }

        public string SeoPageTitle { set; get; }
        public string SeoAlias { set; get; }

        public string SeoKeywords { set; get; }

        public string SeoDescription { set; get; }

        [BsonDateTimeOptions(DateOnly = false, Kind = DateTimeKind.Utc, Representation = BsonType.String)]
        public DateTime DateCreate { set; get; } = DateTime.UtcNow;

        [BsonDateTimeOptions(DateOnly = false, Kind = DateTimeKind.Utc, Representation = BsonType.String)]
        public DateTime DateModified { set; get; } = DateTime.UtcNow;

        public Status Status { set; get; }
    }
}
