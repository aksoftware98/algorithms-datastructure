﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Penlndrom 
//while (true)
//{
//    Console.WriteLine("Palendrome Solutions (Enter a new word):");
//    var word = Console.ReadLine();
//    Console.WriteLine(Recurrersion02.RecurresionSolutions.IsPalendrome(word));
//    Console.WriteLine("Press any key to try again");
//    Console.ReadKey();
//}

// Check out first 
Console.WriteLine("Set a number");
int? number = Convert.ToInt32(Console.ReadLine());
var result = Recurrersion02.RecurresionSolutions.SumNumber(number.Value);
Console.WriteLine(result);