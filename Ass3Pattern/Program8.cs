using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass3Pattern
{
    class Program8
    {

        static void Main(string[] args)
        {
            
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                    
                }

                for (int k = i; k <= 5; k++)
                {
                    Console.WriteLine(k+"");
                }
                Console.WriteLine();

            }


        }
    }
}
