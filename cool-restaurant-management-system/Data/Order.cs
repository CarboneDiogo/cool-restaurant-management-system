using SQLite;

namespace cool_restaurant_management_system.Data;

public class Order
{
    [PrimaryKey, AutoIncrement]
    public int OrderId { get; set; }
    // Table foreign key
    public int TableId { get; set; }

    public Order(int orderId, int tableId)
    {
        OrderId = orderId;
        TableId = tableId;
    }
}