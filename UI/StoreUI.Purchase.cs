using System;

namespace kursova.UI
{
    public partial class StoreUI
    {
        private void ShowPurchaseHistoryUI()
        {
            var purchases = _purchaseService.GetUserPurchaseHistory(_currentUser.Id);
            Console.WriteLine("iсторiя покупок:");
            foreach(var purchase in purchases)
            {
                Console.WriteLine($"ID покупки: {purchase.Id}, ТоварID: {purchase.ProductId}, Кiлькiсть: {purchase.Quantity}, Сума: {purchase.TotalPrice}, Дата: {purchase.PurchaseDate}");
            }
        }
    }
}
