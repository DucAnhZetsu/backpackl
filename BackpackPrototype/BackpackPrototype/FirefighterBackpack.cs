using System;

namespace BackpackPrototype
{
    public class FirefighterBackpack : Backpack
    {
        // Additional properties for a firefighter's backpack
        public string Tools { get; set; }
        public bool FireResistance { get; set; }

        public int Durability { get; private set; } = 100;
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

        public virtual void ReactToFire()
        {
            if (FireResistance)
            {
                Console.WriteLine("The Firefighter Backpack is fire-resistant. It can withstand fire damage.");
                // You might have additional logic here specific to a fire-resistant backpack
            }
            else
            {
                Console.WriteLine("The Firefighter Backpack is not fire-resistant. Reducing durability...");
                // Logic to decrease durability when exposed to fire
                DecreaseDurability(10); // For example, decrease durability by 10 units
            }
            if (Durability <= 0)
            {
                Console.WriteLine("The backpack is destroyed.");
            }
        }

        public void DecreaseDurability(int amount)
        {
            // Logic to decrease durability when exposed to fire
            Durability -= 20; // For example, reducing durability by 20 points
            Console.WriteLine($"Durability decreased. Current durability: {Durability}");
            // You can add more complex logic based on your requirements
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
