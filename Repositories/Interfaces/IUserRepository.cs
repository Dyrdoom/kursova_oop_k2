using kursova.Models;
using System.Collections.Generic;

namespace kursova.Repositories.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);
        User GetUserByUsername(string username);
        User GetUserById(int userId);
        IEnumerable<User> GetAllUsers();
    }
}
