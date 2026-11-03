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
            Console.WriteLine("==> GOMO <<==");
            Console.WriteLine("Hero vs. Monster, Fight damage calulator\n");

            Console.Write("Hero Health: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);
            Console.WriteLine();

            Console.Write("Monster Health: ");
            bool monHpOk = int.TryParse(Console.ReadLine(), out int monHp);
            Console.Write("Monster Attack: ");
            bool monAtkOk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.Write("Monster Defense: ");
            bool monDefOk = int.TryParse(Console.ReadLine(), out int monDef);

          
            bool isHeroIntValid = heroHpOk && heroAtkOk && heroDefOk;
            bool isMonIntValid = monHpOk && monAtkOk && monDefOk;
            Console.WriteLine($"\nHERO STATUS VALID: {isHeroIntValid}");
            Console.WriteLine($"MONSTER STATUS VALID: {isMonIntValid}");
            Console.WriteLine($"[HERO] HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
            Console.WriteLine($"[MONSTER] HP: {monHp}, ATK: {monAtk}, DEF: {monDef}");
           
          
            int potionHeal = 8;
            heroHp += potionHeal; 
           
            Console.WriteLine($"\nHero drink a potion, healing {potionHeal} HP. Hero HP: {heroHp}");

            
            int normalDmg = Math.Max(0, heroAtk - monDef);  
            Console.WriteLine($"\nNormal Attack would deal: {normalDmg} DMG");

            
            int pwrDmg = Math.Max(0, (heroAtk * 2) - monDef);
            Console.WriteLine($"\nPower Attack would deal: {pwrDmg} DMG");

          
            Random randomSomething = new Random();
            int roll = randomSomething.Next(1, 101);
            bool isCrit = roll <= 10; 
            int critDmg = normalDmg + Convert.ToInt32(isCrit) * normalDmg;
            Console.WriteLine($"\nCritical hit roll: {roll} critical: {isCrit}");
            Console.WriteLine($"If critical, normal attck would instead deal: {critDmg} DMG");
        }
    }
}
