using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class PallindromeFor
    {
        static void Main(string[] args)
        {

            int num = 0, digit = 0, rev = 0;

            for (int i = 100; i <= 500; i++)
            {
                
                while (num > 0)
                {
                    digit = num % 10;
                    rev = (rev * 10) + digit;
                    num = num / 10;
                }

                num = i;

                if (rev == i)
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}
