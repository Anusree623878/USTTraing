
using System;

using System.Collections.Generic;

using System.Linq;

class Result

{

    public static int Candles(List<int> candles)

    {

        int maxHeight = 0;

        int count = 0;

        foreach (int height in candles)

        {

            if (height > maxHeight)

            {

                maxHeight = height;

                count = 1;

            }

            else if (height == maxHeight)

            {

                count++;

            }

        }

        return count;

    }

}

class Solution

{

    public static void Main(string[] args)

    {

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.Candles(candles);

        Console.WriteLine(result);

    }

}