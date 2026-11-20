using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class TwoDimensionalArrays
    {

        int[,] numberArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        //Prints the sum of each row of the array
        public void PrintRowSums()
        {

            for (int i = 0; i < numberArray.GetLength(0); i++)
            {
                int sum = 0;
                for (int n = 0; n < numberArray.GetLength(1); n++)
                {
                    sum += numberArray[i, n];
                }
                Console.WriteLine(sum);
            }
        }

        //prints the sum of each column in the array
        public void PrintColumnSums() { 
        


        }
    }
}
