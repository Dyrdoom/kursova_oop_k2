using kursova.Models;
using System.Collections.Generic;

namespace kursova.Services.Interfaces
{
    public interface IPurchaseService
    {
        bool BuyProduct(int userId, int productId, int quantity);
        IEnumerable<Purchase> GetUserPurchaseHistory(int userId);
    }
}
