using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass8Test_Arr_Str
{
    class ArrProgram2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[size];

            Console.WriteLine("Enter array elements");

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < arr1.Length; i++)
            {
                /*int temp = arr1[0];
                arr1[0] = arr1[arr1.Length - 2];
                arr1[arr1.Length - 2] = temp;

                arr1[1] = arr1[arr1.Length - 1];
                arr1[arr1.Length - 1] = temp;

                //arr1[arr1.Length - 1]=arr1[1];
                //arr1[1] = arr1[arr1.Length - 1];
                //arr1[arr1.Length - 1] = temp;
                */
                

                Console.WriteLine("After swapping first two elemnts and last two elements are=" + arr1[i]);

            }


        }
    }
}
