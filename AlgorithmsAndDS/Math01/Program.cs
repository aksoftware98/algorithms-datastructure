using System;
using System.Diagnostics;

namespace Math01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //var stopwatch = new Stopwatch();
            //stopwatch.Start(); 
            //MathFunctions.PrintPrimeFactors(45000000);
            //stopwatch.Stop();
            //Console.WriteLine($"{stopwatch.ElapsedMilliseconds}");
            //stopwatch.Reset();
            //stopwatch = new Stopwatch();
            //stopwatch.Start();
            //MathFunctions.PrintPrimeFactors(45000000);
            //stopwatch.Stop();
            //Console.WriteLine($"{stopwatch.ElapsedMilliseconds}");

            MathFunctions.PrintDivisorsInOrder(30);
            Console.WriteLine("Hello World!");
        }
    }
}
