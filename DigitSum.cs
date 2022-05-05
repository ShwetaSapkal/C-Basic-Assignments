using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class DigitSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0  , sum=0;
            if (num > 99 && num < 1000)
            {
                Console.WriteLine("It is 3 digit number");
                for (count = 0; num > 0; count++)
                {
                    
                    sum = sum + num%10;
                    num = num / 100;
                }
                Console.WriteLine("Sum of three digit number is= "+sum);

            }

            else
            {
                Console.WriteLine("It is  not 3 digit number");
            }
        }
    }
}
