using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class UseBreak
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your choice");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {

                case 1:
                    Console.WriteLine("Addition:" + (num1 + num2));
                    break;

                case 2:
                    Console.WriteLine("Substraction:" + (num1 - num2));
                    break;

                case 3:
                    Console.WriteLine("Multiplication:" + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("Division:" + (num1 / num2));
                    break;
                case 5:
                    Console.WriteLine("Mod:" + (num1 % num2));
                    break;
                default:
                    Console.WriteLine("You are in default case");
                    break;

            }

        }
    }
}
