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

            //MathFunctions.PrintDivisorsInOrder(30);
            //var stopwatch = new Stopwatch();
            //stopwatch.Start();
            //var result = Math.Pow(2, 54);
            //Console.WriteLine(result);
            ////Console.WriteLine(MathFunctions.Power(20, 20)); // Expect 32 
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);

            Console.WriteLine(BitMagic.CountSetBitsSimple(13));
            Console.WriteLine(BitMagic.CountSetBitsUsingBitwise(13));

            Console.WriteLine("Hello World!");
        }

        static void EatThink()
        {
            int i = 1;
            var p = new int[] { 0, 0, 0, 0, 0 };
            // 0 = hungry 
            // 1 = eating 
            // 2 = thinking

            //var senaphorms = new Semaphor
            do
            {
                // i is odd
                if (i % 2 != 0)
                {
                    if (p[i - 1] == 0) // hungry 
                    {
                        var left = p[(i - 1) % 5];
                        var right = p[i];

                        if (left != 1 && right != 1)
                        {
                            // left. wait 
                            // right .wait ()
                            p[i - 1] = 1;
                            System.Threading.Thread.Sleep(1000);
                            // left. signal();
                            // right. signalr(); 
                            p[i - 1] = 2; // Set to thinking 
                        }

                    }
                }
                else
                {
                    if (p[i - 1] == 0) // hungry 
                    {
                        var right = p[(i - 1) - 1];
                        var left = p[(i - 1)];

                        if (left != 1 && right != 1)
                        {
                            // left. wait 
                            // right .wait ()
                            p[(i - 1) - 1] = 1;
                            p[(i - 1)] = 1; 
                            System.Threading.Thread.Sleep(1000);
                            // left. signal();
                            // right. signalr(); 
                            p[i - 1] = 2; // Set to thinking 
                        }

                    }
                }
                Console.WriteLine($"{i + 1} - Takes {p[i]} & {p[(i + 1) % p.Length]}");
             

                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"{i + 1} - Releases {p[i]} & {p[(i + 1) % p.Length]}");

                i++;
            } while (i <= 5);
        }

    }
}
