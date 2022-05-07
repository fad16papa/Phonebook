using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Phonebook.Models;
using API.Phonebook.Repository.Interfaces;

namespace API.Phonebook.Repository.Services
{
    public class UserRepository : IUserRepository
    {
        public Task CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser(string id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUserNameByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}