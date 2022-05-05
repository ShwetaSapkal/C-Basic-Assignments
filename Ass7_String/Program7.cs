using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass7_String
{
    class Program7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string s1 = Console.ReadLine();

            string rev = "";

            for (int i = s1.Length - 1; i >= 0; i--)
            {
                rev = rev + s1[i];
            }

            if (rev == s1)
            {
                Console.WriteLine("Pallindrome");
            }
            else
            {
                Console.WriteLine("Not Pallindrome");
            }

        }
    }
}
