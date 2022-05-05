using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass4Test
{
    class Program10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            bool isnum1Prime = true;
            for (int i = 2; i <= num1 / 2; i++)
            {
                if (num1 % i == 0)
                {
                    isnum1Prime=false;
                    break;
                }
            }


            bool isnum2Prime = true;
            for (int i = 2; i <= num2 / 2; i++)
            {
                if (num2 % i == 0)
                {
                    isnum2Prime = false;
                    break;
                }
            }

            if (num1 - num2 == 2)
            {
                Console.WriteLine("twin prime");
            }
            else
            {
                Console.WriteLine("not twin prime");
            }



        }
    }
}
