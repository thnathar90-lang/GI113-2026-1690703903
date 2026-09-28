/*
* Student ID : 1690703903
* Name       : Assignment #2
* Section    : 129D
* No.        :na
* Course     : GI113 Computer Programming (GI)
*/
namespace Assignment__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double smeltRate = 0.2500;
            double savageRate = 0.3000;
            double maxBatch = 100;
            double lowerestNumber = 1;

            Console.WriteLine("========================");
            Console.WriteLine("   ---> The Forge <---  ");
            Console.WriteLine("========================");
            Console.WriteLine("Iron smelting: 0.25 / savage 0.3");
            Console.WriteLine(" Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine(" Key 'B' for Savage (Ingot -> Bar)");
            Console.WriteLine("Choose S OR B");

            bool ore = char.TryParse(Console.ReadLine(), out char material);
            if (material == 'S')
            {
                if (material == 'S')
                {
                    Console.WriteLine("How much would you like.");
                    double.TryParse(Console.ReadLine(), out double ironAmount);
                    if (ironAmount <= maxBatch && ironAmount >= lowerestNumber)
                    {
                        double foolgold = ironAmount * smeltRate;
                        Console.WriteLine($"You got {foolgold} iron bar");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Number, Try again");
                    }
                }
            }
            else if (material == 'B')
            {
                if (material == 'B')
                {
                    Console.WriteLine("How much would you like.");
                    double.TryParse(Console.ReadLine(), out double goldAmount);
                    if (goldAmount <= maxBatch && goldAmount >= lowerestNumber)
                    {
                        double gold = goldAmount * savageRate;
                        Console.WriteLine($"You got {gold} gold bar");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Number, Try again");
                    }
                }

            }
            else
            {
                Console.WriteLine("Out of option");
            }
        }
    }
}
