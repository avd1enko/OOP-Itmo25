namespace OOP_LAB3.Entities;

public class OrderItem
{
    public Dish Dish { get; set; }
    public int Quantity { get; private set; }
    
    public OrderItem(Dish dish, int quantity)
    {
        Dish = dish;
        Quantity = quantity;
    }
    public decimal GetTotalPrice()
    {
        return Dish.Price * Quantity;
    }
    
    public void ChangeQuantity(int newQuantity)
    {
        Quantity = newQuantity;
    }
}