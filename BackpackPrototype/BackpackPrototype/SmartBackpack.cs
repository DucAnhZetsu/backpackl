using System;

namespace BackpackPrototype
{
    public class SmartBackpack : Backpack
    {
        // Additional properties for a smart backpack
        public int LaptopSize { get; set; }
        public bool Battery { get; set; }

        // Constructor
        public SmartBackpack(string colors, double size, string materials, string brand, double volume, double weight, int laptopSize, bool battery)
            : base(colors, size, materials, brand, volume, weight)
        {
            LaptopSize = laptopSize;
            Battery = battery;
        }

        // Clone method implementation
        public override object Clone()
        {
            // Shallow clone the base class properties
            var cloned = (SmartBackpack)MemberwiseClone();

            // No need for deep copying here unless 'Battery' is a reference type

            return cloned;
        }

        // Display method to show details of the smart backpack
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
