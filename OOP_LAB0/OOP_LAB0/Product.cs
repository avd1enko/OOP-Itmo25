using System;
using System.Collections.Generic;

namespace Lab0;

public class Product 
{
    // свойства, к которым можно прикрутить логику обращения
    // сет нужен, чтобы не менять значение напрямую через обращение к полю экземпляра, а чтобы передать это значение внутрь и провести через обработчик (сет)
    public string Name { get;}
    public decimal Price { get; set; }
    public int Quantity { get; private set; }

    public Product(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
    // проверяем наличие
    public bool IsAvailable()
    {
        return Quantity > 0;
    }
    // уменьшаем количество на 1 при покупке
    public void Sold()
    {
        if (Quantity > 0)
        {
            Quantity--;
        }
    }
    public void AddQuantity(int amount)
    {
        if (amount > 0)
        {
            Quantity += amount;
        }
    }
    // переопределяем вывод для удобного отображения
    public override string ToString()
    {
        return $"Название: {Name}, Цена: {Price}, В наличии шт: {Quantity}";
    }
}