using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass8Test_Arr_Str
{
    class ArrProgram1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st array size");
            int size1 = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[size1];

            Console.WriteLine("Enter  elements");
            for (int i = 0; i < arr1.Length; i++)
            {

                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("Enter 2nd array size");

            int size2 = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[size2];

            Console.WriteLine("Enter  elements");
            for (int i = 0; i < arr2.Length; i++)
            {

                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }



            int[] arr3 = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length + arr2.Length; i++)
            {
                for (int j = 0; j < arr3.Length; j++)
                {

                    Console.WriteLine(arr3[j]);
                }
            }

            
        }
    }
}
