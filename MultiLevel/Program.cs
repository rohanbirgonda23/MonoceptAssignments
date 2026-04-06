using System;

namespace MultiLevelInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Venue[] venues = new Venue[3];
            Booking[] bookings = new Booking[2];

            venues[0] = new Venue(1, "Mumbai Mahal", 200);
            venues[1] = new Venue(2, "Hyderabad Hall", 150);
            venues[2] = new Venue(3, "Srinagar Space", 100);

            Console.WriteLine("Venues:\n");
            foreach (var v in venues)
            {
                v.ShowDetails();
                Console.WriteLine($"Earnings: {v.GetEarnings()}");
                Console.WriteLine();
            }

            bookings[0] = new Booking(4, "Music Concert", 200, 250);
            bookings[1] = new Expo(5, "Tech Expo", 300, 250, 100, 50);

            Console.WriteLine("Bookings:\n");
            foreach (var b in bookings)
            {
                b.ShowDetails();
                Console.WriteLine($"Earnings: {b.GetEarnings()}");
                Console.WriteLine();
            }
        }
    }
}