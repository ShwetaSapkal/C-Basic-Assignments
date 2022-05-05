using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass4Test
{
    class Program12
    {
        static void Main(string[] args)
        {
            char ch1 = '\0';
            char ch2 = '\0';

            for (int i = 1; i <=5; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = 1; j <= 5 - i + 1; j++)
                    {
                        Console.Write(j);
                    }

                }

                else
                {
                    ch1 = 'A';
                    for (int j = i; j <= 5; j++)
                    {
                        Console.Write(ch1);
                        ch1++;
                    }
                }
                Console.WriteLine();
            }

            for (int i=2;i<=5;i++)
            {
                ch2 = 'A';
                if (i % 2 == 0)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(ch2);
                        ch2++;
                    }
                }

                else
                {
                    ch1 = 'A';
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                }

                Console.WriteLine();
                
            }
        }
    }
}
