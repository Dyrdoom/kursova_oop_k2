using System;

namespace kursova.UI
{
    public partial class StoreUI
    {
        private void AddBalanceUI()
        {
            Console.Write("Введiть суму для поповнення: ");
            var input = Console.ReadLine();
            if (decimal.TryParse(input, out decimal amount))
            {
                try
                {
                    _userService.AddBalance(_currentUser.Id, amount);
                    Console.WriteLine($"Баланс успiшно поповнено! Новий баланс: {_currentUser.Balance}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Невiрний формат суми.");
            }
        }
    }
}
