using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass4Test
{
    class Program5
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Red Blue");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("red");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("blue");
                }
                else
                {
                    Console.WriteLine(i);
                }

            
            }
        }
    }
}
