using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class Pallindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            int digit = 0, rev = 0,temp = num;

            for (int i = 1; num > 0; i++)
            {
                digit = num % 10;
                rev = (rev * 10) + digit;
                num = num / 10;
            }
           
            if (rev == temp)
            {
                Console.WriteLine("It is Pallindrome number");
            }
            else
            {
                Console.WriteLine("It is not pallindrome number ");
            }
        }
    }
}
