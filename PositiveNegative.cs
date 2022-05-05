using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class PositiveNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("number is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("number is negative");
            }
            else
            {
                Console.WriteLine("number is zero");
            }

        }
    }
}
