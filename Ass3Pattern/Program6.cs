﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass3Pattern
{
    class Program6
    {
        static void Main(string[] args)
        {
            for (int i=1;i<=5;i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
           

        }
        
    }
}
