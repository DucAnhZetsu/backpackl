using System;
using System.Linq;
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

            while (true)
            {
                double sizeLimit = 20; // Maximum size limit for the backpack
                double volumeLimit = 6; // Maximum volume limit for the backpack
                double weightLimit = 6; // Maximum weight limit for the backpack

                Console.WriteLine("\nEnter backpack details:");
                string colors = GetUserInput("Colors");
                double size = GetDoubleUserInput("Size", sizeLimit);
                string materials = GetUserInput("Materials");
                string brand = GetUserInput("Brand");
                double volume = GetDoubleUserInput("Volume", volumeLimit);
                double weight = GetDoubleUserInput("Weight", weightLimit);


                int choice = GetBackpackChoice();

                switch (choice)
                {
                    case 1:
                        string tools = GetUserInput("Tools");
                        bool fireResistance = GetBooleanUserInput("Fire-resistant");
                        firefighterBackpack = new FirefighterBackpack(colors, size, materials, brand, volume, weight, tools, fireResistance);
                        break;

                    case 2:
                        int laptopSize = GetIntUserInput("Laptop size (in inches)", 20); // Assuming 20 is the maximum size limit for a laptop

                        /*int laptopSize = GetIntUserInput("Laptop size (in inches)");*/
                        bool hasBattery = GetBooleanUserInput("Has battery");
                        smartBackpack = new SmartBackpack(colors, size, materials, brand, volume, weight, laptopSize, hasBattery);
                        break;

                    case 3:
                        int pockets = GetIntUserInput("Number of pockets",10);
                        bool hydration = GetBooleanUserInput("Has hydration");
                        sportBackpack = new SportBackpack(colors, size, materials, brand, volume, weight, pockets, hydration);
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                if (!PromptToAddAnotherBackpack())
                {
                    break;
                }
            }

            DisplayBackpackDetails("Firefighter Backpack", firefighterBackpack);
            DisplayBackpackDetails("Smart Backpack", smartBackpack);
            DisplayBackpackDetails("Sport Backpack", sportBackpack);
        }

        // Helper methods to get user inputs
        static string GetUserInput(string prompt)
        {
            while (true)
            {
                Console.Write($"{prompt}: ");
                string userInput = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(userInput) && !userInput.Any(char.IsDigit))
                {
                    return userInput;
                }

                Console.WriteLine("Invalid input. Please enter a valid non-numeric string or character.");
            }
        }



        static double GetDoubleUserInput(string prompt, double maxValue)
        {
            double result;
            while (true)
            {
                Console.Write($"{prompt}: ");
                if (double.TryParse(Console.ReadLine(), out result) && result <= maxValue)
                {
                    return result;
                }
                Console.WriteLine($"Invalid input. Please enter a valid number (not exceeding {maxValue}).");
            }
        }


        static int GetIntUserInput(string prompt, int maxValue)
        {
            int result;
            while (true)
            {
                Console.Write($"{prompt}: ");
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    if (result <= maxValue && result > 0) // Check if the value is within the limit and positive
                    {
                        return result;
                    }
                    Console.WriteLine($"Please enter a valid number between 1 and {maxValue}.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        static bool GetBooleanUserInput(string prompt)
        {
            while (true)
            {
                Console.Write($"{prompt} (true/false): ");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "true" || userInput == "false")
                {
                    return bool.Parse(userInput);
                }
                Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
            }
        }

        static int GetBackpackChoice()
        {
            while (true)
            {
                Console.WriteLine("\nChoose the type of backpack to add:");
                Console.WriteLine("1. Firefighter Backpack");
                Console.WriteLine("2. Smart Backpack");
                Console.WriteLine("3. Sport Backpack");
                Console.Write("Enter choice (1-3): ");

                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 3)
                {
                    return choice;
                }
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
            }
        }

        static bool PromptToAddAnotherBackpack()
        {
            while (true)
            {
                Console.Write("\nDo you want to add another backpack? (yes/no): ");
                string addAnother = Console.ReadLine().ToLower();
                if (addAnother == "no")
                {
                    return false;
                }
                else if (addAnother == "yes")
                {
                    return true;
                }
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }
        }

        static void DisplayBackpackDetails(string backpackType, Backpack backpack)
        {
            Console.WriteLine($"\n{backpackType}:");
            if (backpack != null)
            {
                backpack.Display();
            }
            else
            {
                Console.WriteLine($"No {backpackType} created.");
            }
        }
    }
}