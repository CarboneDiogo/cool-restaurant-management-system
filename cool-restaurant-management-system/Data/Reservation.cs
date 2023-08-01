namespace cool_restaurant_management_system.Data;
using SQLite;
public class Reservation
{
    [PrimaryKey, AutoIncrement]
    public int Id {get;set;}
    public DateTime DateAndTime { get; set; }

    // Customer dbTable Foreign Key
    public int CustomerId { get; set; }
    // Table dbTable Foreign Key
    public int TableId { get; set; }

    public Reservation(int id, DateTime date, int customerId, int tableId)
    {
        Id = id;
        DateAndTime = date;
        CustomerId = customerId;
        TableId = tableId;
    }
}