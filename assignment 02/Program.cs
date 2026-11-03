/*
* Student ID : 1690703903
* Name       : assignment_02
* Section    : 129D
* No.        :na
* Course     : GI113 Computer Programming (GI)
*/

namespace assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double smeltRate = 0.2500;
            const double savageRate = 0.3000;
            const double maxBatch = 100;
            const double low = 1;

            Console.WriteLine("===============");
            Console.WriteLine("    The Forge  ");
            Console.WriteLine("===============");
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
                    if (ironAmount <= maxBatch && ironAmount >= low )
                    {
                        double iron = ironAmount * smeltRate;
                        Console.WriteLine($"You forge to {iron} iron bar");
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
                    if (goldAmount <= maxBatch && goldAmount >= low )
                    {
                        double gold = goldAmount * savageRate;
                        Console.WriteLine($"You forge to {gold} iron bar");
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
