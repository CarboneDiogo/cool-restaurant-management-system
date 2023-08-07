using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cool_restaurant_management_system.Data
{
	public class Reservations
	{

        public int Reservation_Id { get; set; }
		public int Table_Id { get; set; }
		public int Guest_Id { get; set; }
		public int Number_of_Guests { get; set; }
		public DateTime Reserved_From { get; set; }
		public DateTime Reserved_To { get; set; }

        public Reservations()
        {
            
        }

        public Reservations(int reservation_Id, int table_Id, int guest_Id, int number_of_Guests, DateTime reserved_From, DateTime reserved_To)
        {
            Reservation_Id = reservation_Id;
            Table_Id = table_Id;
            Guest_Id = guest_Id;
            Number_of_Guests = number_of_Guests;
            Reserved_From = reserved_From;
            Reserved_To = reserved_To;
        }
    }
}

