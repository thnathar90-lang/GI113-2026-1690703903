/*
 * Student ID :
 * Name       :
 * Section    :
 * No.        :
 * Student ID : 1690703903
 * Name       : Lab04
 * Section    : 129D
 * No.        :na
 * Course     : GI113 Computer Programming (GI)
 */
namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+---------------------------------------------------+");
            Console.WriteLine("|           NEM ADVENTURE                           |");
            Console.WriteLine("+---------------------------------------------------+");

            Console.WriteLine("Name your character:");

            string playerName = Console.ReadLine();
            Console.WriteLine($"\nWelcome, {playerName}! Your journey begins..");

            Console.WriteLine("+---------------------------------------------------+");
            Console.WriteLine("|           DIFFICULTY SELECT                       |");
            Console.WriteLine("+---------------------------------------------------+");

            Console.Write("Choose difficulty level (1-3):");
            int difficultyLevel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n\"Difficulty level {difficultyLevel} selected. Good luck out there...\"");

            Console.WriteLine("+---------------------------------------------------+");
            Console.WriteLine("|           ITEM SHOP                               |");
            Console.WriteLine("+---------------------------------------------------+");
            Console.Write("How many potions?");

            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input : {isValid}");
            Console.WriteLine($"quantity of : {quantity}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION       |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}");
        }
    }
}