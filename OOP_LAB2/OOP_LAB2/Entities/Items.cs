namespace OOP_LAB2.Entities;

// base class for all items

public abstract class Item
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Weight { get; set; }

    protected Item (string name, string description, int weight)
    {
        Name = name;
        Description = description;
        Weight = weight;
    }

    public override string ToString()
    {
        return $"Name: {Name},\nDescription: {Description},\nWeight: {Weight}";
    }
}

// classes for weapon, armor, potion, questItem

public class Weapon : Item, IEquippable
{
    public int Damage {get; set;}
    public double Durability {get; set;}
    public bool IsEquipped {get; private set; }

    public Weapon(string name, string description, int weight, int damage, double durability) : base(name, description, weight)
    {
        Damage = damage;
        Durability = durability;
        IsEquipped = false;
    }

    public void Equip()
    {
        IsEquipped = true;
    }

    public void Unequip()
    {
        IsEquipped = false;
    }
}

public class Armor : Item, IEquippable
{
    public int Defense {get; set;}
    public double Durability {get; set;}
    
    public bool IsEquipped {get; private set; }

    public Armor(string name, string description, int weight, int defense, double durability) : base(name, description, weight)
    {
        Defense = defense;
        Durability = durability;
        IsEquipped = false;
    }
    public void Equip()
    {
        IsEquipped = true;
    }

    public void Unequip()
    {
        IsEquipped = false;
    }
}

public class Potion : Item, IUsable
{
    public int Duration {get; set;}
    public string Effect {get; set;}
    public bool IsUsed {get; private set; }
    
    public Potion(string name, string description, int weight, int duration, string effect) : base(name, description, weight)
    {
        Duration = duration;
        Effect = effect;
        IsUsed = false;
    }
    public void Use()
    {
        IsUsed = true;
    }
}

public class QuestItem : Item, IUsable
{
    public string QuestName {get; set;}
    public int RarityRank {get; set;}
    public string Effect { get; set; }
    public bool IsUsed {get; private set;}

    public QuestItem(string name, string description, int weight, int rank, string questName, string effect) : base(name, description,
        weight)
    { 
        QuestName = questName;
        RarityRank = rank;
        Effect = effect;
        IsUsed = false;
    }

    public void Use()
    {
        IsUsed = true;
    }
}