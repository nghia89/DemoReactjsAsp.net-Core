using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactjsCoreTest.Infrastrusture.SharedKernel
{
    public interface IDomainEntity
    {
        Guid Id { get; set; }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        string ObjectId { get; set; }
        DateTime DateCreate { get; set; }
        DateTime DateModified { get; set; }
    }
    //public interface DomainEntity<T>
    //{
    //    [BsonId]
    //    [BsonRepresentation(BsonType.ObjectId)]
    //    T Id { get; set; }
    //    [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
    //    DateTime DateCreate { get; set; }

    //    [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
    //    DateTime DateModified { get; set; }
    //}
    //public interface DomainEntity : DomainEntity<string>
    //{
}