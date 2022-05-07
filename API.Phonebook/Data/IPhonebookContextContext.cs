using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Phonebook.Models;
using MongoDB.Driver;

namespace API.Phonebook.Data
{
    public interface IPhonebookContext
    {
        IMongoCollection<User> Users { get; }
        IMongoCollection<Models.Phonebook> Phonebooks { get; }
        IMongoCollection<Address> Address { get; }
    }
}