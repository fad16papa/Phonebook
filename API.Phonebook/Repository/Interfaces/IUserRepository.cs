using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Phonebook.Models;

namespace API.Phonebook.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(string id);
        Task<IEnumerable<User>> GetUserNameByEmail(string email);
        Task CreateUser(User user);
        Task<bool> UpdateUser(User user);
        Task<bool> DeleteUser(string id);
    }
}