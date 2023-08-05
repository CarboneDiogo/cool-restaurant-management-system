using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cool_restaurant_management_system.Data
{
	public class Reservations
	{
        private int reservation_Id;
        private int table_Id;
        private int guest_Id;
        private int number_of_Guests;
        private string date_Time;

		public int Reservation_Id { get => reservation_Id; set => reservation_Id = value; }
		public int Table_Id { get => table_Id; set => table_Id = value; }
		public int Guest_Id { get => guest_Id; set => guest_Id = value; }
		public int Number_of_Guests { get => number_of_Guests; set => number_of_Guests = value; }
		public string Date_Time { get => date_Time; set => date_Time = value; }

        public Reservations()
        {
            
        }

		public Reservations(int reservation_Id, int table_Id, int guest_Id, int number_of_Guests, string date_Time)
		{
			this.reservation_Id = reservation_Id;
			this.table_Id = table_Id;
			this.guest_Id = guest_Id;
			this.number_of_Guests = number_of_Guests;
			this.date_Time = date_Time;
		}
        
    }
}

