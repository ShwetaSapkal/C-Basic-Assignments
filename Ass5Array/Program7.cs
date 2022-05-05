using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass5Array
{
    class Program7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[size];

            
            Console.WriteLine("Enter elements");

            for (int i = 0; i<arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Element to be inserted");
            int element = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter position");
            int pos = Convert.ToInt32(Console.ReadLine());


            int[] arr2 = new int[size+1];

            Console.WriteLine("insert element in original array");

            for (int i = 0; i < size+1; i++)
            {
                if (i < pos - 1)
                {
                    arr2[i] = arr1[i];
                }

                else if (i == pos - 1)
                {
                    arr2[i] = element;
                }

                else 
                {
                    arr2[i] = arr1[i - 1];
                }

            }

            Console.WriteLine("After insertion");
            for (int i = 0; i < size+1; i++)
            {
                Console.WriteLine(arr2[i]+" ");
                //Console.WriteLine();
            }




            }
    }
}
