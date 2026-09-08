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

using System.Runtime.CompilerServices;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Starlight Ascension"; // const, PascalCase

            var heroName = "GOD";     // var บน string — ต้องให้ compiler เดาชนิด
            var heroRank = "SS";         // var บน char
            int heroLevel = 1000;
            float critChance = 10000f;
            double staminaPrecise = 100.5;  // เลขหลังจุดเป็น 5 ขึ้นไป
            bool isPlayable = true;

            Console.WriteLine($"===== {GameTitle} =====");
            Console.WriteLine($"Hero Name   : {heroName}");
            Console.WriteLine($"Rank        : {heroRank}");
            Console.WriteLine($"Level       : {heroLevel}");
            Console.WriteLine($"Crit Chance : {critChance}");
            Console.WriteLine($"Stamina     : {staminaPrecise}");
            Console.WriteLine($"Playable    : {isPlayable}");
            Console.WriteLine();

            double heroLevelAsDouble = heroLevel; // implicit — ไม่มี cast
            Console.WriteLine($"Level as double (implicit): {heroLevelAsDouble}");

            int staminaTruncated = (int)staminaPrecise;               // explicit cast
            int staminaRounded = Convert.ToInt32(staminaPrecise);      // Convert
            Console.WriteLine($"Stamina cast (truncates)  : {staminaTruncated}");
            Console.WriteLine($"Stamina Convert (rounds)  : {staminaRounded}");
        }
    }
}
