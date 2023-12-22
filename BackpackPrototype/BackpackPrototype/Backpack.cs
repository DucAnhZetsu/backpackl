using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpackPrototype
{
    public abstract class Backpack : ICloneable
    {
        public string Colors { get; set; }
        public double Size { get; set; }
        public string Materials { get; set; }
        public string Brand { get; set; }
        public double Volume { get; set; }
        public double Weight { get; set; }


        // A constructor that sets the colors, size, materials, brand, volume, and weight of the backpack
        public Backpack(string colors, double size, string materials, string brand, double volume, double weight)
        {
            this.Colors = colors;
            this.Size = size;
            this.Materials = materials;
            this.Brand = brand;
            this.Volume = volume;
            this.Weight = weight;
            // Use some default values for the max capacity, volume, and weight
        }
        // Modify the ShallowClone method to return a cloned instance
        public Backpack ShallowClone()
        {
            return (Backpack)this.MemberwiseClone();
        }

        // Modify the Clone method to be overridden by derived classes
        public abstract object Clone();

        // Modify the Display method to be overridden by derived classes

        /*public virtual void HandleWater()
        {
            Console.WriteLine("This backpack got wet.");
            // You can add further logic for handling water for a generic backpack here
        }

        public virtual void HandleFire()
        {
            Console.WriteLine("This backpack caught fire.");
            // You can add further logic for handling fire for a generic backpack here
        }

        public virtual void HandleSunlight()
        {
            Console.WriteLine("This backpack is exposed to sunlight.");
            // You can add further logic for handling sunlight for a generic backpack here
        }*/
        public abstract void Display();


    }
}
