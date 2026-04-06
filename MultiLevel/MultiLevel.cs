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
}