namespace cool_restaurant_management_system.Data;

public class Reservation
{
    public Customer ReservationHolder;
    private int tableId;
    
    //There might be a better way of storing the date+time but for now I will structure it this way
    public int Day { get; set; }
    public int Month { get; set; }
    public int Hour { get; set; }
    public int Minute { get; set; }

    public Reservation(Customer reservationHolder, int tableId, int day, int month, int hour, int minute)
    {
        ReservationHolder = reservationHolder;
        this.tableId = tableId;
        Day = day;
        Month = month;
        Hour = hour;
        Minute = minute;
    }
}