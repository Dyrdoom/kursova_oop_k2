using kursova.Data;
using kursova.Models;
using kursova.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace kursova.Repositories.Implementations
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly StoreDbContext _context;
        private static int _lastPurchaseId = 0;

        public PurchaseRepository(StoreDbContext context)
        {
            _context = context;
        }

        public void AddPurchase(Purchase purchase)
        {
            _lastPurchaseId++;
            purchase.Id = _lastPurchaseId;
            _context.Purchases.Add(purchase);
        }

        public IEnumerable<Purchase> GetPurchasesByUserId(int userId)
        {
            return _context.Purchases.ToList().Where(p => p.UserId == userId);
        }
    }
}
