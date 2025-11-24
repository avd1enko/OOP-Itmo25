using System;
using System.Collections.Generic;

namespace Lab0;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product("Печенье", 1.50m, 10),
            new Product("Вода", 1.00m, 5),
            new Product("Орехи", 2.75m, 15),
            new Product("Сухофрукты", 1.75m, 6)
        };
        var vending = new Vending(products);
        while (true)
        {
            Console.WriteLine("\n=== Вендинговый автомат ===");
            Console.WriteLine("1. Показать товары");
            Console.WriteLine("2. Внести деньги");
            Console.WriteLine("3. Купить товар");
            Console.WriteLine("4. Вернуть деньги");
            Console.WriteLine("5. Админ-панель");
            Console.WriteLine("0. Выход");
            Console.WriteLine($"Текущий баланс: {vending.CurrentBalance}");
            Console.Write("Выберите действие: ");


            string input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    Console.WriteLine("До свидания!");
                    break;
                case "1":
                    vending.ShowProducts();
                    break;
                case "2":
                    Console.WriteLine("Введите сумму для внесения:");
                    string amountInput = Console.ReadLine();
                    decimal amount = decimal.Parse(amountInput);
                    vending.InsertMoney(amount);
                    Console.WriteLine($"Внесена сумма: {amount}, текущий баланс: {vending.CurrentBalance}");
                    break;
                case "3":
                    vending.ShowProducts();
                    Console.WriteLine("Введите номер товара для покупки:");
                    string inputNumber = Console.ReadLine();
                    int productIndex = int.Parse(inputNumber);
                    vending.BuyProduct(productIndex);
                    break;
                case "4":
                    decimal refund = vending.Refund();
                    Console.WriteLine($"Возвращена сумма: {refund}");
                    break;
                case "5":
                    Console.WriteLine("Введите пароль (123)");
                    string pin = Console.ReadLine();
                    if (pin != "123")
                    {
                        Console.WriteLine("Неверный пароль");
                        break;
                    }
                    Console.WriteLine("\n=== Админ-панель ===");
                    Console.WriteLine("1. Показать товары");
                    Console.WriteLine("2. Пополнить товар");
                    Console.WriteLine("3. Показать выручку");
                    Console.WriteLine("4. Забрать выручку");
                    Console.Write("Выберите действие: ");

                    string adminInput = Console.ReadLine();
                    
                    switch (adminInput)
                    {
                        case "1":
                            vending.ShowProducts();
                            break;
                        case "2":
                            vending.ShowProducts();
                            Console.Write("Введите номер товара: ");
                            int adminProductNumber = int.Parse(Console.ReadLine());
                            Console.Write("Введите количество для добавления: ");
                            int addAmount = int.Parse(Console.ReadLine());
                            vending.AddProductQuantity(adminProductNumber, addAmount);
                            break;
                        case "3":
                            decimal collected = vending.CollectEarnings();
                            Console.WriteLine($"Администратор забрал: {collected}");
                            break;

                        default:
                            Console.WriteLine("Нет такого пункта в админ-панели");
                            break;
                    }

                    break;
                
                default:
                    Console.WriteLine("Нет такого пункта меню.");
                    break;
            }
        }
    }
}