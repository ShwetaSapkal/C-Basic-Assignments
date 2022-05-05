using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass8Test_Arr_Str
{
    class ArrProgram4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine("Enter elements");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }




        }
    }
}
