using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Not leap year");
            }

        }

    }
}
