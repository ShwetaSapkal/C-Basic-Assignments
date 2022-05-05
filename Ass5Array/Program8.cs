using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass5Array
{
    class Program8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];


            Console.WriteLine("Enter elements");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("count of all negative elements in array");
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                   
                    count++;
                    
                }
               
            }
            Console.WriteLine(count);
        }
    }
}
