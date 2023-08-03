namespace cool_restaurant_management_system.Data;
using SQLite;
public class Customers
{
    [PrimaryKey]
    public string Phone { get; set; }
    public string Name { get; set; }
}