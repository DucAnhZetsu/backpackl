using System;

namespace BackpackPrototype
{
    public class SportBackpack : Backpack
    {
        // Additional properties for a sport backpack
        public int Pockets { get; set; }
        public bool Hydration { get; set; }

        // Constructor
        public SportBackpack(string colors, double size, string materials, string brand, double volume, double weight, int pockets, bool hydration)
            : base(colors, size, materials, brand, volume, weight)
        {
            Pockets = pockets;
            Hydration = hydration;
        }

        // Clone method implementation
        public override object Clone()
        {
            // Shallow clone the base class properties
            var cloned = (SportBackpack)MemberwiseClone();

            // No need for deep copying here

            return cloned;
        }

        // Display method to show details of the sport backpack
        public override void Display()
        {
            Console.WriteLine($"--- Sport Backpack ---");
            Console.WriteLine($"Colors: {Colors}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Materials: {Materials}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Volume: {Volume}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Pockets: {Pockets}");
            Console.WriteLine($"Hydration: {(Hydration ? "Yes" : "No")}");
            Console.WriteLine("------------------------");
        }
    }
}
