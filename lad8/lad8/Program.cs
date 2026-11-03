using System.Diagnostics;

namespace lad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 9, 1, 7 };



            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Number " + (i + 1) + ": " + numbers[i]);
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            float average = (float)sum / numbers.Length;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);

            int maximum = numbers[0];
            int minimum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maximum)
                {
                    maximum = numbers[i];
                }
                if (numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }
            }
            Console.WriteLine("Maximum: " + maximum);
            Console.WriteLine("Minimum: " + minimum);

            System.Array.Sort(numbers);
            foreach (int n in numbers)
            {
                Console.WriteLine("Sorted: " + n);
            }

            {

            }
        }

    }
}
