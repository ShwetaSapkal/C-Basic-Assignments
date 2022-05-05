using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass4Test
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= num1/2; i++)
            {
                if (num1 % i == 0)
                {
                    sum = sum + i;
                   // Console.WriteLine(sum);
                }

                
            }

            int sum1= 0;
            for (int i = 1; i <= num2 / 2; i++)
            {
                if (num2 % i == 0)
                {
                    sum1 = sum1 + i;

                }


            }

            if (num1 == sum1 && num2 == sum)
            {
                Console.WriteLine("amicable");
            }
            else
            {
                Console.WriteLine("not amicable");
            }


        }
    }
}
