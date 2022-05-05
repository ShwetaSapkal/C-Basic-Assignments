using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class LoopWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter choice");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch(ch)
            {
                case 1:
                    if (ch == 1)
                    {
                        Console.WriteLine("One");
                     }
                    break;
                case 2:
                    if (ch == 2)
                    {
                        Console.WriteLine("Two");
                    }
                    break;
                case 3:
                    if (ch == 3)
                    {
                        Console.WriteLine("Three");
                    }
                    break;
                case 4:
                    if (ch == 4)
                    {
                        Console.WriteLine("Four");
                    }
                    break;
                case 5:
                    if (ch == 1)
                    {
                        Console.WriteLine("Five");
                    }
                    break;
                default: Console.WriteLine("Invalid i/p");
                    break;

            }
        }
    }
}
