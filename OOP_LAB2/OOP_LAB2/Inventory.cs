namespace OOP_LAB2;
using OOP_LAB2.Entities;

public class Inventory
{
    private List<Item> _items;
    private int _freeCapacity;
    
    public Inventory()
    {
        _items = new List<Item>();
        _freeCapacity = 100;
    }

    public void AddItem(Item item)
    {
        if (item.Weight <= _freeCapacity)
        {
            _freeCapacity -= item.Weight;
            _items.Add(item);
        }
    }

    public void RemoveItem(Item item)
    {
        if (_items.Remove(item))
        {
            _freeCapacity += item.Weight;
        }
    }

    public List<Item> GetItems()
    {
        return _items;
    }

    public int ItemsAmount()
    {
        return _items.Count;
    }

}
