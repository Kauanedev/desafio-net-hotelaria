
using desafio_net_hotelaria.models;

List<Guest> guests = [];

Guest g1 = new(name: "Jhon", lastName: "Smith");
Guest g2 = new(name: "Maria", lastName: "Garcia");

guests.Add(g1);
guests.Add(g2);

Suite suite = new(suiteType: "Premium", capacity: 2, dailyCharges: 100);

Reservation reservation = new(days: 10);
reservation.RegisterSuite(suite);
reservation.RegisterGuests(guests);

Console.WriteLine($"Guests: {reservation.GetNumberOfGuests()}");
Console.WriteLine($"Daily Charges: {reservation.CalculateTotalPrice()}");