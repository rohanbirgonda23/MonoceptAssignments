using System;

namespace MultiLevelInheritance
{
    class Venue
    {
        public int Id;
        public string Name;
        public int MaxCapacity;

        public Venue(int id, string name, int capacity)
        {
            Id = id;
            Name = name;
            MaxCapacity = capacity;
        }

        public virtual int GetEarnings()
        {
            return MaxCapacity * 100;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Capacity: {MaxCapacity}");
        }
    }

    class Booking : Venue
    {
        int GuestCount;

        public Booking(int id, string name, int capacity, int guests)
            : base(id, name, capacity)
        {
            if (guests > capacity)
            {
                Console.WriteLine("Guests cannot exceed capacity");
                guests = capacity;
            }

            GuestCount = guests;
        }

        public override int GetEarnings()
        {
            int baseAmount = base.GetEarnings();
            return GuestCount * baseAmount;
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Guests: {GuestCount}");
            Console.WriteLine($"Earnings: {GetEarnings()}");
        }
    }

    class Expo : Booking
    {
        int StallCount;
        int RentPerStall;

        public Expo(int id, string name, int capacity, int guests, int stalls, int rent)
            : base(id, name, capacity, guests)
        {
            if (stalls > capacity / 2)
            {
                Console.WriteLine("Stalls exceed limit");
                stalls = capacity / 2;
            }

            StallCount = stalls;
            RentPerStall = rent;
        }

        public override int GetEarnings()
        {
            return StallCount * RentPerStall;
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Stalls: {StallCount}");
            Console.WriteLine($"Rent per Stall: {RentPerStall}");
            Console.WriteLine($"Earnings: {GetEarnings()}");
        }
    }

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