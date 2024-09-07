using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_net_hotelaria.models
{
    public class Reservation(int days)
    {
        public List<Guest> Guests { get; set; }
        public Suite Suite { get; set; }
        public int Days { get; set; } = days;

        public void RegisterGuests(List<Guest> guests)
        {
            Guests = guests;
        }

        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetNumberOfGuests()
        {
            return Guests.Count;
        }

        public static decimal CalculateTotalPrice()
        {
            decimal charge = 0;

            return charge;
        }
    }
}