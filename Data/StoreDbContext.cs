using kursova.Models;

namespace kursova.Data
{
    public class StoreDbContext
    {
        public DbSet<User> Users { get; set; } = new DbSet<User>();
        public DbSet<Product> Products { get; set; } = new DbSet<Product>();
        public DbSet<Purchase> Purchases { get; set; } = new DbSet<Purchase>();

        public StoreDbContext()
        {
            Products.Add(new Product { Id = 1, Name = "Смартфон", Price = 6000m, Quantity = 10 });
            Products.Add(new Product { Id = 2, Name = "Ноутбук", Price = 20000m, Quantity = 5 });
            Products.Add(new Product { Id = 3, Name = "Навушники", Price = 500m, Quantity = 20 });
        }
    }
}
