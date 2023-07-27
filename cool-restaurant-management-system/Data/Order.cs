namespace cool_restaurant_management_system.Data;

public class Order
{
    public int TableId { get; }
    public List<Item> OrderItems { get; set; }

    public Order(int tableId)
    {
        TableId = tableId;
        OrderItems = new List<Item>();
    }
}