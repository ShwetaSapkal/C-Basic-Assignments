using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class DivisibleBy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 5 == 0 && num % 11 == 0)
            {
                Console.WriteLine("number is divisible");
            }
            else
            {
                Console.WriteLine("number is not divisible");
            }
        }

    }
}
