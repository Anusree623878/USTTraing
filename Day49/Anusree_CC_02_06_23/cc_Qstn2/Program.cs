using System;

class Program
{
    static void Main(string[] args)
    {
        object[] mixedArray = { 1, 2, 3, "Hello", "World" };

        PrintArray(mixedArray);
    }

    static void PrintArray(object[] array)
    {
        foreach (object element in array)
        {
            Console.WriteLine(element);
        }
    }
}

