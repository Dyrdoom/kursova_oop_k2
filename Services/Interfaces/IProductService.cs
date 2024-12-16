using kursova.Models;
using System.Collections.Generic;

namespace kursova.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
    }
}
