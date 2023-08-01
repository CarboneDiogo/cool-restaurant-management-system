namespace cool_restaurant_management_system.Data;
using SQLite;
public class Table
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public int Capacity { get; set; }
    public string Location { get; set; }

    public Table(int id, int capacity, string location)
    {
        Id = id;
        Capacity = capacity;
        Location = location;
    }
    
}