/*
 * Student ID : 1690703903
 * Name       : Lab03
 * Section    : 129D
 * No.        :na
 * Course     : GI113 Computer Programming (GI)
 */
namespace lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level} / {MaxLevel}" +
                $"\nHP: {currentHp} / {maxHp}" +
                $"\nAttack Power: {attackPower}" +
                $"\nCritical Multiplier: {critMultiplier}" +
                $"\nIs Boss: {isBoss}");

            // Inplicit conversion: currentHp (int) --> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpAsDouble = currentHp; // (double)currentHpDouble = (int)currentHp
            Console.WriteLine($"HP (double): {currentHpAsDouble}");


            // Calculate Percent -->> double
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpAsDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercentExact}%");


            // Explicit conversion Cast attackPower (float) --> int
            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            int big = (int)attackPower;
            Console.WriteLine($"Attack Power (int): {big}");


            // cast vs. Convert criMultiplier (double) --> int
            Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");
            int castcrit = (int)critMultiplier; 
            int convertcrit = Convert.ToInt32(critMultiplier);

            Console.WriteLine();

            Console.WriteLine($"Cast Crit Multiplier (int): {castcrit}");
            Console.WriteLine($"Cast Crit Multiplier (int): {convertcrit}");
        }
    }
}
