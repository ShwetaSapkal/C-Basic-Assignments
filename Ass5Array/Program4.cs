using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass5Array
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[size];
            Console.WriteLine("Enter elements in original array ");

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
          
            
            int[] arr2 = new int[arr1.Length];

          

            Console.WriteLine("Elements of new array");
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = arr1[i];
               
            }
           
            for (int i = 0; i < arr2.Length; i++)
            {

                Console.WriteLine(arr2[i]);
            }

        }
    }
}
