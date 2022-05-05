using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class HarshadNiven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            int digit=0,sum = 0;
            int temp = num;
            while (num > 0)
            {
                digit = num % 10;
                sum = sum + digit;
                num = num / 10;
            
            }

            if (temp%sum==0)
            {
                Console.WriteLine("It is Harshad Niven number");
            }
            else
            {
                Console.WriteLine("It is not Harshad Niven number");
            }

        }
    }
}
