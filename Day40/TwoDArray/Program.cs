using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDArray
{
    public class TwoDiamentionalArray
    {

        public static void Main(string[] args)


        {

            string[][] numArray = new string[6][];

            int largestSum = 0;



            for (int i = 0; i < 6; i++)

            {

                numArray[i] = Console.ReadLine().Split(' ');

            }



            for (int i = 0; i <= 3; i++)

            {

                for (int j = 0; j <= 3; j++)

                {

                    int sum = Convert.ToInt32(numArray[i][j]) + Convert.ToInt32(numArray[i][j + 1]) +

                              Convert.ToInt32(numArray[i][j + 2]) + Convert.ToInt32(numArray[i + 1][j + 1]) +

                              Convert.ToInt32(numArray[i + 2][j]) + Convert.ToInt32(numArray[i + 2][j + 1]) +

                              Convert.ToInt32(numArray[i + 2][j + 2]);



                    if (i == 0 && j == 0)

                    {

                        largestSum = sum;

                    }

                    else

                    {

                        if (sum > largestSum)

                        {

                            largestSum = sum;

                        }

                    }

                }

            }

              Console.WriteLine(largestSum);

        }

    }
}
