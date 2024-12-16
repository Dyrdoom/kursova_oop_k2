using kursova.Models;
using System.Collections.Generic;

namespace kursova.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int productId);
    }
}
