using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass4Test
{
    class Program7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());

           

            int cube = num * num * num;

            bool isTriomorphic = true;

            while (num > 0)
            {
                int digit1 = num % 10;
                int digit2 = cube % 10;

                if (digit1 != digit2)
                {
                    isTriomorphic = false;
                    break;
                }

                num = num / 10;
                cube = cube / 10;



                
            }

            if (isTriomorphic)
            {
                Console.WriteLine("Triomorphic");
            }
            else
            {
                Console.WriteLine("Not Triomorphic");
            }
        }
    }
}
