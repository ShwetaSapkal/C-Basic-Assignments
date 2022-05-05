using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass5Array
{
    class Program3
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


            Console.WriteLine("Accept search element=");
            int search = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (arr[i] == search)
                {
                    Console.WriteLine("element fond at position" + i);
                }
            }




        }
    }
}
