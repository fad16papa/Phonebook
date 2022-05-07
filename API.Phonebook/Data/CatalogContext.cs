using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Phonebook.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace API.Phonebook.Data
{
    public class CatalogContext : ICatalogContext
    {
        private readonly IConfiguration _configuration;
        private readonly IMongoClient _mongoClient;

        public CatalogContext(IConfiguration configuration, IMongoClient mongoClient)
        {
            _configuration = configuration;
            _mongoClient = mongoClient;
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

            Users = database.GetCollection<User>(configuration.GetValue<string>("DatabaseSettings:CollectionNameUser"));
            Phonebooks = database.GetCollection<Models.Phonebook>(configuration.GetValue<string>("DatabaseSettings:CollectionNamePhonebook"));
            Address = database.GetCollection<Address>(configuration.GetValue<string>("DatabaseSettings:CollectionNameAddress"));
        }

        public IMongoCollection<User> Users { get; }
        public IMongoCollection<Models.Phonebook> Phonebooks { get; }
        public IMongoCollection<Address> Address { get; }

    }
}