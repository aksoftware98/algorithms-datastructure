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

        #endregion


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

        public static int RopeMaximumPieces(int n, int a, int b, int c)
        {
            if (n == 0)
                return 0;
            if (n < 0)
                return -1;

            int aLength = RopeMaximumPieces(n - a, a, b, c);
            int bLength = RopeMaximumPieces(n - b, a, b, c);
            int cLenth = RopeMaximumPieces(n - c, a, b, c);

            var max = new[] { aLength, bLength, cLenth }.Max();

            if (max == -1)
                return -1;

            return max + 1;

        }

        /// <summary>
        /// Print All possible chart sets from a basic string 
        /// ABC = A  B C AB AC BC ABC
        /// </summary>
        /// <param name="str"></param>
        /// <param name="current"></param>
        /// <param name="i"></param>
        public static void PrintAllPossibleChartSets(string str, string current = "", int i = 0)
        {
            if (i == str.Length)
            {
                Console.WriteLine(current);
                return; 
            }

            PrintAllPossibleChartSets(str, current, i + 1);
            PrintAllPossibleChartSets(str, current + str[i], i + 1);
        }

        public static void PrintSubsetSum(int[] array, int sum)
        {
            Console.WriteLine(SubsetSumCount(array, array.Length - 1, sum));
        }

        public static int SubsetSumCount(int[] array, int index, int sum)
        {
            if (index == 0)
                return sum == 0 ? 1 : 0;

            return SubsetSumCount(array, index - 1, sum) + SubsetSumCount(array, index - 1, sum - array[index - 1]);


        }
    }
}
