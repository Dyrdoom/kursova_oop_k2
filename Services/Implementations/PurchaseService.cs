using kursova.Models;
using kursova.Repositories.Interfaces;
using kursova.Services.Interfaces;
using System;

namespace kursova.Services.Implementations
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IPurchaseRepository _purchaseRepo;
        private readonly IUserRepository _userRepo;
        private readonly IProductRepository _productRepo;

        public PurchaseService(IPurchaseRepository purchaseRepo, IUserRepository userRepo, IProductRepository productRepo)
        {
            _purchaseRepo = purchaseRepo;
            _userRepo = userRepo;
            _productRepo = productRepo;
        }

        public bool BuyProduct(int userId, int productId, int quantity)
        {
            var user = _userRepo.GetUserById(userId);
            var product = _productRepo.GetProductById(productId);

            if (user == null || product == null)
            {
                throw new Exception("Невiрний користувач або товар.");
            }

            if (product.Quantity < quantity)
            {
                throw new Exception("Недостатньо товару на складi.");
            }

            decimal totalPrice = product.Price * quantity;
            if (user.Balance < totalPrice)
            {
                throw new Exception("Недостатньо коштiв.");
            }

            user.Balance -= totalPrice;
            product.Quantity -= quantity;

            var purchase = new Purchase
            {
                UserId = userId,
                ProductId = productId,
                Quantity = quantity,
                TotalPrice = totalPrice,
                PurchaseDate = DateTime.Now
            };

            _purchaseRepo.AddPurchase(purchase);

            return true;
        }

        public System.Collections.Generic.IEnumerable<Purchase> GetUserPurchaseHistory(int userId)
        {
            return _purchaseRepo.GetPurchasesByUserId(userId);
        }
    }
}
