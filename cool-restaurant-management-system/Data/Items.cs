using SQLite;

namespace cool_restaurant_management_system.Data;

public class Items
{
    public int Id { get; }
    public string Name { get; }
    public double Price { get; }
    public string Category { get; set; }

}