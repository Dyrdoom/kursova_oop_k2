using System;

namespace kursova.UI
{
    public partial class StoreUI
    {
        private void RegisterUI()
        {
            Console.Write("Введiть iм'я користувача: ");
            var username = Console.ReadLine();
            Console.Write("Введiть пароль: ");
            var password = Console.ReadLine();

            try
            {
                var user = _userService.RegisterUser(username, password);
                if (user != null)
                {
                    _currentUser = user;
                    Console.WriteLine("Реєстрацiя пройшла успiшно!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        private void LoginUI()
        {
            Console.Write("iм'я користувача: ");
            var username = Console.ReadLine();
            Console.Write("Пароль: ");
            var password = Console.ReadLine();

            try
            {
                var user = _userService.LoginUser(username, password);
                _currentUser = user;
                Console.WriteLine("Вхiд успiшний!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}
