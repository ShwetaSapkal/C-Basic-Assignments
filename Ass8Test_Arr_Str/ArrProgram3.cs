using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass8Test_Arr_Str
{
    class ArrProgram3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[size];
            int[] freq = new int[size];

            Console.WriteLine("Enter array elements");

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                freq[i] = -1;
            }



            for (int i = 0; i < arr1.Length; i++)
            {
                int cnt = 1;

                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        cnt++;
                        freq[j] = 0;

                    }

                }
                if (freq[i] != 0)
                {
                    freq[i] = cnt;
                }

            }

            Console.WriteLine("freqency");
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] != 0)
                {
                    Console.WriteLine(" "+arr1[i]+" "+freq[i]);
                }
            }

           

        }
    }
}
