namespace cool_restaurant_management_system.Data;
using SQLite;

public class Tables
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public int Capacity { get; set; }
    public string Location { get; set; }
    public int CurrentlyAvailable { get; set; }  
}