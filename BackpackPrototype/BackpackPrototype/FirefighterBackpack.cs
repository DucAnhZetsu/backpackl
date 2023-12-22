using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace BackpackPrototype
{
    public class FirefighterBackpack : Backpack
    {
        public string Tools { get; set; }
        public bool FireResistance { get; set; }

        public FirefighterBackpack(string colors, double size, string materials, string brand, double volume, double weight, string tools, bool fireResistance)
            : base(colors, size, materials, brand, volume, weight)
        {
            this.Tools = tools;
            this.FireResistance = fireResistance;
            // You can set specific values for MaxCapacity, MaxVolume, MaxWeight here if needed
        }

        // Implementing Clone method to handle cloning specific properties
        public override object Clone()
        {
            // Shallow clone the base class properties
            var cloned = (FirefighterBackpack)this.MemberwiseClone();

            // Perform deep copy for reference types (if any)
            // If Tools or FireResistance were reference types, clone them here

            return cloned;
        }

        // Implementing Display method to show FirefighterBackpack specific properties
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

