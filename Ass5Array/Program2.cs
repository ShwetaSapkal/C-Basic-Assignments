using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass5Array
{
    class Program2
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

            int sum = 0, avg = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
                avg = sum / size;

            }
            Console.WriteLine("Average value of array elements= "+avg);
        }
    }
}
