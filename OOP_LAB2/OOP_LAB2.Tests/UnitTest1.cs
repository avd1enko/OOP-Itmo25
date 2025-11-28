namespace OOP_LAB2.Tests;
using OOP_LAB2;
using OOP_LAB2.Entities;
using OOP_LAB2.Factory;
using OOP_LAB2.Upgrades;
using Xunit;

// test for all logic in the project

public class InventoryTests
{
    [Fact]
    public void Add_Item_When_Fits()
    {
        // arrange
        
        var inventory = new Inventory();
        var sword = new Weapon("Sword", "A sharp blade", 10, 25, 100.0);
        
        // act
        inventory.AddItem(sword);
        
        //assert
        Assert.Equal(1, inventory.ItemsAmount());
    }
    
    
    [Fact]
    public void Add_Item_When_Not_Fits()
    {
        // arrange
        
        var inventory = new Inventory();
        var sword = new Weapon("Sword", "A sharp blade", 101, 25, 100.0);
        
        // act
        inventory.AddItem(sword);
        
        //assert
        Assert.Equal(0, inventory.ItemsAmount());
    }
    
}

public class UpgradeTests
{
    [Fact]
    public void Damage_Upgrade_Increase()
    {
        // arrange
        
       var stick = new Weapon("stick", "wooden stick", 5, 5, 100.0);
       var upgrade = new DamageUpgrade(995);
        
        // act
        upgrade.Upgrade(stick);
        
        //assert
        Assert.Equal(1000, stick.Damage);
    }
    
    [Fact]
    public void Defense_Upgrade_Increase()
    {
        // arrange
        
        var helmet = new Armor("Helmet", "Iron helmet", 5, 10, 100.0);
        var upgrade = new DefenseUpgrade(990);
        
        // act
        upgrade.Upgrade(helmet);
        
        //assert
        Assert.Equal(1000, helmet.Defense);
    }
}

public class BuilderTests
{
    [Fact]
    public void Weapon_Builder_Creates_Weapon()
    {
        // arrange
        var builder = new OOP_LAB2.Builders.WeaponBuilder();
        
        // act
        builder.SetName("Axe");
        builder.SetDescription("Stone axe");
        builder.SetWeight(15);
        builder.SetDamage(30);
        builder.SetDurability(85.0);
        var axe = builder.GetWeapon();
        
        // assert
        Assert.Equal("Axe", axe.Name);
        Assert.Equal("Stone axe", axe.Description);
        Assert.Equal(15, axe.Weight);
        Assert.Equal(30, axe.Damage);
        Assert.Equal(85.0, axe.Durability);
    }
}

public class FactoryTests
{
    [Fact]
    public void Item_Factory_Creates_Weapon()
    {
        // arrange
        IItemFactory factory = new ItemFactory();
        
        // act
        var bow = factory.CreateWeapon("Bow", "Long range weapon", 8, 20, 90.0);
        
        // assert
        Assert.Equal("Bow", bow.Name);
        Assert.Equal("Long range weapon", bow.Description);
        Assert.Equal(8, bow.Weight);
        Assert.Equal(20, bow.Damage);
        Assert.Equal(90.0, bow.Durability);
    }
}