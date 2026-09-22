/*
* Student ID : 1690703903
* Name       : Lab06
* Section    : 129D
* No.        :na
* Course     : GI113 Computer Programming (GI)
*/

using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int drumset = 100;
            int guitar = 20;
            int enemyHp = 100;
            int hereHp = 120;
            int Violin = 60; 

            Console.WriteLine("Musical Magic");

            Console.WriteLine("ACTION 1: PLAY DRUMS ");
            Console.WriteLine("ACTION 2: PLAY GUITAR");
            Console.WriteLine("ACTION 3: PLAY VIOLIN");

            Console.WriteLine("+++> CHOOSE YOUR NEXT MOVE (1 -3): ");
            bool isValidInput = int.TryParse(Console.ReadLine(), out int choice );

            if (!isValidInput || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
            }   
             else if (choice == 1)
            {
                enemyHp -= drumset;
                Console.WriteLine(enemyHp);
                if (enemyHp <= 0)
                {
                    Console.WriteLine($"Enemy hit with drums! took {drumset} damage. Enemy has {enemyHp} HP left.");
                }   
            }
            else if (choice == 2)
            {
                enemyHp -= guitar;
                if (enemyHp <= 0)
                {
                    Console.WriteLine($"Enemy hit with guitar! took {guitar} damage. Enemy has {enemyHp} HP left.");
                }
            }
            else if (choice == 3)
            {
                enemyHp += Violin;
                if (enemyHp <= 0)
                {
                    Console.WriteLine($"Enemy hit with violin! took {Violin} damage. Hero has {hereHp} .");
                }
            }

        }
    }
}
