using System;
using kursova.Services.Interfaces;
using kursova.Models;

namespace kursova.UI
{
    public partial class StoreUI
    {
        private readonly IUserService _userService;
        private readonly IProductService _productService;
        private readonly IPurchaseService _purchaseService;

        private User _currentUser;

        public StoreUI(IUserService userService, IProductService productService, IPurchaseService purchaseService)
        {
            _userService = userService;
            _productService = productService;
            _purchaseService = purchaseService;
        }

        public void Start()
        {
            while (true)
            {
                if (_currentUser == null)
                {
                    Console.WriteLine("1. Реєстрацiя");
                    Console.WriteLine("2. Вхiд");
                    Console.WriteLine("3. Вихiд з програми");

                    var input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            RegisterUI();
                            break;
                        case "2":
                            LoginUI();
                            break;
                        case "3":
                            return;
                        default:
                            Console.WriteLine("Невiдома команда.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"Вiтаємо, {_currentUser.Username}!");
                    Console.WriteLine("1. Поповнити баланс");
                    Console.WriteLine("2. Переглянути товари");
                    Console.WriteLine("3. Купити товар");
                    Console.WriteLine("4. Переглянути iсторiю покупок");
                    Console.WriteLine("5. Вийти з акаунту");

                    var input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            AddBalanceUI();
                            break;
                        case "2":
                            DisplayProductsUI();
                            break;
                        case "3":
                            BuyProductUI();
                            break;
                        case "4":
                            ShowPurchaseHistoryUI();
                            break;
                        case "5":
                            _currentUser = null;
                            break;
                        default:
                            Console.WriteLine("Невiдома команда.");
                            break;
                    }
                }
            }
        }
    }
}
