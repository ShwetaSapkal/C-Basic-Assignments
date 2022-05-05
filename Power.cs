using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class Power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter power");
            int index = Convert.ToInt32(Console.ReadLine());

            int result = 1;

            while (index>0)
            {
                result = result * b;
                --index;
            }
            Console.WriteLine(result);
        }
    }
}
