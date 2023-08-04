using SQLite;

namespace cool_restaurant_management_system.Data;

public class Orders
{
    public int OrderId { get; set; }
    // Table foreign key
    public int TableId { get; set; }


}