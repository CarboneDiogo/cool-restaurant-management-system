namespace cool_restaurant_management_system.Data
{
    public class Reservations
    {
        public string Phone_Number { get; set; }
        public string Guest_Name { get; set; }
        public int Table_Id { get; set; }
        public int Number_of_Guests { get; set; }
        public DateTime Reservation_Date { get; set; }

        public Reservations() { }
    }
}

