using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cool_restaurant_management_system.Data
{
    internal class ExceptionManager
    {
        public static void ReservationCreationExceptions(string phone, string guestName, int tableId)
        {
            bool isNumeric = int.TryParse(phone, out _);

            if (string.IsNullOrEmpty(guestName))
            {
                App.Current.MainPage.DisplayAlert("Client Information Incomplete",
                    "Please provide the customer's name before making a reservation.", "OK");
                return;
            }
            if (string.IsNullOrEmpty(phone))
            {
                App.Current.MainPage.DisplayAlert("Phone number is missing", "Please provide contact information", "OK");
                return;
            }
            if (!isNumeric || phone.Length != 10)
            {
                App.Current.MainPage.DisplayAlert("Incorrect phone number format", "Please provide contact information", "OK");
                return;
            }
            if (tableId == 0)
            {
                App.Current.MainPage.DisplayAlert("No Table Was Selected", "Please pick an available table", "OK");
                return;
            }
        }
    }
}
