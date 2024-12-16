using kursova.Data;
using kursova.Repositories.Implementations;
using kursova.Services.Implementations;
using kursova.UI;

namespace kursova
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new StoreDbContext();
            
            var userRepo = new UserRepository(context);
            var productRepo = new ProductRepository(context);
            var purchaseRepo = new PurchaseRepository(context);

            var userService = new UserService(userRepo);
            var productService = new ProductService(productRepo);
            var purchaseService = new PurchaseService(purchaseRepo, userRepo, productRepo);

            var ui = new StoreUI(userService, productService, purchaseService);
            ui.Start();
        }
    }
}
