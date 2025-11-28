namespace OOP_LAB2.Builders;
using OOP_LAB2.Entities;

// Builder pattern for creating Weapon objects
public interface IWeaponBuilder
{
    void Reset();
    void SetName(string name);
    void SetDescription(string description);
    void SetWeight(int weight);
    void SetDamage(int damage);
    void SetDurability(double durability);
    Weapon GetWeapon();
}

public class WeaponBuilder : IWeaponBuilder
{
    private Weapon _weapon;

    public WeaponBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        _weapon = new Weapon("", "", 0, 0, 0.0);
    }

    public void SetName(string name)
    {
        _weapon.Name = name;
    }

    public void SetDescription(string description)
    {
        _weapon.Description = description;
    }

    public void SetWeight(int weight)
    {
        _weapon.Weight = weight;
    }

    public void SetDamage(int damage)
    {
        _weapon.Damage = damage;
    }

    public void SetDurability(double durability)
    {
        _weapon.Durability = durability;
    }
    
    public Weapon GetWeapon()
    {
        return _weapon;
    }
}