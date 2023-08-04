namespace cool_restaurant_management_system.Data;
using SQLite;
public class Reservations
{
    public int Id {get;set;}
    public DateTime DateAndTime { get; set; }

    public int CustomerPhone { get; set; }
    public int TableId { get; set; }

}