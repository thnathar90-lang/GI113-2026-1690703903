/*
* Student ID : 1690703903
* Name       : Lab05
* Section    : 129D
* No.        :na
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==> MY GAME DEE <<==");
            Console.WriteLine("Hero vs. Monster, Fight damage calulator\n");

            // Hero stats input
            Console.Write("Hero Health: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);
            Console.WriteLine();

            // Monster stats input
            Console.Write("Monster Health: ");
            bool monHpOk = int.TryParse(Console.ReadLine(), out int monHp);
            Console.Write("Monster Attack: ");
            bool monAtkOk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.Write("Monster Defense: ");
            bool monDefOk = int.TryParse(Console.ReadLine(), out int monDef);

            // input validation
            bool isHeroIntValid = heroHpOk && heroAtkOk && heroDefOk;
            bool isMonIntValid = monHpOk && monAtkOk && monDefOk;
            Console.WriteLine($"\nHERO STATUS VALID: {isHeroIntValid}");
            Console.WriteLine($"MONSTER STATUS VALID: {isMonIntValid}");
            Console.WriteLine($"[HERO] HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
            Console.WriteLine($"[MONSTER] HP: {monHp}, ATK: {monAtk}, DEF: {monDef}");
            //bool allIntValid = isHeroIntValid && isMonsterIntValid;

            // Compund assignment :+= จำลองสถานะการผู้เล่นดืม potion ก่อนต่อสู้
            int potionHeal = 8;
            heroHp += potionHeal; //แบบสั้น
            //heroHp = heroHp + potionHeal; แบบยาว
            Console.WriteLine($"\nHero drink a potion, healing {potionHeal} HP. Hero HP: {heroHp}");

            // Arithmetic +
            int normalDmg = Math.Max(0, heroAtk - monDef);  //ความแรงการโจมตีขั้นอยู่กับค่อป้อวกันของศัตรู
            Console.WriteLine($"\nNormal Attack would deal: {normalDmg} DMG");

            // Precedence
            int pwrDmg = Math.Max(0, (heroAtk * 2) - monDef);
            Console.WriteLine($"\nPower Attack would deal: {pwrDmg} DMG");

            // Random, Simple percent of critical chance
            Random randomSomething = new Random();
            int roll = randomSomething.Next(1, 101); // ต้อง +1 ค่ามากสุดเสมอ เช่นอยากได้ 100 ต้องใส่ 101
            bool isCrit = roll <= 10; // 10% chance จาก 100
            int critDmg = normalDmg + Convert.ToInt32(isCrit) * normalDmg;
            Console.WriteLine($"\nCritical hit roll: {roll} critical: {isCrit}");
            Console.WriteLine($"If critical, normal attck would instead deal: {critDmg} DMG");
        }
    }
}
