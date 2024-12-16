using kursova.Data;
using kursova.Models;
using kursova.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace kursova.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreDbContext _context;

        public ProductRepository(StoreDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int productId)
        {
            return _context.Products.FirstOrDefault(p => p.Id == productId);
        }
    }
}
