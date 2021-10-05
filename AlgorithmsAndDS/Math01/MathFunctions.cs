using System;

namespace Math01
{
    public class MathFunctions
    {

        #region Prime Number
        /// <summary>
        /// This function indicates if a specific number is a prime or not
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPrime(int number)
        {
            if (number == 1)
                return false;

            if (number == 2 || number == 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }
        #endregion

        #region Prime Factor
        // Good solution to find the prime factors
        public static void PrintPrimeFactors(int number)
        {
            if (number <= 1)
            {
                Console.WriteLine("Not prime factors");
                return;
            }

            for (int i = 2; i * i <= number; i++)
            {
                while (number % i == 0)
                {
                    Console.Write($"{i} ");
                    number = number / i;
                }
            }

            if (number > 1)
                Console.WriteLine(number);
            else
                Console.WriteLine();
        }

        // Very effiecient solution to detect the prime factor of a number
        public static void PrintPrimeFactorsQuickly(int number)
        {
            if (number <= 1)
            {
                Console.WriteLine("Number doesn't have prime factors");
                return; 
            }

            while (number % 2 == 0)
            {
                Console.Write($"2 ");
                number = number / 2; 
            }

            while (number % 3 == 0)
            {
                Console.Write("3 ");
                number = number / 3;
            }

            for (int i = 5; i * i <= number; i += 6)
            {
                while (number % i == 0)
                {
                    Console.Write($"{i} ");
                    number = number / i;
                }

                while (number % (i + 2) == 0)
                {
                    Console.WriteLine($"{i} ");
                    number = number / (i + 2);
                }
            }

            if (number > 3)
                Console.WriteLine($"{number} ");
            else
                Console.WriteLine();
        }
        #endregion 
    }
}
