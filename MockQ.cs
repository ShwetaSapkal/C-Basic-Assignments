using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class MockQ
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  array size");
            int size1 = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[size1];

            Console.WriteLine("Enter eements");
            for (int i = 0; i < arr1.Length; i++)
            {

                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr1);

            Console.WriteLine("Sorted array =");
            foreach (int data in arr1)
            {
                Console.WriteLine(data+" ");
            }

        }
    }
}
