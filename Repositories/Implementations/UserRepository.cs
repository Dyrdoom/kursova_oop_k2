using kursova.Data;
using kursova.Models;
using kursova.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace kursova.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly StoreDbContext _context;
        private static int _lastUserId = 0; 

        public UserRepository(StoreDbContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _lastUserId++;
            user.Id = _lastUserId; 
            _context.Users.Add(user);
        }

        public User GetUserByUsername(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }

        public User GetUserById(int userId)
        {
            return _context.Users.FirstOrDefault(u => u.Id == userId);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
    }
}
