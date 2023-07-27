namespace cool_restaurant_management_system.Data;

public class Item
{
    public int Id { get; }
    public string Name { get; }
    public double Price { get; }

    public Item(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}