using kursova.Models;
using System.Collections.Generic;

namespace kursova.Repositories.Interfaces
{
    public interface IPurchaseRepository
    {
        void AddPurchase(Purchase purchase);
        IEnumerable<Purchase> GetPurchasesByUserId(int userId);
    }
}
