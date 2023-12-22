using System;

namespace BackpackPrototype
{
    public class SmartBackpack : Backpack
    {
        // Additional properties for a smart backpack
        public int LaptopSize { get; set; }
        public bool Battery { get; set; }

        public int BatteryCharge { get; private set; } = 1; // Battery charge level initialized to 1

        // Constructor
        public SmartBackpack(string colors, double size, string materials, string brand, double volume, double weight, int laptopSize, bool battery)
            : base(colors, size, materials, brand, volume, weight)
        {
            LaptopSize = laptopSize;
            Battery = battery;
        }

        // Clone method implementation

        public virtual void ReactToLight()
        {
            Console.WriteLine("The Smart Backpack reacts to light.");
            // Add any specific logic for the backpack's reaction to light
            // For example, adjust visibility, activate certain features, etc.
            ChargeBattery();
        }

        public void ChargeBattery()
        {
            if (BatteryCharge < 100)
            {
                BatteryCharge += 10; // Increment the battery charge level (can be adjusted based on your requirements)
                Console.WriteLine($"Battery charging... Current charge level: {BatteryCharge}");
            }
            else
            {
                Console.WriteLine("Battery is fully charged.");
            }
        }
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
            Console.WriteLine($"Battery: {(Battery ? $"{BatteryCharge}%" : "No Battery")}");
            Console.WriteLine("-----------------------");
        }
    }
}
