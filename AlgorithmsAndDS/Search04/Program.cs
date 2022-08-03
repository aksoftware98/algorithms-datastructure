// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] array = new[] { 1, 4, 7, 10, 10, 12, 15, 20, 25, 30, 32, 38, 40 };
var number = 32;
var result = BinarySearch(array, number);
Console.WriteLine($"Result of {number} is {result}");

#region Binary Search Implementation 
// 1 4 7 10 10 12 15 20 25 30 32 38 40 
static int BinarySearch(int[] array, int number)
{
    int low = 0;
    int height = array.Length - 1;

    while (low < height)
    {
        int mid = (low + height) / 2;

        if (array[mid] > number)
        {
            height = mid - 1;
        }
        else if (array[mid] < number)
        {
            low = mid;
        }
        else
        {
            return mid; 
        }
            
    }
    
    return -1; 
}
#endregion

#region First Recurrecne of an element in array 
#region Recurrsive 
static int FirstRecurrenceRecusrive(int[] array, int low, int height, int x)
{
    if (low > height)
        return -1;

    int mid = (low + height) / 2; 
    if (array[mid] > x)
    {
        return FirstRecurrenceRecusrive(array, low, mid - 1, x);
    }
    else if (array[mid] < x)
    {
        return FirstRecurrenceRecusrive(array, mid + 1, height, x);
    }
    else
    {
        if (mid == 0 || array[mid - 1] != x)
            return mid;
        else
            return FirstRecurrenceRecusrive(array, low, mid - 1, x);
    }
}
#endregion 
#endregion