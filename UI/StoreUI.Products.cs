using System;

namespace kursova.UI
{
    public partial class StoreUI
    {
        private void DisplayProductsUI()
        {
            var products = _productService.GetAllProducts();
            Console.WriteLine("Список товарiв:");
            foreach(var p in products)
            {
                Console.WriteLine($"ID: {p.Id}, Назва: {p.Name}, Цiна: {p.Price}, Кiлькiсть: {p.Quantity}");
            }
        }

        private void BuyProductUI()
        {
            Console.Write("Введiть ID товару: ");
            var productIdInput = Console.ReadLine();
            Console.Write("Введiть кiлькiсть: ");
            var quantityInput = Console.ReadLine();

            if (int.TryParse(productIdInput, out int productId) && int.TryParse(quantityInput, out int quantity))
            {
                try
                {
                    _purchaseService.BuyProduct(_currentUser.Id, productId, quantity);
                    Console.WriteLine("Покупка успiшна!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Невiрнi данi.");
            }
        }
    }
}
