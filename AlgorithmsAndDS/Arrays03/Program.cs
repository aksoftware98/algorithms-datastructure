// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var array = new[] { 10, 12, 42, 41, 11, 1, 42, 4 };
var array2 = new[] { 10, 12, 42, 41, 11, 1, 42, 4 };
Array.Sort(array2);
Max(array);
SecondMax(array);
IsSorted(array2);

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
#endregion 