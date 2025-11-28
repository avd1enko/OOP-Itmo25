namespace OOP_LAB2.Upgrades;
using OOP_LAB2.Entities;


// I use pattern strategy here

// upgrade interface
public interface IUpgradeInstructions
{
    void Upgrade(Item item);
}

// class for damage upgrade
public class DamageUpgrade : IUpgradeInstructions
{
    private int _damageIncrease;
    
    public DamageUpgrade(int damageIncrease)
    {
        _damageIncrease = damageIncrease;
    }

    public void Upgrade(Item item)
    {
        // check if item is a weapon, then create a new var w of type Weapon
        if (item is Weapon w)
        {
            w.Damage += _damageIncrease;
        }
    }
}

// class for defense upgrade

public class DefenseUpgrade : IUpgradeInstructions
{
    private int _defenseIncrease;
    
    public DefenseUpgrade(int defenseIncrease)
    {
        _defenseIncrease = defenseIncrease;
    }

    public void Upgrade(Item item)
    {
        // check if item is an armor, then create a new var a of type Armor
        if (item is Armor a)
        {
            a.Defense += _defenseIncrease;
        }
    }
}