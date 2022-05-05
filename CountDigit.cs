using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class CountDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            int digit = 0, count = 0;

            while (num!=0)
            {
                digit = num % 10;
                count++;
                num = num / 10;
            }
            Console.WriteLine("Digits in given number= "+count);
        }
    }
}
