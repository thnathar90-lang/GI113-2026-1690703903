/*
 * Student ID : 1690703903
 * Name       : Lab02
 * Section    : 129D
 * No.        :na
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        private static readonly int co;

        static void Main(string[] args)
        {
            int MaxHp;
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            // Lab02 Part A
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Max HP: {maxHp}");
            Console.WriteLine($"Current HP: {currentHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine(

              
        }
    }
}
