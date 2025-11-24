using System;
using System.Collections.Generic;

namespace Lab0;

public class Vending
{
    // поля и свойства
    private List<Product> _products;
    public decimal CurrentBalance { get; private set; }
    public decimal TotalEarnings { get ; private set; }

    //конструттор
    public Vending(List<Product> products)
    {
        _products = products;
        CurrentBalance = 0;
        TotalEarnings = 0;
    }
    
    // отображаем список продуктов
    public void ShowProducts()
    {
        Console.WriteLine("Товары в автомате:");
        for (int i = 0; i < _products.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_products[i]}");
        }
    }
    
    // добавляем деньги
    public void InsertMoney(decimal amount)
    {
        if (amount > 0)
        {
            CurrentBalance += amount;
        }
    }

    // возвращаем при отмене опперации или при выводе сдачи
    public decimal Refund()
    {
        decimal refund = CurrentBalance;
        CurrentBalance = 0;
        return refund;
    }

    // покупка продукта с проверками на соответствие индекса, баланса и наличия товара
    public bool BuyProduct(int productNumber)
    {
        int index = productNumber - 1;
        if (index < 0 || index >= _products.Count)
        {
            Console.WriteLine("Некорректный номер товара");
            return false;
        }
        Product product = _products[index];
        if (!product.IsAvailable())
        {
            Console.WriteLine("Товар отсутствует");
            return false;
        }
        if (CurrentBalance< product.Price)
        {
            Console.WriteLine("Недостаточно средств");
            return false;
        }
        // логика продажи
        product.Sold();
        CurrentBalance -= product.Price;
        TotalEarnings += product.Price;
        Console.WriteLine("Покупка успешна, Спасибо!");
        Console.WriteLine($"Ваш остаток стредств: {CurrentBalance}");
        return true;
    }
    // АДМИН-ПАНЕЛЬ
    
    // метод для пополнения количества товара
    public void AddProductQuantity(int productNumber, int amount)
    {
        int index = productNumber - 1;
        if (index < 0 || index >= _products.Count)
        {
            Console.WriteLine("Некорректный номер товара");
            return;
        }

        if (amount <= 0)
        {
            Console.WriteLine("Количество должно быть положительным числом");
            return;
        }
        _products[index].AddQuantity(amount);
        Console.WriteLine("Количество товара пополнено");
    }
    
    // метод для извлечения выручки
    public decimal CollectEarnings()
    {
        decimal money = TotalEarnings;
        Console.WriteLine($"Выводимая сумма: {TotalEarnings}");
        TotalEarnings = 0;
        return money;
    }
}