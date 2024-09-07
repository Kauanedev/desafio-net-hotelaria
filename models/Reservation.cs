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
            if (Suite.Capacity >= guests.Count)
            {
                Guests = guests;
            }
            else
            {
                throw new Exception("Capacity exceeded");
            }
        }

        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetNumberOfGuests()
        {
            return Guests.Count;
        }

        public decimal CalculateTotalPrice()
        {
            decimal charge = Days * Suite.DailyCharges;

            if (Days >= 10)
            {
                charge *= 0.9M;
            }

            return charge;
        }
    }
}