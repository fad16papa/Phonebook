using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.Phonebook.Models
{
    public class Phonebook
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("WorkNumber")]
        public string WorkNumber { get; set; }
        [BsonElement("HomeNumber")]
        public string HomeNumber { get; set; }
        [BsonElement("BusinessNumber")]
        public string BusinessNumber { get; set; }
        [BsonElement("CreatedDateTime")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedDateTime { get; set; }
    }
}