﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cool_restaurant_management_system.Data
{
	public class Guests
	{
		private int guest_Id;
		private string name;
		private string phone;

		public int Guest_Id { get => guest_Id; set => guest_Id = value; }
		public string Name { get => name; set => name = value; }
		public string Phone { get => phone; set => phone = value; }

        public Guests()
        {
            
        }

        public Guests(int guest_Id, string name, string phone)
		{
			this.guest_Id = guest_Id;
			this.name = name;
			this.phone = phone;
		}
	}
}
