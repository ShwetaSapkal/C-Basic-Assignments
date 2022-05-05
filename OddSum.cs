using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class OddSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter limit of number");
            int lno = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter starting  number");
            int sno = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i <= lno; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum ofodd numbers=" + sum);

        }
    }
}