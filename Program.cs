using System;

namespace iron_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet spread = new Buffet();
            SpiceHound michelle = new SpiceHound();
            SweetTooth mark = new SweetTooth();

            while (michelle.IsFull == false)
            {
                Console.WriteLine("Michelle ate/drank the following item: ");
                michelle.Consume(spread.Serve());
            }
            while (mark.IsFull == false)
            {
                Console.WriteLine("Mark ate/drank the following item: ");
                mark.Consume(spread.Serve());
            }
            if (mark.ConsumptionHistory.Count > michelle.ConsumptionHistory.Count )
            {
                Console.WriteLine($"Mark ate the most and he ate/drank {mark.ConsumptionHistory.Count} items.");
            }
            if (michelle.ConsumptionHistory.Count > mark.ConsumptionHistory.Count )
            {
                Console.WriteLine($"Michelle ate the most and she ate/drank {michelle.ConsumptionHistory.Count} items.");
            }
        }
    }
}
