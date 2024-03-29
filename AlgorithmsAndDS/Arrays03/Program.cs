﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// var array = new[] { 10, 12,0, 42, 41, 0, 11, 110, 42, 4 };
// var array2 = new[] { 10, 12, 42, 41, 11, 1, 42, 4 };
// var array3 = new[] { 2, 3, 10, 6, 4, 8, 1 };
// RotateArrayByX(array, 2);
// MaximumDifferenceWithOrder(array3);
// MoveZerosToEnd2(array);
// RotateArrayByOne(array);
// Array.Sort(array2);
// RemoveDublicates2(array2);
// Max(array);
// SecondMax(array);
// IsSorted(array2);
// ReverseArray(array);
// Console.ReadKey();

// Tapping Water 
TappingRainWater(new[] { 2, 0, 2 });
TappingRainWater(new[] { 3, 0, 1, 2, 5, 0 , 2 });

Console.ReadKey();

#region Methods
static void Max(int[] array)
{
    var max = 0;
    var index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
            index = i;
        }
    }

    Console.WriteLine($"{max} at {index + 1}");
}

static void SecondMax(int[] array)
{
    var last = 0;
    var previous = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > last)
        {
            previous = last;
            last = array[i];
        }

        if (array[i] > previous && array[i] < last)
        {
            previous = array[i];
        }
    }

    Console.WriteLine($"Second max {previous}");
}

static void IsSorted(int[] array)
{
    bool isSorted = true;
    for (int i = 0; i < array.Length; i++)
    {
        if (i > 0 && array[i] < array[i - 1])
        {
            isSorted = false;
            break; 
        }
    }

    Console.WriteLine($"Is Sorted {isSorted}");
}

static void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[array.Length - i - 1];
    }

    Console.WriteLine("Reveresed");
}

static void RemoveDublicates(int[] array)
{
    int[] newArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if (!Contains(newArray, array[i]))
            newArray[i] = array[i];
    }

    foreach (var item in newArray)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

static bool Contains(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
            return true; 
    }

    return false; 
}

static void RemoveDublicates2(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] - array[i - 1] == 0)
            array[i] = 0;
    }

    PrintArray(array);
}

static void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item}\t");
    }

    Console.WriteLine();
}

static void MoveZerosToEnd(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 0)
        {
            array[array.Length - 1] = 0;
            for (int j = i; j < array.Length - 1; j++)
            {
                array[j] = array[j + 1];
            }
        }
    }

    PrintArray(array);
}

static void MoveZerosToEnd2(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0)
        {
            int currentI = array[i];
            int currentCount = array[count];
            array[count] = currentI;
            array[i] = currentCount;
            count++;
        }
    }
    PrintArray(array);
}

static void RotateArrayByOne(int[] array)
{
    int firstElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        array[i - 1] = array[i];
    }

    array[array.Length - 1] = firstElement;
    PrintArray(array);
}

static void RotateArrayByX(int[] array, int d)
{
    var firstNumbers = new int[d];
    for (int i = 0; i < d; i++)
        firstNumbers[i] = array[i];

    for (int i = d; i < array.Length; i++)
    {
        array[i - d] = array[i];
    }

    for (int i = 0; i < d; i++)
        array[array.Length - d + i] = firstNumbers[i];

    PrintArray(array);
}

static void MaximumDifferenceWithOrder(int[] array)
{
    int maximumDifference = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        var difference = array[i + 1] - array[i];
        if (difference > maximumDifference)
            maximumDifference = difference;
    }

    Console.WriteLine($"Max Difference is {maximumDifference}");

}
#endregion 

#region Stock buy and sell problem 
static void StockBuyAndSell(int[] prices)
{
    int profits = 0; 

    for(int i = 1; i < prices.Length;i++)
    {
        if (prices[i] > prices[i - 1])
        {
            profits += prices[i] - prices[i - 1];
        }
    }
}
#endregion 

#region Tapping Rain Water 
static void TappingRainWater(int[] waters)
{
    if (waters.Length < 3)
    {
        Console.WriteLine("Cannot handle anything");
        return; 
    }

    int waterBlocks = 0; 
    int tempBlocks = 0; 
    int lastMaxLeft = 0;
    int lastMaxRight = 0; 
    bool isCollecting = false; 
    for(int i = 0; i < waters.Length; i++)
    {
        if (i == 0 && waters[i] == 0)
            continue; 

        if (!isCollecting)
        {
            isCollecting = true; 
            if (i == 0)
            {
                lastMaxLeft = waters[i];
                continue;
            }
        }
        else
        {
            if (waters[i] < lastMaxLeft)
            {
                tempBlocks += lastMaxLeft - waters[i];
            }
            else
            {
                lastMaxRight = waters[i]; 
                isCollecting = false; 
                waterBlocks += tempBlocks; 
                lastMaxLeft = lastMaxRight;
                tempBlocks = 0; 
            }
        }
        
    }

    Console.WriteLine($"Maximum collected water is {waterBlocks}");
}
#endregion 