using System;

namespace BackpackPrototype
{
    public class FirefighterBackpack : Backpack
    {
        // Additional properties for a firefighter's backpack
        public string Tools { get; set; }
        public bool FireResistance { get; set; }

        // Constructor
        public FirefighterBackpack(string colors, double size, string materials, string brand, double volume, double weight, string tools, bool fireResistance)
            : base(colors, size, materials, brand, volume, weight)
        {
            Tools = tools;
            FireResistance = fireResistance;
        }

        // Clone method implementation
        public override object Clone()
        {
            // Shallow clone the base class properties
            var cloned = (FirefighterBackpack)MemberwiseClone();

            // No need for deep copying here unless 'Tools' or 'FireResistance' are reference types

            return cloned;
        }

        // Display method to show details of the firefighter's backpack
        public override void Display()
        {
            Console.WriteLine($"--- Firefighter Backpack ---");
            Console.WriteLine($"Colors: {Colors}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Materials: {Materials}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Volume: {Volume}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Tools: {Tools}");
            Console.WriteLine($"Fire Resistance: {(FireResistance ? "Yes" : "No")}");
            Console.WriteLine("---------------------------");
        }
    }
}
