using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass4Test
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            int digit = 0, sum = 0, product = 1;

            while (num>0)
            {
                digit = num % 10;
                sum = sum + digit;
                product = product * digit;
                num = num / 10;
            }

            if (sum == product)
            {
                Console.WriteLine("Spy Number");
            }
            else
            {
                Console.WriteLine("Not Spy Number");
            }




        }
    }
}
