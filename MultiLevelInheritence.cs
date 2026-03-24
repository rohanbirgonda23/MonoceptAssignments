    using System;
    class Banquet
    {
        public int BanquetId;
        public string BanquetName;
        public int Capacity;

        public Banquet(int id, string name, int capacity)
        {
            BanquetId = id;
            BanquetName = name;
            Capacity = capacity;
        }

        public virtual int CalculateEarning()
        {
            return Capacity * 100;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Banquet Id: {BanquetId}");
            Console.WriteLine($"Banquet Name: {BanquetName}");
            Console.WriteLine($"Capacity: {Capacity}");
        }
    }

    
    class Event : Banquet
    {
        int TotalPax;

        public Event(int id, string name, int capacity, int pax)
            : base(id, name, capacity)
        {
            if (pax > capacity)
            {
                Console.WriteLine("Total Pax cannot exceed Capacity");
                pax = capacity;
            }

            TotalPax = pax;
        }

        public override int CalculateEarning()
        {
            int basicEarning = base.CalculateEarning();
            return TotalPax * basicEarning;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Total Pax: {TotalPax}");
            Console.WriteLine($"Total Earnings: {CalculateEarning()}");
        }
    }

    class Exhibition : Event
    {
        int TotalStalls;
        int StallRent;

        public Exhibition(int id, string name, int capacity, int pax, int stalls, int rent)
            : base(id, name, capacity, pax)
        {
            if (stalls > capacity / 2)
            {
                Console.WriteLine("Stalls cannot exceed half of capacity");
                stalls = capacity / 2;
            }

            TotalStalls = stalls;
            StallRent = rent;
        }

        public override int CalculateEarning()
        {
            return TotalStalls * StallRent;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Total Stalls: {TotalStalls}");
            Console.WriteLine($"Stall Rent: {StallRent}");
            Console.WriteLine($"Total Earnings: {CalculateEarning()}");
        }
    }

 
    class Program
    {
        static void Main(string[] args)
        {
            Banquet[] banquets = new Banquet[3];
            Event[] eventExhibition = new Event[2];

            banquets[0] = new Banquet(1, "Mumbai Mahal", 200);
            banquets[1] = new Banquet(2, "Hyderabad Hall", 150);
            banquets[2] = new Banquet(3, "Srinagar Space", 100);

            Console.WriteLine("---- Banquets ----\n");
            foreach (var b in banquets)
            {
                b.Display();
                Console.WriteLine($"Total Earnings: {b.CalculateEarning()}");
                Console.WriteLine();
            }

            eventExhibition[0] = new Event(4, "Music Concert", 200, 250);
            eventExhibition[1] = new Exhibition(5, "Tech Expo", 300, 250, 100, 50);

            Console.WriteLine("--- Events & Exhibitions ---\n");
            foreach (var e in eventExhibition)
            {
                e.Display();
                Console.WriteLine($"Total Earnings: {e.CalculateEarning()}");
                Console.WriteLine();
            }
        }
}