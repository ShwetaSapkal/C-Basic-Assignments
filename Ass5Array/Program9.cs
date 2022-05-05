using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass5Array
{
    class Program9
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


            int[] even = new int[size];
            int[] odd = new int[size];
            int evencount = 0, oddcount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[evencount] = arr[i];
                    evencount++;
                }

                else
                {
                    odd[oddcount] = arr[i];
                    oddcount++;
                }
            }

            Console.WriteLine("Elements of even array are");
            for (int i = 0; i < evencount; i++)
            {
                Console.WriteLine(even[i]);
            }

            Console.WriteLine("Elements of odd array are");
            for (int i = 0; i < oddcount; i++)
            {
                Console.WriteLine(odd[i]);
            }



        }
    }
}
