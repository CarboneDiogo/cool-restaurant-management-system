using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cool_restaurant_management_system.Data
{
	public class RestaurantTable
	{
		private int table_Id;
		private int is_Available;
		private int capacity;

		public int Table_Id { get => table_Id; set => table_Id = value; }
		public int Is_Available { get => is_Available; set => is_Available = value; }
		public int Capacity { get => capacity; set => capacity = value; }

        public RestaurantTable()
        {
            
        }
        public RestaurantTable(int table_Id, int is_Available, int capacity)
		{
			this.Table_Id = table_Id;
			this.Is_Available = is_Available;
			this.Capacity = capacity;
		}
	}
}
