namespace cool_restaurant_management_system.Data;

public class Table
{
    public int TableId { get; }
    private int AvailableSits { get; }
    public bool IsAvailable;

    public Table(int tableId, int availableSits, bool isAvailable)
    {
        TableId = tableId;
        AvailableSits = availableSits;
        IsAvailable = isAvailable;
    }
}