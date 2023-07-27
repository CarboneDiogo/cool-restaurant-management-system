namespace cool_restaurant_management_system.Data;

public class Customer
{
    public string Name { get; set; }
    public string Phone { get; set; }

    public Customer(string name, string phone)
    {
        Name = name;
        Phone = phone;
    }
}