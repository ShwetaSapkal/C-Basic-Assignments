using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class Maximum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 3rd number");
            int num3 = Convert.ToInt32(Console.ReadLine());


            if ((num1>num2) && (num1>num3))
            {
                Console.WriteLine("num1 is greater");
            }
            else if ((num2>num1) && (num2>num3))
            {
                Console.WriteLine("num2 is greater");
            }
            else
            {
                Console.WriteLine("num3 is greater ");
            }



        }
    }
}
