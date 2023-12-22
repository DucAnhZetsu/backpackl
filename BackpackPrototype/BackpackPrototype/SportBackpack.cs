using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace BackpackPrototype
{
    public class SportBackpack : Backpack
    {
        public int Pockets { get; set; }
        public bool Hydration { get; set; }

        public SportBackpack(string colors, double size, string materials, string brand, double volume, double weight, int pockets, bool hydration)
            : base(colors, size, materials, brand, volume, weight)
        {
            this.Pockets = pockets;
            this.Hydration = hydration;
            // Set specific values for MaxCapacity, MaxVolume, MaxWeight if required
        }

        // Implementing Clone method to handle cloning specific properties
        public override object Clone()
        {
            // Shallow clone the base class properties
            var cloned = (SportBackpack)this.MemberwiseClone();

            // Perform deep copy for reference types (if any)

            return cloned;
        }

       /* public override void HandleWater()
        {
            Console.WriteLine("Sport Backpack got wet!");
        }

        // No change in HandleFire() method

        public override void HandleSunlight()
        {
            Console.WriteLine("Sport Backpack is absorbing sunlight!");
        }
*/
        // Implementing Display method to show SportBackpack specific properties
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
