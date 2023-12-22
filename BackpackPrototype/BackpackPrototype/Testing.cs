using System;

namespace BackpackPrototype
{
    class Testing
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Backpack Tester!");

            FirefighterBackpack firefighterBackpack = null;
            SmartBackpack smartBackpack = null;
            SportBackpack sportBackpack = null;

            bool addMoreBackpacks = true;

            while (addMoreBackpacks)
            {
                Console.WriteLine("\nEnter backpack details:");
                Console.Write("Colors: ");
                string colors = Console.ReadLine();
                // Get other common backpack details from the user...
                // For example:
                Console.Write("Size: ");
                double size = double.Parse(Console.ReadLine());

                Console.Write("Materials: ");
                string materials = Console.ReadLine();

                Console.Write("Brand: ");
                string brand = Console.ReadLine();

                Console.Write("Volume: ");
                double volume = double.Parse(Console.ReadLine());

                Console.Write("Weight: ");
                double weight = double.Parse(Console.ReadLine());


                Console.WriteLine("Choose the type of backpack to add:");
                Console.WriteLine("1. Firefighter Backpack");
                Console.WriteLine("2. Smart Backpack");
                Console.WriteLine("3. Sport Backpack");
                Console.Write("Enter choice (1-3): ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Get additional firefighter-specific details from the user
                        Console.Write("Enter tools: ");
                        string tools = Console.ReadLine();
                        Console.Write("Is it fire-resistant? (true/false): ");
                        bool fireResistance = bool.Parse(Console.ReadLine());

                        firefighterBackpack = new FirefighterBackpack(colors, size, materials, brand, volume, weight, tools, fireResistance);
                        break;

                    case 2:
                        // Get additional smart-specific details from the user
                        Console.Write("Enter laptop size (in inches): ");
                        int laptopSize = int.Parse(Console.ReadLine());
                        Console.Write("Does it have a battery? (true/false): ");
                        bool hasBattery = bool.Parse(Console.ReadLine());

                        smartBackpack = new SmartBackpack(colors, size, materials, brand, volume, weight, laptopSize, hasBattery);
                        break;

                    case 3:
                        // Get additional sport-specific details from the user
                        Console.Write("Enter number of pockets: ");
                        int pockets = int.Parse(Console.ReadLine());
                        Console.Write("Does it have hydration? (true/false): ");
                        bool hydration = bool.Parse(Console.ReadLine());

                        sportBackpack = new SportBackpack(colors, size, materials, brand, volume, weight, pockets, hydration);
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine("\nDo you want to add another backpack? (yes/no): ");
                string addAnother = Console.ReadLine().ToLower();

                if (addAnother != "yes")
                {
                    addMoreBackpacks = false;
                }
            }

            // Display all added backpacks
            Console.WriteLine("\nFirefighter Backpack:");
            if (firefighterBackpack != null)
            {
                firefighterBackpack.Display();
            }
            else
            {
                Console.WriteLine("No Firefighter Backpack created.");
            }

            Console.WriteLine("\nSmart Backpack:");
            if (smartBackpack != null)
            {
                smartBackpack.Display();
            }
            else
            {
                Console.WriteLine("No Smart Backpack created.");
            }

            Console.WriteLine("\nSport Backpack:");
            if (sportBackpack != null)
            {
                sportBackpack.Display();
            }
            else
            {
                Console.WriteLine("No Sport Backpack created.");
            }
        }
    }
}
