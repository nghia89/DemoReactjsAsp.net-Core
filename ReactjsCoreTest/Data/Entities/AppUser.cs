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
  public  class AppUser : IDateTracking, ISwitchable
    {
        //public AppUser()
        //{
        //}

        //public AppUser(Guid id, string fullName, string userName,
        //    string email, string phoneNumber, string avatar, Status status)
        //{
        //    Id = id;
        //    FullName = fullName;
        //    UserName = userName;
        //    Email = email;
        //    PhoneNumber = phoneNumber;
        //    Avatar = avatar;
        //    Status = status;
        //}

        [BsonId]
        public ObjectId Id { get; set; }

        public Guid GuiId { get; set; } = Guid.NewGuid();

        [BsonElement]
        public string FullName { get; set; }

        [BsonElement]
        public DateTime? BirthDay { set; get; }

        [BsonElement]
        public decimal Balance { get; set; }

        [BsonElement]
        public string Avatar { get; set; }

        [BsonDateTimeOptions]
        // thuộc tính để giành quyền kiểm soát tuần tự hóa ngày giờ
        public DateTime DateCreate { get; set; } = DateTime.Now;

        [BsonDateTimeOptions]
        // thuộc tính để giành quyền kiểm soát tuần tự hóa ngày giờ
        public DateTime DateModified { get; set; } = DateTime.Now;

        [BsonElement]
        public Status Status { get; set; }
   
    }
}
