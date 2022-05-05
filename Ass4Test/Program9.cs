using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass4Test
{
    class Program9
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            { 
                for(int j=i;j>=1;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
