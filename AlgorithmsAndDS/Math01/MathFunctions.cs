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

        #region Ordered Divisors 
        /// <summary>
        /// Opmtimzed function to print all the divisors of a number in a ascending order
        /// </summary>
        /// <param name="n"></param>
        public static void PrintDivisorsInOrder(int n)
        {
            int i = 0;
            for (i = 1; i * i < n; i++)
            {
                if (n % i == 0)
                    Console.WriteLine(i);
            }
            for(; i >= 1; i--)
            {
                if (n % i == 0)
                    Console.WriteLine(n / i);
            }
        }
        #endregion

        #region Power
        /// <summary>
        /// Calculate the power of number
        /// </summary>
        /// <param name="n">Basic number</param>
        /// <param name="power">The number of power</param>
        /// <returns></returns>
        public static decimal Power(int x, int n)
        {
            if (n == 0)
                return 1;

            if (n == 1)
                return x;

            // check if n is odd 
            if (n % 2 == 0)
            {
                return Power(x, n / 2) * Power(x, n / 2); 
            }
            else
            {
                return Power(x, n / 2) * Power(x, n / 2) * x; 
            }
        }

        public static decimal PowerIterative(int x, int n)
        {
            if (n == 0)
                return 1;

            decimal result = x;
            while (n > 0)
            {
                if (n % 2 != 0)
                    result *= 0;
            }

            return 0;
        }
        #endregion

        #region 
        public static void Shit()
        {
            static void EatThink()
            {
                int i = 1;
                // philisophers status 
                var p = new int[] { 0, 0, 0, 0, 0 };
                var c = new int[] { 0, 0, 0, 0, 0 };
                // new sempahorm array ; 

                // 0 = hungry 
                // 1 = eating 
                // 2 = thinking

                do
                {
                    // i is odd
                    if (i % 2 != 0)
                    {
                        if (p[i] == 0) // hungry 
                        {
                            // Get the left chopstick 
                            var left = c[i];  // wait()
                            var right = c[(i + 1) % 5]; // wait ()
                         
                            // Change philispher status to eating 
                            p[i] = 1;
                            // Eat 

                            // release c[i] & c[(i + 1) % 5]
                        }
                    }

                    // i is even 
                    else
                    {
                        if (p[i] == 0) // hungry 
                        {
                            // Get the left chopstick 
                            var right = c[i];  // wait()
                            var left = c[i + 1]; // wait ()

                            // Change philispher status to eating 
                            p[i] = 1;
                            // Eat 

                            // release c[i] & c[(i + 1)]
                        }
                    }
                    
                } while (true);
            }
        }
        #endregion 
    }
}
