using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building One = new Building("1234 1st Avenue");
            One.Width = 10.5;
            One.Depth = 20.5;
            One.Stories = 6;

            Building Two = new Building("1234 2nd Avenue");
            One.Width = 15.5;
            One.Depth = 25.5;
            One.Stories = 8;

            Building Three = new Building("1234 3rd Avenue");
            One.Width = 14.5;
            One.Depth = 29.5;
            One.Stories = 15;

            One.Construct();
            Two.Construct();
            Three.Construct();

            One.Purchase("Lindsey");
            Two.Purchase("Honey-Rae");
            Three.Purchase("Tad");

            Console.WriteLine($"{One._address} --------\nDesigned by {One._designer}\nConstructed on {One._dateConstructed}\n" +
                $"Owned by {One._owner}\n{One.Volume} cubic meters of space");
        }
    }
}
