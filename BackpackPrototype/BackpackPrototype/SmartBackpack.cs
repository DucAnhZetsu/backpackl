using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace BackpackPrototype
{
    // The 'ConcretePrototype' class
    public class SmartBackpack : Backpack
    {
        public int LaptopSize { get; set; }
        public bool Battery { get; set; }

        public SmartBackpack(string colors, double size, string materials, string brand, double volume, double weight, int laptopSize, bool battery)
            : base(colors, size, materials, brand, volume, weight)
        {
            this.LaptopSize = laptopSize;
            this.Battery = battery;
            // Set specific values for MaxCapacity, MaxVolume, MaxWeight if required
        }

        // Implementing Clone method to handle cloning specific properties
        public override object Clone()
        {
            // Shallow clone the base class properties
            var cloned = (SmartBackpack)this.MemberwiseClone();

            // Perform deep copy for reference types (if any)
            // If Battery was a reference type, clone it here

            return cloned;
        }

        // Implementing Display method to show SmartBackpack specific properties
        public override void Display()
        {
            Console.WriteLine($"--- Smart Backpack ---");
            Console.WriteLine($"Colors: {Colors}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Materials: {Materials}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Volume: {Volume}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Laptop Size: {LaptopSize} inch");
            Console.WriteLine($"Battery: {Battery}");
            
            Console.WriteLine("-----------------------");
        }
    }
}
