using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass5Array
{
    class Program5
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

            for (int i = arr.Length - 1; i >= 0; i--)
            {

                // arr[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("alternate element backwards=");
            /*for (int curIndx = arr.Length-1; curIndx >0; curIndx--)
            {
                if(curIndx%2==0)
                {
                    Console.WriteLine(curIndx+" ");
                }
            
           }
            */
            /*for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
            */

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }


        }

    }
}
