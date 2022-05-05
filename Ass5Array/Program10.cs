using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass5Array
{
    class Program10
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter size");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];
            // int max = int.MaxValue;
            int max = arr[0];

            Console.WriteLine("Enter elements");
            for (int i = 0; i < arr.Length; i++)
            { 
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("max=" + max);

            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("min=" + min);
        }
    }
}
