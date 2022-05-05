// WAP to add eleents to single dimensional int array and print lements from 1D array.

using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass5Array
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter elements");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
              
            }
            Console.WriteLine("Inserted elements are=");
            for (int i = 0; i < arr.Length; i++)
            {
               
                Console.WriteLine(arr[i]);
            }




        }
    }
}
