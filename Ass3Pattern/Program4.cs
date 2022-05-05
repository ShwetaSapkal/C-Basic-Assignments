using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass3Pattern
{
    class Program4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    int ch=65 ;
                    Console.Write((char)(ch+j-1)+" ");
                    
                }
                Console.WriteLine();
            }

        }

    }
}
