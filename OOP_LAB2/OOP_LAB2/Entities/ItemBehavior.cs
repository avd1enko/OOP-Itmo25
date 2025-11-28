namespace OOP_LAB2.Entities;

// for any item
public interface IEquippable
{
    bool IsEquipped { get; }
    void Equip();
    void Unequip();
}

// for potions and questItems
public interface IUsable
{
    bool IsUsed { get; }
    void Use();
}