using System;

namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("mod1");
            Console.WriteLine("mod2");
            Console.WriteLine("mod3");
            int[] numbers = { 10, 5, 15, 20, 30 };
            double avarage = FindAvarage(numbers);
            Console.WriteLine("avarage " + avarage);
            int max = FindMaxValue(numbers);
            Console.WriteLine("max " + max);
        }

        public static double FindAvarage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                Console.WriteLine("zle dane");
            }

            int suma = 0;
            foreach (int num in numbers)
            {
                suma += num;
            }

            return suma/ numbers.Length;
        }

        public static int FindMaxValue(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                Console.WriteLine("blad");
            }

            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
                
                    
                
            }

            return max;
        }
    }
}