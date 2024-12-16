using kursova.Models;
using kursova.Repositories.Interfaces;
using kursova.Services.Interfaces;
using System.Collections.Generic;

namespace kursova.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepo;

        public ProductService(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepo.GetAllProducts();
        }
    }
}
