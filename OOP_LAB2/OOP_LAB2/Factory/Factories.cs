namespace OOP_LAB2.Factory;
using OOP_LAB2.Entities;


// Abstract factory pattern

public interface IItemFactory
{
    Weapon CreateWeapon(string name, string description, int weight, int damage, double durability);
    Armor CreateArmor(string name, string description, int weight, int defense, double durability);
    Potion CreatePotion(string name, string description, int weight, int duration, string effect);
    QuestItem CreateQuest(string name, string description, int weight, string questName, int rarityRank, string effect);
}

public class ItemFactory : IItemFactory
{
    public Weapon CreateWeapon(string name, string description, int weight, int damage, double durability)
    {
        return new Weapon(name, description, weight, damage, durability);
    }

    public Armor CreateArmor(string name, string description, int weight, int defense, double durability)
    {
        return new Armor(name, description, weight, defense, durability);
    }

    public Potion CreatePotion(string name, string description, int weight, int duration, string effect)
    {
        return new Potion(name, description, weight, duration, effect);
    }

    public QuestItem CreateQuest(string name, string description, int weight, string questName, int rarityRank, string effect)
    {
        return new QuestItem(name, description, weight, rarityRank, effect, questName);
    }
}