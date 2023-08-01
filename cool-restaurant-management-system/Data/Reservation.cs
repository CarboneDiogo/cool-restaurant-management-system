namespace cool_restaurant_management_system.Data;
using SQLite;
public class Reservation
{
    [PrimaryKey, AutoIncrement]
    public int Id {get;set;} 
}