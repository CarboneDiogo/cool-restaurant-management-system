namespace cool_restaurant_management_system.Data;
using SQLite;
public class Customer
{
    [PrimaryKey]
    public string Phone { get; set; }
    public string Name { get; set; }

    public Customer(string name, string phone)
    {
        Name = name;
        Phone = phone;
    }
}