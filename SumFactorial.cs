using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class SumFactorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            int fact = 1, sum = 0;

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
                sum = sum + fact;
            }

            Console.WriteLine(sum);
        }
    }
}
