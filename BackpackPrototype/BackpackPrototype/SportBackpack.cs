using System;

namespace BackpackPrototype
{
    public class SportBackpack : Backpack
    {
        // Additional properties for a sport backpack
        public int Pockets { get; set; }
        public bool Hydration { get; set; }

        public int Durability { get; private set; } = 100;
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


        public virtual void ReactToWater(int waterDepth)
        {
            if (Hydration)
            {
                Console.WriteLine("The Sport Backpack is waterproof and has hydration features.");
                DamageBackpack(waterDepth); // Check the damage based on the water depth
            }
            else
            {
                Console.WriteLine("The Sport Backpack is not waterproof and will get damaged when exposed to water.");
                DecreaseDurability(waterDepth); // Damage the backpack directly if not waterproof
            }
            if (Durability <= 0)
            {
                Console.WriteLine("The backpack is destroyed.");
            }
        }

        private void DamageBackpack(int waterDepth)
        {
            if (waterDepth <= 10)
            {
                Console.WriteLine("The water is not very deep. The Sport Backpack remains relatively undamaged.");
            }
            else if (waterDepth > 10 && waterDepth <= 20)
            {
                Console.WriteLine("The water is moderately deep. The Sport Backpack incurs some damage.");
                DecreaseDurability(20); // For example, reduce durability by 20 units
            }
            else
            {
                Console.WriteLine("The water is very deep. The Sport Backpack suffers significant damage.");
                DecreaseDurability(40); // For example, reduce durability by 40 units
            }
        }

        private void DecreaseDurability(int amount)
        {
            // Logic to decrease durability
            // Update the backpack's durability based on the damage amount
            Durability -= amount;
            Console.WriteLine($"Durability decreased. Current durability: {Durability}");
            // Additional complex logic based on your requirements
        }

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
