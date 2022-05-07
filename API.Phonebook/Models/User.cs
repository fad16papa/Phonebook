using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.Phonebook.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Email { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedDateTime { get; set; }
        [BsonRepresentation(BsonType.Boolean)]
        public bool IsAdmin { get; set; }
        [BsonRepresentation(BsonType.Boolean)]
        public bool IsEnable { get; set; }
    }
}