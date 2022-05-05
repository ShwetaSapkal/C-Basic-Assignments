using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass8Test_Arr_Str
{
    class ArrProgram7
    {
        static void Main(string[] args)
        {
            int[,] arr2d = { {22,31,9 }, { 12,25,16 } };
            //3 X 4;

            int max;

            for (int r = 0; r < arr2d.GetLength(0); r++)
            {
                max = int.MinValue;

                for (int c = 0; c < arr2d.GetLength(1); c++)
                {
                    if (arr2d[r, c] > max)
                    {
                        max = arr2d[r, c];
                    }


                }

                Console.WriteLine($"Max on row {r} is {max}");
            }

        }
    }
}