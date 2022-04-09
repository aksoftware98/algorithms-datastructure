using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurrersion02
{
    public static class RecurresionSolutions
    {
        #region Palindrome 
        public static bool IsPalendrome(string text)
        {
            return IsPalendrome(text, 0, text.Length - 1);
        }

        private static bool IsPalendrome(string text, int start, int end)
        {
            if (start >= end)
                return true;

            return text[start] == text[end] && IsPalendrome(text, start + 1, end - 1);

        }
        #endregion

        #region Output check
        /// <summary>
        ///  4 3 2 1 1 2 3 4 
        /// </summary>
        /// <param name="number"></param>
        public static void Fun1(int number)
        {
            if (number == 0)
                return;

            Console.WriteLine(number);
            Fun1(number - 1);
            Console.WriteLine(number);
        }


        public static void Fun2(int number)
        {
            if (number == 0)
                return;

            Fun2(number - 1);
            Console.WriteLine(number);
            Fun2(number - 1);
        }

        // Calcualte the log of 2 Log2 => 16 = 4 , 8 = 3 
        public static int Fun3(int number)
        {
            if (number == 1)
                return 0;

            return 1 + Fun3(number / 2);
        }

        // Print the binary represetnation 
        public static void Fun4(int number)
        {
            if (number == 0)
                return;

            Fun4(number / 2);
            Console.WriteLine(number % 2);
        }

        // Calcualte the sum of all the numbers for a natural number
        public static int SumNumber(int n)
        {
            if (n == 0)
                return 0;

            return n + SumNumber(n - 1);
        }

        // Calculate the total sum of a digits 
        public static int CalculateDigitsSum(int n)
        {
            if (n == 0)
                return 0;

            var lastDigit = n % 10;
            return lastDigit + CalculateDigitsSum(n / 10);

        }
        #endregion 
    }
}
