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


        // A constructor that sets the colors, size, materials, brand, volume, and weight of the backpack\\

        public Backpack(string colors, double size, string materials, string brand, double volume, double weight)
        {
            Colors = colors;
            Size = size;
            Materials = materials;
            Brand = brand;
            Volume = volume;
            Weight = weight;
        }
        public Backpack ShallowClone()
        {
            return (Backpack)this.MemberwiseClone();
        }

        // Abstract Clone method to be implemented by derived classes
        public abstract object Clone();

        // Other methods and properties...

        public abstract void Display();


    }
}
