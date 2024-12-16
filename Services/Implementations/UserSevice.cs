using kursova.Models;
using kursova.Repositories.Interfaces;
using kursova.Services.Interfaces;
using System;

namespace kursova.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public User RegisterUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new Exception("iм'я користувача не може бути порожнiм.");
            
            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Пароль не може бути порожнiм.");

            var existingUser = _userRepo.GetUserByUsername(username);
            if (existingUser != null)
            {
                throw new Exception("Користувач з таким iм'ям вже iснує.");
            }

            var user = new User { Username = username, Password = password };
            _userRepo.AddUser(user);
            return user;
        }

        public User LoginUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new Exception("iм'я користувача не може бути порожнiм.");

            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Пароль не може бути порожнiм.");

            var user = _userRepo.GetUserByUsername(username);
            if (user == null || user.Password != password)
            {
                throw new Exception("Невiрнi данi для входу.");
            }

            return user;
        }

        public void AddBalance(int userId, decimal amount)
        {
            var user = _userRepo.GetUserById(userId);
            if (user == null) 
                throw new Exception("Користувача не знайдено.");

            user.Balance += amount;
        }

        public User GetUserById(int userId)
        {
            return _userRepo.GetUserById(userId);
        }
    }
}
