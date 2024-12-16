using kursova.Models;

namespace kursova.Services.Interfaces
{
    public interface IUserService
    {
        User RegisterUser(string username, string password);
        User LoginUser(string username, string password);
        void AddBalance(int userId, decimal amount);
        User GetUserById(int userId);
    }
}
