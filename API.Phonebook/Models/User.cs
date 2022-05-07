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
        [BsonElement("Email")]
        public string Email { get; set; }
        [BsonElement("FirstName")]
        public string FirstName { get; set; }
        [BsonElement("LastName")]
        public string LastName { get; set; }
        [BsonElement("MiddleName")]
        public string MiddleName { get; set; }
        [BsonElement("CreatedDateTime")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedDateTime { get; set; }
        [BsonElement("IsAdmin")]
        [BsonRepresentation(BsonType.Boolean)]
        public bool IsAdmin { get; set; }
        [BsonElement("IsEnable")]
        [BsonRepresentation(BsonType.Boolean)]
        public bool IsEnable { get; set; }
        [BsonElement("Phonebook")]
        public Phonebook Phonebooks { get; set; }
    }
}