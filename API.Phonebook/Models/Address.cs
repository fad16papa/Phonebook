using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.Phonebook.Models
{
    public class Address
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("UserAddress")]
        public string UserAddress { get; set; }
        [BsonElement("City")]
        public string City { get; set; }
        [BsonElement("Country")]
        public string Country { get; set; }
        [BsonElement("State")]
        public string State { get; set; }
        [BsonElement("PostalCode")]
        public string PostalCode { get; set; }
    }
}